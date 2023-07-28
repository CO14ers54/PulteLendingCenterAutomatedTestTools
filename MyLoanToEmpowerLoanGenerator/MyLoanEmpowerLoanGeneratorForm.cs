using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;
using Pulte.Eda.NetStandard.Messages;
using Pulte.Eda.Gateway;
using Pulte.Foundation.NetStandard.Base;
using System.Collections.Specialized;
using System.Linq;
using System.IO;

namespace MyLoanToEmpowerLoanGenerator
{
    public partial class MyLoanEmpowerLoanGeneratorForm : Form
    {
        private string _selectedLoanTemplateType = string.Empty;
        private string _selectedLoanQuestionnaireTemplateXmlFilename = string.Empty;
        private const string comboBoxPlaceholder = "Select a Loan Type...";
        private int _numberOfLoansToGenerate = 0;

        public MyLoanEmpowerLoanGeneratorForm()
        {
            InitializeComponent();
        }

        private void generateLoansButton_Click(object sender, EventArgs e)
        {
            WriteRichTextMessageToForm($"Preparing to process Loan Generation...", Color.Black);

            textBoxProcessing.Text = "";

            bool errors = CheckInputsPriorToProcessing();
            if (errors)
                return;

            Dictionary<string, string> myLoanQuestionnaireXmlTemplateFiles = Settings.Instance.SettingsDto.MyLoanQuestionnaireXmlTemplateFileDictionary;
            _selectedLoanQuestionnaireTemplateXmlFilename = myLoanQuestionnaireXmlTemplateFiles[_selectedLoanTemplateType];

            WriteRichTextMessageToForm($"The Loan Template Type selected is:  '{_selectedLoanTemplateType}'...", Color.Green);
            WriteRichTextMessageToForm($"The Corresponding Loan Questionnaire Template XML File is:  '{_selectedLoanQuestionnaireTemplateXmlFilename}'...", Color.Green);
            WriteRichTextMessageToForm($"The Number of Loans to Generate is:  '{_numberOfLoansToGenerate}'...", Color.Green);

            Cursor.Current = Cursors.WaitCursor;

            // Get the confirmation IDs to use for the all of the loans we will generate
            List<string> myLoanConfirmationIds = GetListOfConfirmationIdsFromMyLoanDb();

            // Read in selected MyLoan Questionnaire XML Template, replace existing Confirmation IDs with the ones we received, then save those files into a working directory
            // that is defined in the app.config file.
            GenerateXmlPayloadsForProcessingIntoEmpower(myLoanConfirmationIds);

            int batchId = GetBatchIdForThisRun();

            // After some delay, associate all Confirmation IDs with Loan IDs and write those results to automation database
            List<LoanIdConfirmationIdDto> listLoanIdConfirmationIdDtos = PollDatabaseTableToGetLoanIdsCreatedForEachMyLoanQuestionaire(myLoanConfirmationIds);

            // Write the association between the generated Loan IDs in empower and the provided MyLoan Confirmation IDs
            WriteLoanIdConfirmationIdBatchAssociationToDb(listLoanIdConfirmationIdDtos, batchId);

            WriteRichTextMessageToForm($"Loan Processing is complete.  All is good in the jungle.  The Lion sleeps tonight!", Color.Purple);

            Cursor.Current = Cursors.Default;
        }

        private bool CheckInputsPriorToProcessing()
        {
            bool errors = false;

            WriteRichTextMessageToForm($"Validating Form inputs prior to processing...", Color.Black);

            _selectedLoanTemplateType = comboBoxLoanType.Text;

            if (_selectedLoanTemplateType == comboBoxPlaceholder)
            {
                WriteRichTextMessageToForm("MyLoan Questionnaire template was not selected...", Color.Red);
                errors = true;
                return errors;
            }
            else
                WriteRichTextMessageToForm("MyLoan Questionnaire Template Selection is valid...", Color.Green);

            if (textNumLoansToGenerate.Text == null || textNumLoansToGenerate.Text == "")
            {
                WriteRichTextMessageToForm("Number of Loans to Generate was not entered...", Color.Red);
                errors = true;
                return errors;
            }

            try
            {
                _numberOfLoansToGenerate = Convert.ToInt16(textNumLoansToGenerate.Text);
            }
            catch (Exception)
            {
                WriteRichTextMessageToForm($"Number of Loans to Generate MUST be an integer. (The value entered was '{textNumLoansToGenerate.Text}'...", Color.Red);
                errors = true;
                return errors;
            }

            int maxNumberOfLoansToGenerate = Settings.Instance.SettingsDto.AppSettingsDto.MaxNumberOfLoansToGenerate;
            if (_numberOfLoansToGenerate < 1 || _numberOfLoansToGenerate > maxNumberOfLoansToGenerate)
            {
                WriteRichTextMessageToForm($"Number of Loans to Generate was out of range. The values allowed are 1 through '{maxNumberOfLoansToGenerate}'...", Color.Red);
                errors = true;
                return errors;
            }

            WriteRichTextMessageToForm("Number of Loans to Generate is valid...", Color.Green);

            return errors;
        }

        private List<string> GetListOfConfirmationIdsFromMyLoanDb()
        {
            int numberOfLoansToGenerate = Convert.ToInt32(textNumLoansToGenerate.Text);
            List<string> listConfirmationIds = new List<string>();

            // Need to call the stored Procedure pm_sp_AddApplicationConfirmation(@CustomerID, @ApplicationID, @AuditID, @ConfirmationDate) in the MyLoad Dev Db (myloan-db, PM_MYLOAN)

            WriteRichTextMessageToForm($"Getting a list of Confirmation IDs to use from the MyLoan Database...", Color.Black);

            // Get the Connection String
            Dictionary<string, string> connectionStringDictionary = Settings.Instance.SettingsDto.ConnectionStringDictionary;
            string connectionString = connectionStringDictionary["MyLoanDb"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "[MYLOAN].[pm_sp_AddApplicationConfirmation]";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@CustomerID", new SqlGuid()));
                    command.Parameters.Add(new SqlParameter("@ApplicationID", new SqlGuid()));
                    command.Parameters.Add(new SqlParameter("@AuditID", new SqlGuid()));
                    command.Parameters.Add(new SqlParameter("@ConfirmationDate", new DateTime()));
                    connection.Open();

                    for (int i = 0; i < numberOfLoansToGenerate; i++)
                    {
                        try
                        {
                            command.Parameters["@CustomerID"].Value = new SqlGuid(Guid.NewGuid());
                            command.Parameters["@ApplicationID"].Value = new SqlGuid(Guid.NewGuid());
                            command.Parameters["@AuditID"].Value = new SqlGuid(Guid.NewGuid());
                            command.Parameters["@ConfirmationDate"].Value = DateTime.Now.Date;
                            object obj = command.ExecuteScalar();
                            int id = Convert.ToInt32(obj);
                            string confirmationId = id.ToString("PMA000-000");
                            WriteRichTextMessageToForm($"Confirmation ID '{confirmationId}' was retrieved from the database.", Color.Green);
                            listConfirmationIds.Add(confirmationId);
                        }
                        catch (Exception ex)
                        {
                            WriteRichTextMessageToForm($"Exception occurred getting Confirmation Sequence ID.  The error was " + ex.Message, Color.Red);
                        }
                    }
                }

                return listConfirmationIds;
            }
        }

        private void GenerateXmlPayloadsForProcessingIntoEmpower(List<string> listConfirmationIds)
        {
            XmlDocument xDoc = new XmlDocument();
            XmlNode node;
            xDoc.Load(_selectedLoanQuestionnaireTemplateXmlFilename);

            WriteRichTextMessageToForm($"Processing Questionnaires to load into Empower...", Color.Black);

            foreach (string confirmationId in listConfirmationIds)
            {
                try
                {
                    WriteRichTextMessageToForm($"Processing Questionnaire with Confirmation ID '{confirmationId}'...", Color.Green);

                    // Open the Loan Type Template XML File.  This will serve as the Payload of the Business event that I'll create

                    // Replace various values in the XML
                    node = xDoc.SelectSingleNode("/Loan");
                    XmlAttribute attr = node.Attributes["Timestamp"];
                    attr.Value = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    node = xDoc.SelectSingleNode("//LoanApplication");
                    attr = node.Attributes["ConfirmationID"];
                    attr.Value = confirmationId;
                    attr = node.Attributes["AdditionalComments"];
                    attr.Value = "Generated by Test Automation:  MyLoan to Empower Loan Generator";
                    attr = node.Attributes["ApplicationSubmitDate"];
                    attr.Value = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                    node = xDoc.SelectSingleNode("//MortgageTerms");
                    attr = node.Attributes["ClosingDate"];
                    attr.Value = DateTime.Now.AddMonths(5).ToString("MM/dd/yyyy");

                    string xmlPayload = xDoc.OuterXml;

                    // Create the Business Event
                    BusinessEvent evt = CreateBusinessEventForNewQuestionnaire(confirmationId, xmlPayload);
                    WriteRichTextMessageToForm($"Created new Business Event for Event Name: '{evt.EventName}'...", Color.Green);

                    // Invoke the Event Acquisition Service Gateway passing in the business event
                    BusinessEventReceipt receipt = InvokeEventAcquisitionServiceGatewayWithBusinessEvent(evt);
                    WriteRichTextMessageToForm($"Invoked Event Acquisition Service Gateway and received receipt with Event ID: '{receipt.EventId}'.", Color.Green);
                }
                catch (Exception ex)
                {
                    WriteRichTextMessageToForm($"An error occurred in processing Questionnaire with Confirmation ID '{confirmationId}'.  The error was '{ex.Message}'.", Color.Red);
                }
            }
        }

        private BusinessEvent CreateBusinessEventForNewQuestionnaire(string confirmationId, string eventXmlPayload)
        {
            WriteRichTextMessageToForm($"Creating a new Business Event for Questionnaire with Confirmation ID '{confirmationId}'...", Color.Black);

            BusinessEvent evt = new BusinessEvent();

            try
            {
                evt.EventName = "WebLoanQuestionnaireSubmitted";
                evt.BusinessObjectType = "WebLoan";
                evt.BusinessObjectId = confirmationId;
                evt.InitiatorType = InitiatorType.USER;
                evt.Initiator = Guid.NewGuid().ToString();
                evt.TraceabilityType = TraceabilityType.WEB_APPLICATION;
                evt.TraceabilityId = Guid.NewGuid().ToString();
                evt.Source = "MortgageApplicationSubmissionManagement";

                // Add Payload to structured Context
                evt.StructuredContext.Payload = eventXmlPayload;

                WriteRichTextMessageToForm($"A new Business Event for Questionnaire with Confirmation ID '{confirmationId}' was successfully created...", Color.Green);
            }
            catch (Exception ex)
            {
                WriteRichTextMessageToForm($"An Exception was thrown while trying to create a Business Event for Questionnaire with Confirmation ID '{confirmationId}'.  The error was '{ex.Message}'.", Color.Red);
            }

            return evt;
        }

        private BusinessEventReceipt InvokeEventAcquisitionServiceGatewayWithBusinessEvent(BusinessEvent evt)
        {
            WriteRichTextMessageToForm($"Trying to Invoke the Event Acquisition Service Gateway with Business Event...", Color.Black);

            BusinessEventReceipt receipt = null;

            try
            {
                using (EventAcquisitionGateway svc = new EventAcquisitionGateway(new PFNullLogger()))
                {
                    receipt = svc.RecordEvent(evt);
                }

                WriteRichTextMessageToForm($"Successfully Invoked the Event Acquisition Service Gateway with Business Event.  The Event Name was '{receipt.EventName}' and the Event ID was '{receipt.EventId}'.", Color.Green);
            }
            catch (Exception ex)
            {
                WriteRichTextMessageToForm($"An Exception was thrown in trying to Invoke the Event Acquisition Service Gateway with Business Event. The error was '{ex.Message}'", Color.Red);
            }

            return receipt;
        }

        private List<LoanIdConfirmationIdDto> PollDatabaseTableToGetLoanIdsCreatedForEachMyLoanQuestionaire(List<string> listConfirmationIds)
        {
            List<LoanIdConfirmationIdDto> results = null;

            WriteRichTextMessageToForm($"Trying to retrieve the Empower Loan IDs created from the MyLoan Confirmation IDs...", Color.Black);

            // Create the sql statement
            string confIds = "(";
            foreach (string confId in listConfirmationIds)
            {
                confIds = confIds + "'" + confId + "',";
            }
            confIds = confIds.Substring(0, confIds.Length - 1) + ")";

            string sql = $"SELECT LNKEY, U_WEB_CONFIRMATION_ID FROM Empower.U_LS_WEB_APP WHERE U_WEB_QUESTIONNAIRE_SUBMITTED >= DATEADD(day,-1,GETDATE()) AND U_WEB_CONFIRMATION_ID IN {confIds} ORDER BY U_WEB_CONFIRMATION_ID ASC";

            string message = string.Empty;
            int count = 0;
            try
            {
                while (count != listConfirmationIds.Count)
                {
                    count = 0;
                    results = new List<LoanIdConfirmationIdDto>();
                    message = string.Empty;

                    Dictionary<string, string> connectionStringDictionary = Settings.Instance.SettingsDto.ConnectionStringDictionary;
                    string empowerDevDbConnectionString = connectionStringDictionary["EmpowerDb"];
                    using (SqlConnection connection = new SqlConnection(empowerDevDbConnectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();

                            while (reader.Read())
                            {
                                LoanIdConfirmationIdDto dto = new LoanIdConfirmationIdDto();
                                dto.LoanId = reader["LNKEY"].ToString();
                                dto.ConfirmationId = reader["U_WEB_CONFIRMATION_ID"].ToString();
                                results.Add(dto);
                                message = message + $"Found Loan ID '{dto.LoanId}' associated with Confirmation ID '{dto.ConfirmationId}'." + "\r\n";

                                count++;
                            }
                            if (message.Length > 0)
                            {
                                int last = message.LastIndexOf("\r\n");
                                message = message.Substring(0, last);
                            }
                        }
                    }
                    System.Threading.Thread.Sleep(1000);
                }
                WriteRichTextMessageToForm(message, Color.Green);
            }
            catch (Exception ex)
            {
                WriteRichTextMessageToForm($"An exception was thrown while trying to retrieve the Empower Loan IDs associated with the MyLoan Confirmation IDs in the Empower Database.  The error was " + ex.Message, Color.Red);
            }

            WriteRichTextMessageToForm($"Retrieval of the Empower Loan IDs associated with the MyLoan Confirmation IDs in the Empower Database was successful.", Color.Green);

            return results;
        }

        private int GetBatchIdForThisRun()
        {
            WriteRichTextMessageToForm($"Getting the Batch ID for this run from the Test Automation Database...", Color.Black);

            int batchId = -1;
            Dictionary<string, string> connectionStringDictionary = Settings.Instance.SettingsDto.ConnectionStringDictionary;
            string testAutomationConnectionString = connectionStringDictionary["TestAutomationDb"];

            using (SqlConnection connection = new SqlConnection(testAutomationConnectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    try
                    {
                        command.CommandText = "sp_AddLoanGeneratorBatch_insert";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@LoanType", comboBoxLoanType.Text));
                        command.Parameters.Add(new SqlParameter("@CreatedBy", Environment.UserDomainName + "\\" + Environment.UserName));

                        connection.Open();

                        batchId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        WriteRichTextMessageToForm($"Exception occurred getting the Batch ID for this run.  The error was " + ex.Message, Color.Red);
                    }
                }
            }

            WriteRichTextMessageToForm($"Successfully received the Batch ID '{batchId}' for this run.", Color.Green);

            return batchId;
        }

        private bool WriteLoanIdConfirmationIdBatchAssociationToDb(List<LoanIdConfirmationIdDto> dtos, int batchId)
        {
            bool success = true;

            WriteRichTextMessageToForm($"Trying to write the Empower Loan ID - MyLoan Confirmation ID Batch Association to the Test Automation Database...", Color.Black);

            Dictionary<string, string> connectionStringDictionary = Settings.Instance.SettingsDto.ConnectionStringDictionary;
            string testAutomationConnectionString = connectionStringDictionary["TestAutomationDb"];

            try
            {
                using (SqlConnection connection = new SqlConnection(testAutomationConnectionString))
                {
                    connection.Open();

                    for (int i = 0; i < dtos.Count; i++)
                    {
                        string sql = $"INSERT INTO association_my_loan_to_empower (loan_id, confirmation_id, batch_id, entered) VALUES ('{dtos[i].LoanId}', '{dtos[i].ConfirmationId}', '{batchId}', '{DateTime.Now}')";
                        SqlCommand command = new SqlCommand(sql, connection);

                        command.ExecuteNonQuery();

                        WriteRichTextMessageToForm($"LoanId and ConfirmationId association successfully written to the database for Loan ID '{dtos[i].LoanId}', Confirmation Id '{dtos[i].ConfirmationId}' and batch ID: '{batchId}'.", Color.Green);
                    }
                }
            }
            catch(Exception ex)
            {
                WriteRichTextMessageToForm($"Error occurred writing LoanId and ConfirmationId association to the database for batch ID '{batchId}'.  The error was " + ex.Message, Color.Red);
                success = false;
            }

            WriteRichTextMessageToForm($"Successfully wrote the Empower Loan ID - MyLoan Confirmation ID Batch Association to the Test Automation Database for Batch ID = '{batchId}'.", Color.Green);

            return success;
        }

        private void WriteRichTextMessageToForm(string msg, Color color)
        {
            string message = msg + "\r\n";
            textBoxProcessing.SelectionStart = textBoxProcessing.TextLength;
            textBoxProcessing.SelectionLength = message.Length;
            textBoxProcessing.SelectionColor = color;
            textBoxProcessing.AppendText(message);
        }

        private void MyLoanEmpowerLoanGeneratorForm_Load(object sender, EventArgs e)
        {
            WriteRichTextMessageToForm("Loading the MyLoan To Empower Loan Generator Form...", Color.Black);

            try
            {
                Dictionary<string, string> myLoanQuestionnaireXmlTemplateFiles = Settings.Instance.SettingsDto.MyLoanQuestionnaireXmlTemplateFileDictionary;
                string[] arrayKeys = myLoanQuestionnaireXmlTemplateFiles.Keys.ToArray();
                List<string> keys = new List<string>(arrayKeys);
                List<string> sortedKeys = keys.OrderBy(x => x).ToList();

                comboBoxLoanType.Items.Add(comboBoxPlaceholder);
                foreach (string key in sortedKeys)
                {
                    comboBoxLoanType.Items.Add(key);
                }

                comboBoxLoanType.SelectedIndex = 0;

                int maxLoans = Settings.Instance.SettingsDto.AppSettingsDto.MaxNumberOfLoansToGenerate;
                labelLoansToGenerate.Text = $"How many loans would you like to generate? (Max is {maxLoans}).";

                textNumLoansToGenerate.Text = "1";

                comboBoxLoanType.Focus();
            }
            catch (Exception ex)
            {
                WriteRichTextMessageToForm($"An exception was thrown while trying to load the MyLoan To Empower Loan Generator Form.  The error was '{ex.Message}'.", Color.Red);
            }

            WriteRichTextMessageToForm("The MyLoan To Empower Loan Generator Form loaded successfully.", Color.Green);
        }

        private void comboBoxLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLoanType.Text != comboBoxPlaceholder)
                comboBoxLoanType.Items.Remove(comboBoxPlaceholder);
        }

        private void buttonSaveOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg;
            saveFileDlg = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFileDlg.DefaultExt = "*.rtf";
            saveFileDlg.Filter = "RTF Files|*.rtf";

            try
            {
                DialogResult dr = saveFileDlg.ShowDialog();
                if (dr == DialogResult.OK && saveFileDlg.FileName.Length > 0)
                {
                    // Save the contents of the RichTextBox into the file.
                    textBoxProcessing.SaveFile(saveFileDlg.FileName, RichTextBoxStreamType.PlainText);
                }
                textBoxProcessing.Text = "";
                WriteRichTextMessageToForm($"Output successfully saved to '{saveFileDlg.FileName}'.", Color.Green);
            }
            catch (Exception ex)
            {
                textBoxProcessing.Text = "";
                WriteRichTextMessageToForm($"An error occurred saving output to file.  The error was '{ex.Message}'.", Color.Red);
            }
        }
    }
}
