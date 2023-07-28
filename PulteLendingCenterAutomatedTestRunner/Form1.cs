using PulteLendingCenterAutomatedTestRunner.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Threading.Tasks;
using log4net;
using Microsoft.Extensions.Configuration;
using System.Web;
using PulteLendingCenterAutomatedTestRunner.ViewModels;
using PulteLendingCenterAutomatedTestRunner.Dtos.SettingsDtos;
using Tulpep.NotificationWindow;

namespace PulteLendingCenterAutomatedTestRunner
{
    public partial class Form1 : Form
    {
        private int _numTotalTestsSelected = 0;
        string _plcTestRunnerOutputDirectory = string.Empty;
        string _runForRecordreportPrefix = "RUN_FOR_RECORD_";
        string _emailMessage = string.Empty;
        List<EmailDto> _emailRecipients = null;
        private string _logVerbosity = string.Empty;


        private DataGridViewCellStyle _dgvCellStyleGreen = new DataGridViewCellStyle { ForeColor = Color.Green, };
        private DataGridViewCellStyle _dgvCellStyleRed = new DataGridViewCellStyle { ForeColor = Color.Red };
        private DataGridViewCellStyle _dgvCellStyleOrange = new DataGridViewCellStyle { ForeColor = Color.Orange };

        public Form1()
        {
            InitializeComponent();

            try
            {
                _plcTestRunnerOutputDirectory = Directory.GetCurrentDirectory();
                labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
                buttonEmailSelectedReports.Enabled = false;
                radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Checked = true;
                InitializeDataGrid();
                Link link = new Link();
                link.LinkData = Settings.Instance.SettingsDto.AppSettingsDto.PlcIntegrationTestsExecutablesRootPath + "\\" + Settings.Instance.SettingsDto.AppSettingsDto.RanorexReportsDirectoryName;
                linkLabelRanorexReportDirectory.Links.Add(link);

                pictureBoxRunner.Image = Properties.Resources.sport;

                Dictionary<string, int> lastConfigurationRunDict = GetLastConfigurationRun();

                // Initialize the radio buttons
                radioButtonScreenTests.Checked = true;

                InitializeFormCheckboxes(lastConfigurationRunDict);
            }
            catch (Exception ex)
            {
                DBLogger.Instance.WriteLogMessage("TestRunner error", "TestRunner error", null, ex.Message, LogMessageTypes.ERROR.ToString());
                throw ex;
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var configuration = Program.Configuration;
        }

        public void InitializeDataGrid()
        {
            int configExeIndex = dataGridViewTestConfigurationsExecuted.Columns.Add("configExecuted", "Configuration Executed");
            dataGridViewTestConfigurationsExecuted.Columns[configExeIndex].FillWeight = 38;
            int reportIndex = dataGridViewTestConfigurationsExecuted.Columns.Add("reportName", "Report Name");
            dataGridViewTestConfigurationsExecuted.Columns[reportIndex].FillWeight = 50;
            DataGridViewCheckBoxColumn emailColumn = new DataGridViewCheckBoxColumn();
            emailColumn.Name = "emailColumn";
            emailColumn.HeaderText = "Email Report";
            emailColumn.ReadOnly = false;
            int checkBoxIndex = dataGridViewTestConfigurationsExecuted.Columns.Add(emailColumn);
            dataGridViewTestConfigurationsExecuted.Columns[checkBoxIndex].FillWeight = 12;

            // THIS SECTION WAS USED FOR TESTING THE EMAIL FUNCTIONALITY WITHOUT HAVING TO RUN A TEST TO GET AN ENTRY IN THE GRID TO CHECK THE EMAIL REPORT BUTTON.  I'M KEEPING IT AROUND JUST IN CASE.
            /*
            string[] row = new string[] { "RunDeclarationsValidationOneUrla - SUCCESS", "PLC_TA_RunDeclarationsValidationOneUrla_20210807_163209" };
            dataGridViewTestConfigurationsExecuted.Rows.Add(row);
            dataGridViewTestConfigurationsExecuted.Rows[0].Cells[0].Style = _dgvCellStyleGreen;
            dataGridViewTestConfigurationsExecuted.Refresh();

            row = new string[] { "RunEmploymentAndIncomeValidationOneUrla- Failure", "PLC_TA_RunEmploymentAndIncomeValidationOneUrla_20210807_163209" };
            dataGridViewTestConfigurationsExecuted.Rows.Add(row);
            dataGridViewTestConfigurationsExecuted.Rows[1].Cells[0].Style = _dgvCellStyleRed;
            dataGridViewTestConfigurationsExecuted.Refresh();

            row = new string[] { "RunLiabilitiesValidationOneUrlaTest - STATUS UNKNOWN", "PLC_TA_RunLiabilitiesValidationOneUrlaTest_20210807_163209" };
            dataGridViewTestConfigurationsExecuted.Rows.Add(row);
            dataGridViewTestConfigurationsExecuted.Rows[2].Cells[0].Style = _dgvCellStyleOrange;
            dataGridViewTestConfigurationsExecuted.Refresh();
            buttonEmailSelectedReports.Enabled = true;
            */
        }

        public void InitializeFormCheckboxes(Dictionary<string, int> lastTestsRunDict)
        {
            if (lastTestsRunDict["ScreenTests"] == 1)
                radioButtonScreenTests.Checked = true;
            else
                radioButtonScenarioTests.Checked = true;

            if (lastTestsRunDict["AssetsCrudOneUrlaTest"] == 1)
            {
                checkBoxAssetsCrud1.Checked = true;
            }

            if (lastTestsRunDict["AssetsCrudTwoUrlaTest"] == 1)
            {
                checkBoxAssetsCrud2.Checked = true;
            }

            if (lastTestsRunDict["AssetsValidationOneUrlaTest"] == 1)
            {
                checkBoxAssetsValidation1.Checked = true;
            }

            if (lastTestsRunDict["AssetsValidationTwoUrlaTest"] == 1)
            {
                checkBoxAssetsValidation2.Checked = true;
            }

            if (lastTestsRunDict["BorrowerInfoCrudOneUrlaTest"] == 1)
            {
                checkBoxBorrowerInfoCrud1.Checked = true;
            }

            if (lastTestsRunDict["BorrowerInfoCrudTwoUrlaTest"] == 1)
            {
                checkBoxBorrowerInfoCrud2.Checked = true;
            }

            if (lastTestsRunDict["BorrowerInfoValidationOneUrlaTest"] == 1)
            {
                checkBoxBorrowerInfoValidation1.Checked = true;
            }

            if (lastTestsRunDict["BorrowerInfoValidationTwoUrlaTest"] == 1)
            {
                checkBoxBorrowerInfoValidation2.Checked = true;
            }

            if (lastTestsRunDict["CreditScoreCrudOneUrlaTest"] == 1)
            {
                checkBoxCreditScoreCrud1.Checked = true;
            }

            if (lastTestsRunDict["CreditScoreCrudTwoUrlaTest"] == 1)
            {
                checkBoxCreditScoreCrud2.Checked = true;
            }

            if (lastTestsRunDict["CreditScoreValidationOneUrlaTest"] == 1)
            {
                checkBoxCreditScoreValidation1.Checked = true;
            }

            if (lastTestsRunDict["CreditScoreValidationTwoUrlaTest"] == 1)
            {
                checkBoxCreditScoreValidation2.Checked = true;
            }

            if (lastTestsRunDict["DeclarationsValidationOneUrlaTest"] == 1)
            {
                checkBoxDeclarationsValidation1.Checked = true;
            }

            if (lastTestsRunDict["DeclarationsValidationTwoUrlaTest"] == 1)
            {
                checkBoxDeclarationsValidation2.Checked = true;
            }

            if (lastTestsRunDict["EmpAndIncCrudOneUrlaTest"] == 1)
            {
                checkBoxEmpAndIncCrud1.Checked = true;
            }

            if (lastTestsRunDict["EmpAndIncCrudTwoUrlaTest"] == 1)
            {
                checkBoxEmpAndIncCrud2.Checked = true;
            }

            if (lastTestsRunDict["EmploymentAndIncomeValidationOneUrlaTest"] == 1)
            {
                checkBoxEmploymentAndIncomeValidation1.Checked = true;
            }

            if (lastTestsRunDict["EmploymentAndIncomeValidationTwoUrlaTest"] == 1)
            {
                checkBoxEmploymentAndIncomeValidation2.Checked = true;
            }

            if (lastTestsRunDict["LenderLoanInfoCrudOneUrlaTest"] == 1)
            {
                if (checkBoxLenderLoanInfoCrud1.Enabled)
                    checkBoxLenderLoanInfoCrud1.Checked = true;
                else
                    checkBoxLenderLoanInfoCrud1.Checked = false;
            }

            if (lastTestsRunDict["LenderLoanInfoValidationOneUrlaTest"] == 1)
            {
                if (checkBoxLenderLoanInfoValidation1.Enabled)
                    checkBoxLenderLoanInfoValidation1.Checked = true;
                else
                    checkBoxLenderLoanInfoValidation1.Checked = false;
            }

            if (lastTestsRunDict["LiabilitiesCrudOneUrlaTest"] == 1)
            {
                checkBoxLiabilitiesCrud1.Checked = true;
            }

            if (lastTestsRunDict["LiabilitiesCrudTwoUrlaTest"] == 1)
            {
                checkBoxLiabilitiesCrud2.Checked = true;
            }

            if (lastTestsRunDict["LiabilitiesValidationOneUrlaTest"] == 1)
            {
                checkBoxLiabilitiesValidation1.Checked = true;
            }

            if (lastTestsRunDict["LiabilitiesValidationTwoUrlaTest"] == 1)
            {
                checkBoxLiabilitiesValidation2.Checked = true;
            }

            if (lastTestsRunDict["LoanPanelsValidationOneUrlaTest"] == 1)
            {
                checkBoxLoanPanelsValidation1.Checked = true;
            }

            if (lastTestsRunDict["LoanPanelsValidationTwoUrlaTest"] == 1)
            {
                checkBoxLoanPanelsValidation2.Checked = true;
            }

            if (lastTestsRunDict["NavigationTest"] == 1)
            {
                checkBoxNavTest.Checked = true;
            }

            if (lastTestsRunDict["QualifyingTheBorrowerValidationOneUrlaTest"] == 1)
            {
                checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            }

            if (lastTestsRunDict["QualifyingTheBorrowerValidationTwoUrlaTest"] == 1)
            {
                checkBoxQualifyingTheBorrowerValidation2.Checked = true;
            }

            if (lastTestsRunDict["ReoCrudOneUrlaTest"] == 1)
            {
                checkBoxReoCrud1.Checked = true;
            }

            if (lastTestsRunDict["ReoCrudTwoUrlaTest"] == 1)
            {
                checkBoxReoCrud2.Checked = true;
            }

            if (lastTestsRunDict["ReoValidationOneUrlaTest"] == 1)
            {
                checkBoxReoValidation1.Checked = true;
            }

            if (lastTestsRunDict["ReoValidationTwoUrlaTest"] == 1)
            {
                checkBoxReoValidation2.Checked = true;
            }

            if (lastTestsRunDict["SavingsPlanCrudOneUrlaTest"] == 1)
            {
                if (checkBoxSavingsPlanCrud1.Enabled)
                    checkBoxSavingsPlanCrud1.Checked = true;
                else
                    checkBoxSavingsPlanCrud1.Checked = false;
            }

            if (lastTestsRunDict["SavingsPlanValidationOneUrlaTest"] == 1)
            {
                if (checkBoxSavingsPlanValidation1.Enabled)
                    checkBoxSavingsPlanValidation1.Checked = true;
                else
                    checkBoxSavingsPlanValidation1.Checked = false;
            }

            if (lastTestsRunDict["SubjectPropertyCrudOneUrlaTest"] == 1)
            {
                checkBoxSubjectPropCrud1.Checked = true;
            }

            if (lastTestsRunDict["SubjectPropertyCrudTwoUrlaTest"] == 1)
            {
                checkBoxSubjectPropCrud2.Checked = true;
            }

            if (lastTestsRunDict["SubjectPropertyValidationOneUrlaTest"] == 1)
            {
                checkBoxSubjectPropertyValidation1.Checked = true;
            }

            if (lastTestsRunDict["SubjectPropertyValidationTwoUrlaTest"] == 1)
            {
                checkBoxSubjectPropertyValidation2.Checked = true;
            }
        }

        public Dictionary<string, int> GetLastConfigurationRun()
        {
            string lastConfigurationRunFile = Directory.GetCurrentDirectory() + @"\LastConfigurationRun_" + Environment.GetEnvironmentVariable("USERNAME") + ".txt";
            bool lastConfigurationRunFileExists = File.Exists(lastConfigurationRunFile);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            if (lastConfigurationRunFileExists)
            {
                using StreamReader reader = new StreamReader(lastConfigurationRunFile);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] configInfo = line.Split(":");
                    string configName = configInfo[0];
                    int wasRun = Convert.ToInt16(configInfo[1]);
                    dict.Add(configName, wasRun);
                }
            }
            else
            {
                dict.Add("ScreenTests", 1);
                dict.Add("AssetsCrudOneUrlaTest", 0);
                dict.Add("AssetsCrudTwoUrlaTest", 0);
                dict.Add("AssetsValidationOneUrlaTest", 0);
                dict.Add("AssetsValidationTwoUrlaTest", 0);
                dict.Add("BorrowerInfoCrudOneUrlaTest", 0);
                dict.Add("BorrowerInfoCrudTwoUrlaTest", 0);
                dict.Add("BorrowerInfoValidationOneUrlaTest", 0);
                dict.Add("BorrowerInfoValidationTwoUrlaTest", 0);
                dict.Add("CreditScoreCrudOneUrlaTest", 0);
                dict.Add("CreditScoreCrudTwoUrlaTest", 0);
                dict.Add("CreditScoreValidationOneUrlaTest", 0);
                dict.Add("CreditScoreValidationTwoUrlaTest", 0);
                dict.Add("DeclarationsValidationOneUrlaTest", 0);
                dict.Add("DeclarationsValidationTwoUrlaTest", 0);
                dict.Add("EmpAndIncCrudOneUrlaTest", 0);
                dict.Add("EmpAndIncCrudTwoUrlaTest", 0);
                dict.Add("EmploymentAndIncomeValidationOneUrlaTest", 0);
                dict.Add("EmploymentAndIncomeValidationTwoUrlaTest", 0);
                dict.Add("LenderLoanInfoCrudOneUrlaTest", 0);
                dict.Add("LenderLoanInfoCrudTwoUrlaTest", 0);
                dict.Add("LenderLoanInfoValidationOneUrlaTest", 0);
                dict.Add("LenderLoanInfoValidationTwoUrlaTest", 0);
                dict.Add("LiabilitiesCrudOneUrlaTest", 0);
                dict.Add("LiabilitiesCrudTwoUrlaTest", 0);
                dict.Add("LiabilitiesValidationOneUrlaTest", 0);
                dict.Add("LiabilitiesValidationTwoUrlaTest", 0);
                dict.Add("LoanPanelsValidationOneUrlaTest", 0);
                dict.Add("LoanPanelsValidationTwoUrlaTest", 0);
                dict.Add("NavigationTest", 0);
                dict.Add("QualifyingTheBorrowerValidationOneUrlaTest", 0);
                dict.Add("QualifyingTheBorrowerValidationTwoUrlaTest", 0);
                dict.Add("ReoCrudOneUrlaTest", 0);
                dict.Add("ReoCrudTwoUrlaTest", 0);
                dict.Add("ReoValidationOneUrlaTest", 0);
                dict.Add("ReoValidationTwoUrlaTest", 0);
                dict.Add("SavingsPlanCrudOneUrlaTest", 0);
                dict.Add("SavingsPlanValidationOneUrlaTest", 0);
                dict.Add("SubjectPropertyCrudOneUrlaTest", 0);
                dict.Add("SubjectPropertyCrudTwoUrlaTest", 0);
                dict.Add("SubjectPropertyValidationOneUrlaTest", 0);
                dict.Add("SubjectPropertyValidationTwoUrlaTest", 0);
            }

            return dict;
        }

        public void WriteConfigurationRunStatus(Dictionary<string, int> testConfigurationStatusDictionary)
        {
            using StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + @"\LastConfigurationRun_" + Environment.GetEnvironmentVariable("USERNAME") + ".txt");
            foreach (KeyValuePair<string, int> configuration in testConfigurationStatusDictionary)
            {
                string fileLine = configuration.Key + ":" + configuration.Value;
                writer.WriteLine(fileLine);
            }
        }

        public void RunLogonExpertToKeepSessionAlive()
        {
            string args = "-logon tchristensen Pulte1234 PMDEV -setparams KeepComputerUnlocked=1 BypassLegalNotice=1 ShowLogo=1";
            if (Settings.Instance.SettingsDto.AppSettingsDto.Environment == "SIT")
                args = args.Replace("PMDEV", "PMINT");

            var processInfo = new ProcessStartInfo("le.exe", args);

            processInfo.RedirectStandardError = true;

            Process process = Process.Start(processInfo);

            process.WaitForExit();

            int exitCode = process.ExitCode;

            string msg;
            switch (exitCode)
            {
                case 0:
                    msg = "The command has been executed successfully.";
                    break;
                case 1:
                    msg = "The required files have not been found.Please reinstall LogonExpert.";
                    break;
                case 2:
                    msg = "The logon credentials cannot be validated.";
                    break;
                case 3:
                    msg = "The user cannot be logged on/ logged off within the allotted time.";
                    break;
                case 6:
                    msg = "The LogonExpert service is not installed or running.LogonExpert might not have been installed properly.";
                    break;
                case 7:
                    msg = "This action cannot be performed due to the license being invalid.Please launch LogonExpert Administrator for additional information.";
                    break;
                case 8:
                    msg = "You do not have appropriate rights to run LogonExpert. Please launch LogonExpert Administrator and configure the rights on the Options tab.";
                    break;
                case 9:
                    msg = "The logon has been interrupted with the Shift key.";
                    break;
                case 13:
                    msg = "The logon has been interrupted.";
                    break;
                case 14:
                    msg = "No - setparams parameters have been specified.";
                    break;
                case 15:
                    msg = "Unknown - setparams parameters.";
                    break;
                case 16:
                    msg = "The UnlockByThisUser and LockPCAfterLogon parameters cannot share the same value.";
                    break;
                case 17:
                    msg = "The user is not allowed to perform the requested type of logon on this computer.";
                    break;
                case 18:
                    msg = "No such user has been found.";
                    break;
                case 19:
                    msg = "No users have been configured so far.";
                    break;
                case 20:
                    msg = "No eDirectory tree is configured for this user.";
                    break;
            }
        }

        private void buttonRunSelectedTests_Click(object sender, EventArgs e)
        {
            try
            {
                //RunLogonExpertToKeepSessionAlive();

                dataGridViewTestConfigurationsExecuted.Rows.Clear();
                dataGridViewTestConfigurationsExecuted.Refresh();

                if (_numTotalTestsSelected <= 0)
                {
                    MessageBox.Show("At least one test must be selected.", "Automated Test Runner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Dictionary<string, int> testsThatWereRun = GetConfigurationRunStatus();
                Dictionary<string, string> commandsToRun = DetermineCommandsToRun();

                RunCommands(commandsToRun);

                WriteConfigurationRunStatus(testsThatWereRun);
            }
            catch (Exception ex)
            {
                DBLogger.Instance.WriteLogMessage("TestRunner Error", "TestRunnerError", null, ex.Message, LogMessageTypes.ERROR.ToString());
                throw ex;
            }
        }

        private void RunCommands(Dictionary<string, string> commandsToRun)
        {
            // Must set the current directory to the PLC Intergration Tests project output directory!!!!!
            string reportDir = Settings.Instance.SettingsDto.AppSettingsDto.PlcIntegrationTestsExecutablesRootPath + "\\Reports";
            Directory.SetCurrentDirectory(Settings.Instance.SettingsDto.AppSettingsDto.PlcIntegrationTestsExecutablesRootPath);

            buttonEmailSelectedReports.Enabled = false;

            foreach (KeyValuePair<string, string> commandInfo in commandsToRun)
            {

                TestCleanup();

                string[] strArray = commandInfo.Value.Trim().Split(",");
                List<string> commandList = new List<string>(strArray);
                string processName = commandList[0];
                string testSuiteName = commandList[1];
                testSuiteName = testSuiteName.Replace("/ts:", "");
                testSuiteName = testSuiteName.Replace(".rxtst", "");
                commandList.RemoveAt(0);
                string args = string.Empty;
                string reportName = string.Empty;
                int i = 0;
                foreach (string argument in commandList)
                {
                    if (i < 3)
                        args += argument + " ";
                    else if (i == 3)
                    {
                        string reportArg = string.Empty;
                        reportName = argument.Replace("/rf:Reports\\", "");
                        reportName = AppendTimeStampOnReportName(reportName);
                        if (checkBoxRunForRecord.Checked == true)
                            reportArg = "/rf:Reports\\" + _runForRecordreportPrefix + reportName;
                        else
                            reportArg = "/rf:Reports\\" + reportName;

                        args += reportArg + " ";
                    }
                    else
                        args += argument.Replace("REPLACE_THIS_VALUE", _logVerbosity);

                    i++;
                }
                args = args.TrimEnd();

                var processInfo = new ProcessStartInfo(Settings.Instance.SettingsDto.AppSettingsDto.PlcIntegrationTestsExecutablesRootPath + "\\" + processName, args);

                processInfo.RedirectStandardError = true;

                DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, "Test Begin", LogMessageTypes.INFO.ToString());

                Process process = Process.Start(processInfo);

                process.WaitForExit();

                int exitCode = process.ExitCode;

                switch (exitCode)
                {
                    case 0:
                        DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, $"Process returned ExitCode: '{exitCode}': SUCCESS", LogMessageTypes.INFO.ToString());
                        string[] row = new string[] { commandInfo.Key + " - SUCCESS", reportName };
                        int rowIndex = dataGridViewTestConfigurationsExecuted.Rows.Add(row);
                        dataGridViewTestConfigurationsExecuted.Rows[rowIndex].Cells[0].Style = _dgvCellStyleGreen;
                        dataGridViewTestConfigurationsExecuted.Refresh();
                        break;
                    case -1:
                        DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, $"Process returned ExitCode: '{exitCode}': FAIL - Test run aborted due to error", LogMessageTypes.ERROR.ToString());
                        row = new string[] { commandInfo.Key + " - FAILURE", reportName };
                        rowIndex = dataGridViewTestConfigurationsExecuted.Rows.Add(row);
                        dataGridViewTestConfigurationsExecuted.Rows[rowIndex].Cells[0].Style = _dgvCellStyleRed;
                        dataGridViewTestConfigurationsExecuted.Refresh();
                        break;
                    case -22:
                        DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, $"Process returned ExitCode: '{exitCode}': FAIL - Specified Ranorex Agent could not be found", LogMessageTypes.ERROR.ToString());
                        row = new string[] { commandInfo.Key + " - FAILURE", reportName };
                        rowIndex = dataGridViewTestConfigurationsExecuted.Rows.Add(row);
                        dataGridViewTestConfigurationsExecuted.Rows[rowIndex].Cells[0].Style = _dgvCellStyleRed;
                        dataGridViewTestConfigurationsExecuted.Refresh();
                        break;
                    case 4:
                        DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, $"Process returned ExitCode: '{exitCode}': FAIL - No valid license found", LogMessageTypes.ERROR.ToString());
                        row = new string[] { commandInfo.Key + " - FAILURE", reportName };
                        rowIndex = dataGridViewTestConfigurationsExecuted.Rows.Add(row);
                        dataGridViewTestConfigurationsExecuted.Rows[rowIndex].Cells[0].Style = _dgvCellStyleRed;
                        dataGridViewTestConfigurationsExecuted.Refresh();
                        break;
                    default:
                        DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, $"Process returned ExitCode: '{exitCode}': Unknown", LogMessageTypes.INFO.ToString());
                        row = new string[] { commandInfo.Key + " - STATUS UNKNOWN", reportName };
                        rowIndex = dataGridViewTestConfigurationsExecuted.Rows.Add(row);
                        dataGridViewTestConfigurationsExecuted.Rows[rowIndex].Cells[0].Style = _dgvCellStyleOrange;
                        dataGridViewTestConfigurationsExecuted.Refresh();
                        break;
                }

                process.Close();

                DBLogger.Instance.WriteLogMessage(testSuiteName, commandInfo.Key, reportName, "Test Complete", LogMessageTypes.INFO.ToString());

                if (dataGridViewTestConfigurationsExecuted.Rows.Count > 0)
                    buttonEmailSelectedReports.Enabled = true;

                // Convert the report to PDF file
                //Ranorex.PDF.Creator.CreatePDF(reportDir + "\\" + reportName + ".rxlog", reportDir + "\\" + reportName + ".pdf", null, "all");
            }

            try
            {
                if (checkBoxNotifyUponCompletion.Checked == true)
                {
                    string message = GetMessageContent();
                    List<EmailDto> recipients = new List<EmailDto>();
                    recipients.Add(Settings.Instance.SettingsDto.EmailDtos[0]);
                    if (Settings.Instance.SettingsDto.AppSettingsDto.Environment.ToUpper() == "SIT")
                        recipients.Add(Settings.Instance.SettingsDto.EmailDtos[1]);
                    SendEmail(recipients, message);
                }
            }
            catch(Exception ex)
            {
				//DBLogger.Instance.WriteLogMessage("Notification Email", null, null, "Exception Thrown", LogMessageTypes.ERROR.ToString());
			}

			// Need to change the directory back to the PLC Automation Test Runner Output directory
			Directory.SetCurrentDirectory(_plcTestRunnerOutputDirectory);

            TestCleanup();

        }

        private string GetMessageContent()
        {
            string dialogText = $"Text exection has completed in the '{Settings.Instance.SettingsDto.AppSettingsDto.Environment.ToUpper()}' environmeent.\r\n";
            dialogText += Environment.NewLine;
            dialogText += Environment.NewLine;

            foreach (DataGridViewRow row in dataGridViewTestConfigurationsExecuted.Rows)
            {
                dialogText += row.Cells[0].Value.ToString() + "\t" + row.Cells[1].Value.ToString();
                dialogText += Environment.NewLine;
            }

            return dialogText;
        }

        private string AppendTimeStampOnReportName(string reportNameBase)
        {
            string reportName = reportNameBase;

            string timeStamp = DateTime.Now.ToString("_yyyyMMdd_HHmmss");

            return reportName + timeStamp;
        }

        private void TestCleanup()
        {
            Process[] processes = Process.GetProcessesByName("iexplore");

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        public Dictionary<string, int> GetConfigurationRunStatus()
        {
            int status;
            Dictionary<string, int> configurationThatWasRun = new Dictionary<string, int>();

            status = radioButtonScreenTests.Checked ? 1 : 0;
            configurationThatWasRun.Add("ScreenTests", status);

            status = checkBoxAssetsCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("AssetsCrudOneUrlaTest", status);

            status = checkBoxAssetsCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("AssetsCrudTwoUrlaTest", status);

            status = checkBoxAssetsValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("AssetsValidationOneUrlaTest", status);

            status = checkBoxAssetsValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("AssetsValidationTwoUrlaTest", status);

            status = checkBoxBorrowerInfoCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("BorrowerInfoCrudOneUrlaTest", status);

            status = checkBoxBorrowerInfoCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("BorrowerInfoCrudTwoUrlaTest", status);

            status = checkBoxBorrowerInfoValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("BorrowerInfoValidationOneUrlaTest", status);

            status = checkBoxBorrowerInfoValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("BorrowerInfoValidationTwoUrlaTest", status);

            status = checkBoxCreditScoreCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("CreditScoreCrudOneUrlaTest", status);

            status = checkBoxCreditScoreCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("CreditScoreCrudTwoUrlaTest", status);

            status = checkBoxCreditScoreValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("CreditScoreValidationOneUrlaTest", status);

            status = checkBoxCreditScoreValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("CreditScoreValidationTwoUrlaTest", status);

            status = checkBoxDeclarationsValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("DeclarationsValidationOneUrlaTest", status);

            status = checkBoxDeclarationsValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("DeclarationsValidationTwoUrlaTest", status);

            status = checkBoxEmploymentAndIncomeValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("EmploymentAndIncomeValidationOneUrlaTest", status);

            status = checkBoxEmpAndIncCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("EmpAndIncCrudOneUrlaTest", status);

            status = checkBoxEmpAndIncCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("EmpAndIncCrudTwoUrlaTest", status);

            status = checkBoxEmploymentAndIncomeValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("EmploymentAndIncomeValidationTwoUrlaTest", status);

            status = checkBoxLenderLoanInfoCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("LenderLoanInfoCrudOneUrlaTest", status);

            status = checkBoxLenderLoanInfoValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("LenderLoanInfoValidationOneUrlaTest", status);

            status = checkBoxLiabilitiesCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("LiabilitiesCrudOneUrlaTest", status);

            status = checkBoxLiabilitiesCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("LiabilitiesCrudTwoUrlaTest", status);

            status = checkBoxLiabilitiesValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("LiabilitiesValidationOneUrlaTest", status);

            status = checkBoxLiabilitiesValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("LiabilitiesValidationTwoUrlaTest", status);

            status = checkBoxLoanPanelsValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("LoanPanelsValidationOneUrlaTest", status);

            status = checkBoxLoanPanelsValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("LoanPanelsValidationTwoUrlaTest", status);

            status = checkBoxNavTest.Checked ? 1 : 0;
            configurationThatWasRun.Add("NavigationTest", status);

            status = checkBoxQualifyingTheBorrowerValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("QualifyingTheBorrowerValidationOneUrlaTest", status);

            status = checkBoxQualifyingTheBorrowerValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("QualifyingTheBorrowerValidationTwoUrlaTest", status);

            status = checkBoxReoCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("ReoCrudOneUrlaTest", status);

            status = checkBoxReoCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("ReoCrudTwoUrlaTest", status);

            status = checkBoxReoValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("ReoValidationOneUrlaTest", status);

            status = checkBoxReoValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("ReoValidationTwoUrlaTest", status);

            status = checkBoxSavingsPlanCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("SavingsPlanCrudOneUrlaTest", status);

            status = checkBoxSavingsPlanValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("SavingsPlanValidationOneUrlaTest", status);

            status = checkBoxSubjectPropCrud1.Checked ? 1 : 0;
            configurationThatWasRun.Add("SubjectPropCrudOneUrlaTest", status);

            status = checkBoxBorrowerInfoCrud2.Checked ? 1 : 0;
            configurationThatWasRun.Add("SubjectPropCrudTwoUrlaTest", status);

            status = checkBoxSubjectPropertyValidation1.Checked ? 1 : 0;
            configurationThatWasRun.Add("SubjectPropertyValidationOneUrlaTest", status);

            status = checkBoxSubjectPropertyValidation2.Checked ? 1 : 0;
            configurationThatWasRun.Add("SubjectPropertyValidationTwoUrlaTest", status);

            return configurationThatWasRun;
        }

        public Dictionary<string, string> DetermineCommandsToRun()
        {
            Dictionary<string, string> commandsToRun;

            commandsToRun = DetermineScreenTestsToRun();

            return commandsToRun;
        }

        private Dictionary<string, string> DetermineScreenTestsToRun()
        {
            Dictionary<string, string> commandsToRun = new Dictionary<string, string>();

            if (_numTotalTestsSelected == Settings.Instance.SettingsDto.AppSettingsDto.TotalNumberOfTests)
            {
                commandsToRun.Add("RunAllTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllTests);
                return commandsToRun;
            }

            // Run All Validation Tests
            if (checkBoxAssetsValidation1.Checked
                && checkBoxAssetsValidation2.Checked
                && checkBoxBorrowerInfoValidation1.Checked
                && checkBoxBorrowerInfoValidation2.Checked
                && checkBoxCreditScoreValidation1.Checked
                && checkBoxCreditScoreValidation2.Checked 
                && checkBoxDeclarationsValidation1.Checked
                && checkBoxDeclarationsValidation2.Checked
                && checkBoxEmploymentAndIncomeValidation1.Checked
                && checkBoxEmploymentAndIncomeValidation2.Checked
                //&& checkBoxLenderLoanInfoValidation1.Checked
                //&& checkBoxLenderLoanInfoValidation2.Checked 
                && checkBoxLiabilitiesValidation1.Checked
                && checkBoxLiabilitiesValidation2.Checked
                && checkBoxLoanPanelsValidation1.Checked
                && checkBoxLoanPanelsValidation2.Checked
                && checkBoxNavTest.Checked
                && checkBoxQualifyingTheBorrowerValidation1.Checked
                && checkBoxQualifyingTheBorrowerValidation2.Checked
                && checkBoxReoValidation1.Checked
                && checkBoxReoValidation2.Checked
                //&& checkBoxSavingsPlanValidation1.Checked
                //&& checkBoxSavingsPlanValidation2.Checked
                && checkBoxSubjectPropertyValidation1.Checked
                //&& checkBoxSubjectPropertyValidation2.Checked
                )
            {
                commandsToRun.Add("RunAllValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllValidationTests);
                return commandsToRun;
            }

            // Run All Crud Tests
            if (checkBoxAssetsCrud1.Checked
                && checkBoxAssetsCrud2.Checked
                && checkBoxBorrowerInfoCrud1.Checked
                //&& checkBoxBorrowerInfoCrud2.Checked
                && checkBoxCreditScoreCrud1.Checked
                && checkBoxCreditScoreCrud2.Checked
                && checkBoxEmpAndIncCrud1.Checked
                && checkBoxEmpAndIncCrud2.Checked
                //&& checkBoxLenderLoanInfoCrud1.Checked
                //&& checkBoxLenderLoanInfoCrud2.Checked
                && checkBoxLiabilitiesCrud1.Checked
                && checkBoxLiabilitiesCrud2.Checked
                && checkBoxReoCrud1.Checked
                && checkBoxReoCrud2.Checked
                //&& checkBoxSavingsPlanCrud1.Checked
                //&& checkBoxSavingsPlanCrud2.Checked
                && checkBoxSubjectPropCrud1.Checked
                //&& checkBoxSubjectPropCrud2.Checked
                )
            {
                commandsToRun.Add("RunAllCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllCrudTests);
                return commandsToRun;
            }


            // Run All One Urla Tests
            if (checkBoxAssetsValidation1.Checked
                && checkBoxBorrowerInfoValidation1.Checked
                && checkBoxCreditScoreCrud1.Checked
                && checkBoxCreditScoreValidation1.Checked
                && checkBoxDeclarationsValidation1.Checked
                && checkBoxEmpAndIncCrud1.Checked
                && checkBoxEmploymentAndIncomeValidation1.Checked
                //&& checkBoxLenderLoanInfoCrud1.Checked
                //&& checkBoxLenderLoanInfoValidation1.Checked
                && checkBoxLiabilitiesValidation1.Checked
                && checkBoxLiabilitiesCrud1.Checked
                && checkBoxLoanPanelsValidation1.Checked
                && checkBoxQualifyingTheBorrowerValidation1.Checked
                && checkBoxReoCrud1.Checked
                && checkBoxReoValidation1.Checked
                //&& checkBoxSavingsPlanCrud1.Checked
                //&& checkBoxSavingsPlanValidation1.Checked
                && checkBoxSubjectPropertyValidation1.Checked
                )
            {
                commandsToRun.Add("RunAllOneUrlaTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllOneUrlaTests);
                return commandsToRun;
            }

            // Run All VALIDATION One Urla Tests
            if (checkBoxAssetsValidation1.Checked
                && checkBoxBorrowerInfoValidation1.Checked
                && checkBoxAssetsValidation1.Checked
                && checkBoxDeclarationsValidation1.Checked
                && checkBoxEmploymentAndIncomeValidation1.Checked
                && checkBoxLiabilitiesValidation1.Checked
                && checkBoxLoanPanelsValidation1.Checked
                && checkBoxQualifyingTheBorrowerValidation1.Checked
                && checkBoxReoValidation1.Checked
                && checkBoxSubjectPropertyValidation1.Checked
                )
            {
                commandsToRun.Add("RunAllValidationOneUrlaTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllValidationOneUrlaTests);
                return commandsToRun;
            }

            // Run All CRUD One Urla Tests
            if (checkBoxAssetsCrud1.Checked
                && checkBoxBorrowerInfoCrud1.Checked
                && checkBoxCreditScoreCrud1.Checked
                && checkBoxEmpAndIncCrud1.Checked
                //&& checkBoxLenderLoanInfoCrud1.Checked
                && checkBoxLiabilitiesCrud1.Checked
                && checkBoxReoCrud1.Checked
                //&& checkBoxSavingsPlanCrud1.Checked
                && checkBoxSubjectPropCrud1.Checked
                )
            {
                commandsToRun.Add("RunAllCrudOneUrlaTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllCrudOneUrlaTests);
                return commandsToRun;
            }

            // Run ALL Two Urla Tests
            if (checkBoxAssetsValidation2.Checked
                && checkBoxAssetsCrud2.Checked
                && checkBoxBorrowerInfoValidation2.Checked
                && checkBoxCreditScoreValidation2.Checked
                && checkBoxCreditScoreCrud2.Checked
                && checkBoxDeclarationsValidation2.Checked
                && checkBoxEmploymentAndIncomeValidation2.Checked
                && checkBoxEmpAndIncCrud2.Checked
                //&& checkBoxLenderLoanInfoValidation2.Checked
                //&& checkBoxLenderLoanInfoCrud2.Checked
                && checkBoxLiabilitiesValidation2.Checked
                && checkBoxLiabilitiesCrud2.Checked
                && checkBoxLoanPanelsValidation2.Checked
                && checkBoxQualifyingTheBorrowerValidation2.Checked
                && checkBoxReoCrud2.Checked
                && checkBoxReoValidation2.Checked
                //&& checkBoxSavingsPlanValidation2.Checked
                //&& checkBoxSavingsPlanCrud2.Checked
                && checkBoxSubjectPropertyValidation2.Checked
                && checkBoxSubjectPropCrud2.Checked
                )
            {
                commandsToRun.Add("RunAllTwoUrlaTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllTwoUrlaTests);
                return commandsToRun;
            }

            // Run all VALIDATION Two Urla Tests
            if (checkBoxAssetsValidation2.Checked
                && checkBoxBorrowerInfoValidation2.Checked
                && checkBoxCreditScoreValidation2.Checked
                && checkBoxDeclarationsValidation2.Checked
                && checkBoxEmploymentAndIncomeValidation2.Checked
                //&& checkBoxLenderLoanInfoValidation2.Checked
                && checkBoxLiabilitiesValidation2.Checked
                && checkBoxLoanPanelsValidation2.Checked
                && checkBoxQualifyingTheBorrowerValidation2.Checked
                && checkBoxReoValidation2.Checked
                //&& checkBoxSavingsPlanValidation2.Checked
                && checkBoxSubjectPropertyValidation2.Checked
                )
            {
                commandsToRun.Add("RunAllValidationTwoUrlaTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllValidationTwoUrlaTests);
                return commandsToRun;
            }

            // Run all CRUD Two Urla Tests
            if (checkBoxAssetsCrud2.Checked
                && checkBoxBorrowerInfoCrud2.Checked
                && checkBoxCreditScoreCrud2.Checked
                && checkBoxEmpAndIncCrud2.Checked
                //&& checkBoxLenderLoanInfoCrud2.Checked
                && checkBoxLiabilitiesCrud2.Checked
                && checkBoxReoCrud2.Checked
                //&& checkBoxSavingsPlanCrud2.Checked
                && checkBoxSubjectPropCrud2.Checked
                )
            {
                commandsToRun.Add("RunAllCrudTwoUrlaTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenRunAllCrudTwoUrlaTests);
                return commandsToRun;
            }

            if (checkBoxAssetsValidation1.Checked
                && checkBoxAssetsValidation2.Checked
                && checkBoxAssetsCrud1.Checked
                && checkBoxAssetsCrud2.Checked
                )
                commandsToRun.Add("RunAllAssetsTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["RunAllAssetsTests"]);
            else if (checkBoxAssetsValidation1.Checked && checkBoxAssetsValidation2.Checked)
                commandsToRun.Add("RunAllAssetsValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["RunAllAssetsValidationTests"]);
            else if (checkBoxAssetsValidation1.Checked)
                commandsToRun.Add("AssetsValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["AssetsValidationOneUrlaTest"]);
            else if (checkBoxAssetsValidation2.Checked)
                commandsToRun.Add("AssetsValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["AssetsValidationTwoUrlaTest"]);
            else if (checkBoxAssetsCrud1.Checked && checkBoxAssetsCrud2.Checked)
                commandsToRun.Add("RunAllAssetsCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["RunAllAssetsCrudTests"]);
            else if (checkBoxAssetsCrud1.Checked)
                commandsToRun.Add("AssetsCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["AssetsCrudOneUrlaTest"]);
            else if (checkBoxAssetsCrud2.Checked)
                commandsToRun.Add("AssetsCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenAssetsTestCommandsDictionary["AssetsCrudTwoUrlaTest"]);

            if (checkBoxBorrowerInfoValidation1.Checked
                && checkBoxBorrowerInfoValidation2.Checked
                && checkBoxBorrowerInfoCrud1.Checked
                && (checkBoxBorrowerInfoCrud2.Checked)
                )
                commandsToRun.Add("RunAllBorrowerInfoTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["RunAllBorrowerInfoTests"]);
            else if (checkBoxBorrowerInfoValidation1.Checked && checkBoxBorrowerInfoValidation2.Checked)
                commandsToRun.Add("RunAllBorrowerInfoValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenBorrowerInfoTestCommandsDictionary["RunAllBorrowerInfoValidationTests"]);
            else if (checkBoxBorrowerInfoValidation1.Checked)
                commandsToRun.Add("BorrowerInfoValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenBorrowerInfoTestCommandsDictionary["BorrowerInfoValidationOneUrlaTest"]);
            else if (checkBoxBorrowerInfoValidation2.Checked)
                commandsToRun.Add("BorrowerInfoValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenBorrowerInfoTestCommandsDictionary["BorrowerInfoValidationTwoUrlaTest"]);
            else if (checkBoxBorrowerInfoCrud1.Checked && checkBoxBorrowerInfoCrud2.Checked)
                commandsToRun.Add("RunAllBorrowerInfoCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenBorrowerInfoTestCommandsDictionary["RunAllBorrowerInfoCrudTests"]);
            else if (checkBoxBorrowerInfoCrud1.Checked)
                commandsToRun.Add("BorrowerInfoCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenBorrowerInfoTestCommandsDictionary["BorrowerInfoCrudOneUrlaTest"]);
            else if (checkBoxBorrowerInfoCrud2.Checked)
                commandsToRun.Add("BorrowerInfoCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenBorrowerInfoTestCommandsDictionary["BorrowerInfoCrudTwoUrlaTest"]);

            if (checkBoxCreditScoreValidation1.Checked
                && checkBoxCreditScoreValidation2.Checked
                && checkBoxCreditScoreCrud1.Checked
                && checkBoxCreditScoreCrud2.Checked
                )
                commandsToRun.Add("RunAllCreditScoreTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["RunAllCreditScoreTests"]);
            else if (checkBoxCreditScoreValidation1.Checked && checkBoxCreditScoreValidation2.Checked)
                commandsToRun.Add("RunAllCreditScoreValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["RunAllCreditScoreValidationTests"]);
            else if (checkBoxCreditScoreValidation1.Checked)
                commandsToRun.Add("CreditScoreValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["CreditScoreValidationOneUrlaTest"]);
            else if (checkBoxCreditScoreValidation2.Checked)
                commandsToRun.Add("CreditScoreValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["CreditScoreValidationTwoUrlaTest"]);
            else if (checkBoxCreditScoreCrud1.Checked && checkBoxCreditScoreCrud2.Checked)
                commandsToRun.Add("RunAllCreditScoreCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["RunAllCreditScoreCrudTests"]);
            else if (checkBoxCreditScoreCrud1.Checked)
                commandsToRun.Add("CreditScoreCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["CreditScoreCrudOneUrlaTest"]);
            else if (checkBoxCreditScoreCrud2.Checked)
                commandsToRun.Add("CreditScoreCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenCreditScoreTestCommandsDictionary["CreditScoreCrudTwoUrlaTest"]);

            if (checkBoxDeclarationsValidation1.Checked && checkBoxDeclarationsValidation2.Checked)
                commandsToRun.Add("RunAllDeclarationsTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenDeclarationsTestCommandsDictionary["RunAllDeclarationsTests"]);
            else if (checkBoxDeclarationsValidation1.Checked)
                commandsToRun.Add("DeclarationsValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenDeclarationsTestCommandsDictionary["DeclarationsValidationOneUrlaTest"]);
            else if (checkBoxDeclarationsValidation2.Checked)
                commandsToRun.Add("DeclarationsValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenDeclarationsTestCommandsDictionary["DeclarationsValidationTwoUrlaTest"]);

            if (checkBoxEmploymentAndIncomeValidation1.Checked
                && checkBoxEmploymentAndIncomeValidation2.Checked
                && checkBoxEmpAndIncCrud1.Checked
                && checkBoxEmpAndIncCrud2.Checked
                )
                commandsToRun.Add("RunAllEmploymentAndIncomeTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["RunAllEmploymentAndIncomeTests"]);
            else if (checkBoxEmploymentAndIncomeValidation1.Checked && checkBoxEmploymentAndIncomeValidation2.Checked)
                commandsToRun.Add("RunAllEmploymentAndIncomeValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["RunAllEmploymentAndIncomeValidationTests"]);
            else if (checkBoxEmploymentAndIncomeValidation1.Checked)
                commandsToRun.Add("EmploymentAndIncomeValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["EmploymentAndIncomeValidationOneUrlaTest"]);
            else if (checkBoxEmploymentAndIncomeValidation2.Checked)
                commandsToRun.Add("EmploymentAndIncomeValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["EmploymentAndIncomeValidationTwoUrlaTest"]);
            else if (checkBoxEmpAndIncCrud1.Checked && checkBoxEmpAndIncCrud2.Checked)
                commandsToRun.Add("RunAllEmploymentAndIncomeCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["RunAllEmploymentAndIncomeCrudTests"]);
            else if (checkBoxEmpAndIncCrud1.Checked)
                commandsToRun.Add("EmploymentAndIncomeCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["EmploymentAndIncomeCrudOneUrlaTest"]);
            else if (checkBoxEmpAndIncCrud2.Checked)
                commandsToRun.Add("EmploymentAndIncomeCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenEmploymentAndIncomeTestCommandsDictionary["EmploymentAndIncomeCrudTwoUrlaTest"]);

            if (checkBoxLenderLoanInfoValidation1.Checked
                && checkBoxLenderLoanInfoCrud1.Checked
                )
                commandsToRun.Add("RunAllLenderLoanInfoTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLenderLoanInfoTestCommandsDictionary["RunAllLenderLoanInfoTests"]);
            else if (checkBoxLenderLoanInfoValidation1.Checked)
                commandsToRun.Add("LenderLoanInfoValidationOneUrlaTEst", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLenderLoanInfoTestCommandsDictionary["LenderLoanInfoValidationOneUrlaTest"]);
            else if (checkBoxLenderLoanInfoCrud1.Checked)
                commandsToRun.Add("LenderLoanInfoCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLenderLoanInfoTestCommandsDictionary["LenderLoanInfoCrudOneUrlaTest"]);

            if (checkBoxLiabilitiesValidation1.Checked
                && checkBoxLiabilitiesValidation2.Checked
                && checkBoxLiabilitiesCrud1.Checked
                && (checkBoxLiabilitiesCrud2.Checked)
                )
                commandsToRun.Add("RunAllLiabilitiesTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["RunAllLiabilitiesTests"]);
            else if (checkBoxLiabilitiesValidation1.Checked && checkBoxLiabilitiesValidation2.Checked)
                commandsToRun.Add("RunAllLiabilitiesValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["RunAllLiabilitiesValidationTests"]);
            else if (checkBoxLiabilitiesValidation1.Checked)
                commandsToRun.Add("LiabilitiesValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["LiabilitiesValidationOneUrlaTest"]);
            else if (checkBoxLiabilitiesValidation2.Checked)
                commandsToRun.Add("LiabilitiesValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["LiabilitiesValidationTwoUrlaTest"]);
            else if (checkBoxLiabilitiesCrud1.Checked && checkBoxLiabilitiesCrud2.Checked)
                commandsToRun.Add("RunAllLiabilitiesCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["RunAllLiabilitiesCrudTests"]);
            else if (checkBoxLiabilitiesCrud1.Checked)
                commandsToRun.Add("LiabilitiesCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["LiabilitiesCrudOneUrlaTest"]);
            else if (checkBoxLiabilitiesCrud2.Checked)
                commandsToRun.Add("LiabilitiesCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLiabilitiesTestCommandsDictionary["LiabilitiesCrudTwoUrlaTest"]);

            if (checkBoxLoanPanelsValidation1.Checked && checkBoxLoanPanelsValidation2.Checked)
                commandsToRun.Add("RunAllLoanPanelsTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLoanPanelsTestCommandsDictionary["RunAllLoanPanelsTests"]);
            else if (checkBoxLoanPanelsValidation1.Checked)
                commandsToRun.Add("LoanPanelsValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLoanPanelsTestCommandsDictionary["LoanPanelsValidationOneUrlaTest"]);
            else if (checkBoxLoanPanelsValidation2.Checked && checkBoxLoanPanelsValidation2.Enabled)
                commandsToRun.Add("LoanPanelsValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenLoanPanelsTestCommandsDictionary["LoanPanelsValidationTwoUrlaTest"]);

            if (checkBoxNavTest.Checked)
                commandsToRun.Add("NavigationTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenNavigationTestCommandsDictionary["NavigationTest"]);

            if (checkBoxQualifyingTheBorrowerValidation1.Checked && checkBoxQualifyingTheBorrowerValidation2.Checked && checkBoxQualifyingTheBorrowerValidation2.Enabled)
                commandsToRun.Add("RunAllQualifyingTheBorrowerValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenQualifyingTheBorrowerTestCommandsDictionary["RunAllQualifyingTheBorrowerValidationTests"]);
            else if (checkBoxQualifyingTheBorrowerValidation1.Checked)
                commandsToRun.Add("QualifyingTheBorrowerValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenQualifyingTheBorrowerTestCommandsDictionary["QualifyingTheBorrowerValidationOneUrlaTest"]);
            else if (checkBoxQualifyingTheBorrowerValidation2.Checked && checkBoxQualifyingTheBorrowerValidation2.Enabled)
                commandsToRun.Add("QualifyingTheBorrowerValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenQualifyingTheBorrowerTestCommandsDictionary["QualifyingTheBorrowerValidationTwoUrlaTest"]);

            if (checkBoxReoValidation1.Checked
                && checkBoxReoValidation2.Checked
                && checkBoxReoCrud1.Checked
                && checkBoxReoCrud2.Checked
                )
                commandsToRun.Add("RunAllReoTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenReoTestCommandsDictionary["RunAllReoTests"]);
            else if (checkBoxReoValidation1.Checked)
                commandsToRun.Add("ReoValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenReoTestCommandsDictionary["ReoValidationOneUrlaTest"]);
            else if (checkBoxReoValidation2.Checked && checkBoxReoValidation2.Enabled)
                commandsToRun.Add("ReoValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenReoTestCommandsDictionary["ReoValidationTwoUrlaTest"]);
            else if (checkBoxReoCrud1.Checked && checkBoxReoCrud2.Checked)
                commandsToRun.Add("RunAllReoCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenReoTestCommandsDictionary["RunAllReoCrudTests"]);
            else if (checkBoxReoCrud1.Checked)
                commandsToRun.Add("ReoCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenReoTestCommandsDictionary["ReoCrudOneUrlaTest"]);
            else if (checkBoxReoCrud2.Checked)
                commandsToRun.Add("ReoCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenReoTestCommandsDictionary["ReoCrudTwoUrlaTest"]);

            if (checkBoxSavingsPlanValidation1.Checked
                && checkBoxSavingsPlanCrud1.Checked
                )
                commandsToRun.Add("RunAllSavingsPlanTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSavingsPlanTestCommandsDictionary["RunAllSavingsPlanTests"]);
            else if (checkBoxSavingsPlanValidation1.Checked)
                commandsToRun.Add("SavingsPlanValidationOneUrlaTEst", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSavingsPlanTestCommandsDictionary["SavingsPlanValidationOneUrlaTest"]);
            else if (checkBoxSavingsPlanCrud1.Checked)
                commandsToRun.Add("SavingsPlanCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSavingsPlanTestCommandsDictionary["SavingsPlanCrudOneUrlaTest"]);

            if (checkBoxSubjectPropertyValidation1.Checked
                && checkBoxSubjectPropertyValidation2.Checked
                && checkBoxSubjectPropCrud1.Checked
                && checkBoxSubjectPropCrud2.Checked
                )
                commandsToRun.Add("RunAllSubjectPropertyTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["RunAllSubjectPropertyTests"]);
            else if (checkBoxSubjectPropertyValidation1.Checked && checkBoxSubjectPropertyValidation2.Checked)
                commandsToRun.Add("RunAllSubjectPropertyValidationTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["RunAllSubjectPropertyValidationTests"]);
            else if (checkBoxSubjectPropertyValidation1.Checked && checkBoxSubjectPropertyValidation1.Enabled)
                commandsToRun.Add("SubjectPropertyValidationOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["SubjectPropertyValidationOneUrlaTest"]);
            else if (checkBoxSubjectPropertyValidation2.Checked && checkBoxSubjectPropertyValidation2.Enabled)
                commandsToRun.Add("SubjectPropertyValidationTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["SubjectPropertyValidationTwoUrlaTest"]);
            else if (checkBoxSubjectPropCrud1.Checked && checkBoxSubjectPropCrud2.Checked)
                commandsToRun.Add("RunAllSubjectPropertyCrudTests", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["RunAllSubjectPropertyCrudTests"]);
            else if (checkBoxSubjectPropCrud1.Checked)
                commandsToRun.Add("SubjectPropertyCrudOneUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["SubjectPropertyCrudOneUrlaTest"]);
            else if (checkBoxSubjectPropCrud2.Checked)
                commandsToRun.Add("SubjectPropertyCrudTwoUrlaTest", Settings.Instance.SettingsDto.ScreenTestCommandsDto.ScreenSubjectPropertyTestCommandsDictionary["SubjectPropertyCrudTwoUrlaTest"]);

            return commandsToRun;
        }

        private void checkBoxAssetsCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxAssetsCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxAssetsCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxAssetsCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void assetsValidationCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxAssetsValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void assetsValidationCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxAssetsValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxBorrowerInfoValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxBorrowerInfoValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxBorrowerInfoValidation2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxBorrowerInfoValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxBorrowerInfoCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxBorrowerInfoCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxBorrowerInfoCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxBorrowerInfoCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxCreditScoreValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxCreditScoreValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxCreditScoreValidation2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxCreditScoreValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxCreditScoreCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxCreditScoreCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxCreditScoreCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxCreditScoreCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void declarationsValidationCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxDeclarationsValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void declarationsValidationCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxDeclarationsValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxEmpAndIncCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxEmpAndIncCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxEmpAndIncCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxEmpAndIncCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void employmentAndIncomeValidationCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxEmploymentAndIncomeValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void employmentAndIncomeValidationCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxEmploymentAndIncomeValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLenderLoanInfoValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLenderLoanInfoValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLenderLoanInfoCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLenderLoanInfoCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLiabilitiesValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLiabilitiesValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLiabilitiesValidation2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLiabilitiesValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLiabilitiesCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLiabilitiesCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLiabilitiesCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLiabilitiesCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLoanPanelsValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLoanPanelsValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxLoanPanelsValidation2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxLoanPanelsValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxNavTest_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxNavTest.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void qualifyingTheBorrowerValidationCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxQualifyingTheBorrowerValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void qualifyingTheBorrowerValidationCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxQualifyingTheBorrowerValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxReoCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxReoCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxReoCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxReoCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void reoValidationCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxReoValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void reoValidationCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxReoValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxSavingsPlanValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxSavingsPlanValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxSavingsPlanCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxSavingsPlanCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxSubjectPropCrud1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxSubjectPropCrud1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxSubjectPropCrud2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxSubjectPropCrud2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxSubjectPropertyValidation1_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxSubjectPropertyValidation1.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void checkBoxSubjectPropertyValidation2_CheckedChanged(object sender, EventArgs e)
        {
            _numTotalTestsSelected += checkBoxSubjectPropertyValidation2.Checked ? 1 : -1;
            labelNumTestsSelected.Text = _numTotalTestsSelected.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabelRanorexReportDirectory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Environment.GetEnvironmentVariable("WINDIR") + @"\explorer.exe", e.Link.LinkData as string);

            //Process.Start(e.Link.LinkData as string);
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            checkBoxAssetsCrud1.Checked = true;
            checkBoxAssetsCrud2.Checked = true;
            checkBoxAssetsValidation1.Checked = true;
            checkBoxAssetsValidation2.Checked = true;
            checkBoxBorrowerInfoCrud1.Checked = true;
            if (checkBoxBorrowerInfoCrud2.Enabled)
                checkBoxBorrowerInfoCrud2.Checked = true;
            checkBoxBorrowerInfoValidation1.Checked = true;
            checkBoxBorrowerInfoValidation2.Checked = true;
            checkBoxCreditScoreCrud1.Checked = true;
            checkBoxCreditScoreCrud2.Checked = true;
            checkBoxCreditScoreValidation1.Checked = true;
            checkBoxCreditScoreValidation2.Checked = true;
            checkBoxDeclarationsValidation1.Checked = true;
            checkBoxDeclarationsValidation2.Checked = true;
            checkBoxEmpAndIncCrud1.Checked = true;
            checkBoxEmpAndIncCrud2.Checked = true;
            checkBoxEmploymentAndIncomeValidation1.Checked = true;
            checkBoxEmploymentAndIncomeValidation2.Checked = true;
            if (checkBoxLenderLoanInfoCrud1.Enabled)
                checkBoxLenderLoanInfoCrud1.Checked = true;
            if (checkBoxLenderLoanInfoValidation1.Enabled)
                checkBoxLenderLoanInfoValidation1.Checked = true;
            checkBoxLiabilitiesCrud1.Checked = true;
            checkBoxLiabilitiesCrud2.Checked = true;
            checkBoxLiabilitiesValidation1.Checked = true;
            checkBoxLiabilitiesValidation2.Checked = true;
            checkBoxLoanPanelsValidation1.Checked = true;
            checkBoxLoanPanelsValidation2.Checked = true;
            checkBoxNavTest.Checked = true;
            checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            checkBoxQualifyingTheBorrowerValidation2.Checked = true;
            checkBoxReoCrud1.Checked = true;
            checkBoxReoCrud2.Checked = true;
            checkBoxReoValidation1.Checked = true;
            checkBoxReoValidation2.Checked = true;
            checkBoxSavingsPlanCrud1.Checked = true;
            checkBoxSavingsPlanValidation1.Checked = true;
            checkBoxSubjectPropCrud1.Checked = true;
            if (checkBoxSubjectPropCrud2.Enabled)
                checkBoxSubjectPropCrud2.Checked = true;
            checkBoxSubjectPropertyValidation1.Checked = true;
            if (checkBoxSubjectPropertyValidation2.Enabled)
                checkBoxSubjectPropertyValidation2.Checked = true;
        }

        private void buttonDeselectAll_Click(object sender, EventArgs e)
        {
            DeselectAllTests();
        }

        private void buttonAllValidationTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsValidation1.Checked = true;
            checkBoxAssetsValidation2.Checked = true;
            checkBoxBorrowerInfoValidation1.Checked = true;
            checkBoxBorrowerInfoValidation2.Checked = true;
            checkBoxCreditScoreValidation1.Checked = true;
            checkBoxCreditScoreValidation2.Checked = true;
            checkBoxDeclarationsValidation1.Checked = true;
            checkBoxDeclarationsValidation2.Checked = true;
            checkBoxEmploymentAndIncomeValidation1.Checked = true;
            checkBoxEmploymentAndIncomeValidation2.Checked = true;
            if (checkBoxLenderLoanInfoValidation1.Enabled)
                checkBoxLenderLoanInfoValidation1.Checked = true;
            checkBoxLiabilitiesValidation1.Checked = true;
            checkBoxLiabilitiesValidation2.Checked = true;
            checkBoxLoanPanelsValidation1.Checked = true;
            checkBoxLoanPanelsValidation2.Checked = true;
            checkBoxNavTest.Checked = true;
            checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            checkBoxQualifyingTheBorrowerValidation2.Checked = true;
            checkBoxReoValidation1.Checked = true;
            checkBoxReoValidation2.Checked = true;
            checkBoxSavingsPlanValidation1.Checked = true;
            checkBoxSubjectPropertyValidation1.Checked = true;
            if (checkBoxSubjectPropertyValidation2.Enabled)
                checkBoxSubjectPropertyValidation2.Checked = true;
        }

        private void buttonAllValidationOneUrlaTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsValidation1.Checked = true;
            checkBoxBorrowerInfoValidation1.Checked = true;
            checkBoxCreditScoreValidation1.Checked = true;
            checkBoxDeclarationsValidation1.Checked = true;
            checkBoxEmploymentAndIncomeValidation1.Checked = true;
            if (checkBoxLenderLoanInfoValidation1.Enabled)
                checkBoxLenderLoanInfoValidation1.Checked = true;
            checkBoxLiabilitiesValidation1.Checked = true;
            checkBoxLoanPanelsValidation1.Checked = true;
            checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            checkBoxReoValidation1.Checked = true;
            if (checkBoxSavingsPlanValidation1.Enabled)
                checkBoxSavingsPlanValidation1.Checked = true;
            checkBoxSubjectPropertyValidation1.Checked = true;
        }

        private void buttonAllValidationTwoUrlaTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsValidation2.Checked = true;
            checkBoxBorrowerInfoValidation2.Checked = true;
            checkBoxCreditScoreValidation2.Checked = true;
            checkBoxDeclarationsValidation2.Checked = true;
            checkBoxEmploymentAndIncomeValidation2.Checked = true;
            checkBoxLiabilitiesValidation2.Checked = true;
            checkBoxLoanPanelsValidation2.Checked = true;
            checkBoxQualifyingTheBorrowerValidation2.Checked = true;
            checkBoxReoValidation2.Checked = true;
            if (checkBoxSubjectPropertyValidation2.Enabled)
                checkBoxSubjectPropertyValidation2.Checked = true;
        }

        private void buttonAllCrudTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud1.Checked = true;
            checkBoxAssetsCrud2.Checked = true;
            checkBoxBorrowerInfoCrud1.Checked = true;
            if (checkBoxBorrowerInfoCrud2.Enabled)
                checkBoxBorrowerInfoCrud2.Checked = true;
            checkBoxCreditScoreCrud1.Checked = true;
            checkBoxCreditScoreCrud2.Checked = true;
            checkBoxEmpAndIncCrud1.Checked = true;
            checkBoxEmpAndIncCrud2.Checked = true;
            checkBoxLenderLoanInfoCrud1.Checked = true;
            checkBoxLiabilitiesCrud1.Checked = true;
            checkBoxLiabilitiesCrud2.Checked = true;
            checkBoxReoCrud1.Checked = true;
            checkBoxReoCrud2.Checked = true;
            checkBoxSavingsPlanCrud1.Checked = true;
            checkBoxSubjectPropCrud1.Checked = true;
            if (checkBoxSubjectPropCrud2.Enabled)
                checkBoxSubjectPropCrud2.Checked = true;
        }

        private void buttonAllCrudOneUrlaTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud1.Checked = true;
            checkBoxBorrowerInfoCrud1.Checked = true;
            checkBoxCreditScoreCrud1.Checked = true;
            checkBoxEmpAndIncCrud1.Checked = true;
            if (checkBoxLenderLoanInfoCrud1.Enabled)
                checkBoxLenderLoanInfoCrud1.Checked = true;
            checkBoxLiabilitiesCrud1.Checked = true;
            checkBoxReoCrud1.Checked = true;
            if (checkBoxSavingsPlanCrud1.Enabled)
                checkBoxSavingsPlanCrud1.Checked = true;
            checkBoxSubjectPropCrud1.Checked = true;
        }

        private void buttonAllCrudTwoUrlaTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud2.Checked = true;
            if (checkBoxBorrowerInfoCrud2.Enabled)
                checkBoxBorrowerInfoCrud2.Checked = true;
            checkBoxCreditScoreCrud2.Checked = true;
            checkBoxEmpAndIncCrud2.Checked = true;
            checkBoxLiabilitiesCrud2.Checked = true;
            checkBoxReoCrud2.Checked = true;
            if (checkBoxSubjectPropCrud2.Enabled)
                checkBoxSubjectPropCrud2.Checked = true;
        }

        private void buttonAllOneUrlaLoanTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud1.Checked = true;
            checkBoxAssetsValidation1.Checked = true;
            checkBoxBorrowerInfoCrud1.Checked = true;
            checkBoxBorrowerInfoValidation1.Checked = true;
            checkBoxCreditScoreCrud1.Checked = true;
            checkBoxCreditScoreValidation1.Checked = true;
            checkBoxDeclarationsValidation1.Checked = true;
            checkBoxEmpAndIncCrud1.Checked = true;
            checkBoxEmploymentAndIncomeValidation1.Checked = true;
            if (checkBoxLenderLoanInfoCrud1.Enabled)
                checkBoxLenderLoanInfoCrud1.Checked = true;
            if (checkBoxLenderLoanInfoValidation1.Enabled)
                checkBoxLenderLoanInfoValidation1.Checked = true;
            checkBoxLiabilitiesCrud1.Checked = true;
            checkBoxLiabilitiesValidation1.Checked = true;
            checkBoxLoanPanelsValidation1.Checked = true;
            checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            checkBoxReoCrud1.Checked = true;
            checkBoxReoValidation1.Checked = true;
            if (checkBoxSavingsPlanCrud1.Enabled)
                checkBoxSavingsPlanCrud1.Checked = true;
            if (checkBoxSavingsPlanValidation1.Enabled)
                checkBoxSavingsPlanValidation1.Checked = true;
            checkBoxSubjectPropertyValidation1.Checked = true;
        }

        private void buttonAllTwoUrlaLoanTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud2.Checked = true;
            checkBoxAssetsValidation2.Checked = true;
            if (checkBoxBorrowerInfoCrud2.Enabled)
                checkBoxBorrowerInfoCrud2.Checked = true;
            checkBoxCreditScoreCrud2.Checked = true;
            checkBoxCreditScoreValidation2.Checked = true;
            checkBoxDeclarationsValidation2.Checked = true;
            checkBoxEmpAndIncCrud2.Checked = true;
            checkBoxEmploymentAndIncomeValidation2.Checked = true;
            checkBoxLiabilitiesCrud2.Checked = true;
            checkBoxLiabilitiesValidation2.Checked = true;
            checkBoxLoanPanelsValidation2.Checked = true;
            checkBoxQualifyingTheBorrowerValidation2.Checked = true;
            checkBoxReoCrud2.Checked = true;
            checkBoxReoValidation2.Checked = true;
            if (checkBoxSubjectPropCrud2.Enabled)
                checkBoxSubjectPropCrud2.Checked = true;
            if (checkBoxSubjectPropertyValidation2.Enabled)
                checkBoxSubjectPropertyValidation2.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonAllAssetsTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud1.Checked = true;
            checkBoxAssetsCrud2.Checked = true;
            checkBoxAssetsValidation1.Checked = true;
            checkBoxAssetsValidation2.Checked = true;
        }

        private void buttonAllBorrowerInfoTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxBorrowerInfoCrud1.Checked = true;
            if (checkBoxBorrowerInfoCrud2.Enabled)
                checkBoxBorrowerInfoCrud2.Checked = true;
            checkBoxBorrowerInfoValidation1.Checked = true;
            checkBoxBorrowerInfoValidation2.Checked = true;
        }

        private void buttonAllCreditScoreTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxCreditScoreCrud1.Checked = true;
            checkBoxCreditScoreCrud2.Checked = true;
            checkBoxCreditScoreValidation1.Checked = true;
            checkBoxCreditScoreValidation2.Checked = true;
        }

        private void buttonAllDeclarationsTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxDeclarationsValidation1.Checked = true;
            checkBoxDeclarationsValidation2.Checked = true;
        }

        private void buttonAllEmploymentAndIncomeTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxEmpAndIncCrud1.Checked = true;
            checkBoxEmpAndIncCrud2.Checked = true;
            checkBoxEmploymentAndIncomeValidation1.Checked = true;
            checkBoxEmploymentAndIncomeValidation2.Checked = true;
        }

        private void buttonAllLenderLoanInfoTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            if (checkBoxLenderLoanInfoCrud1.Enabled)
                checkBoxLenderLoanInfoCrud1.Checked = true;
            if (checkBoxLenderLoanInfoValidation1.Enabled)
                checkBoxLenderLoanInfoValidation1.Checked = true;
        }

        private void buttonAllLoanPanelTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxLoanPanelsValidation1.Checked = true;
            checkBoxLoanPanelsValidation2.Checked = true;
        }

        private void buttonAllLiabilitesTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxLiabilitiesCrud1.Checked = true;
            checkBoxLiabilitiesCrud2.Checked = true;
            checkBoxLiabilitiesValidation1.Checked = true;
            checkBoxLiabilitiesValidation2.Checked = true;
        }

        private void buttonAllQualifyingTheBorrowerTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            checkBoxQualifyingTheBorrowerValidation2.Checked = true;
        }

        private void buttonAllReoTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxReoCrud1.Checked = true;
            checkBoxReoCrud2.Checked = true;
            checkBoxReoValidation1.Checked = true;
            checkBoxReoValidation2.Checked = true;
        }

        private void buttonAllSavingsPlanTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxSavingsPlanCrud1.Checked = true;
            checkBoxSavingsPlanValidation1.Checked = true;
        }

        private void buttonAllSubjectPropertyTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxSubjectPropCrud1.Checked = true;
            if (checkBoxSubjectPropCrud2.Enabled)
                checkBoxSubjectPropCrud2.Checked = true;
            checkBoxSubjectPropertyValidation1.Checked = true;
            if (checkBoxSubjectPropertyValidation2.Enabled)
                checkBoxSubjectPropertyValidation2.Checked = true;
        }

        private void buttonAllOneUrlaTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud1.Checked = true;
            checkBoxAssetsValidation1.Checked = true;
            checkBoxBorrowerInfoCrud1.Checked = true;
            checkBoxBorrowerInfoValidation1.Checked = true;
            checkBoxCreditScoreCrud1.Checked = true;
            checkBoxCreditScoreValidation1.Checked = true;
            checkBoxDeclarationsValidation1.Checked = true;
            checkBoxEmpAndIncCrud1.Checked = true;
            checkBoxEmploymentAndIncomeValidation1.Checked = true;
            if (checkBoxLenderLoanInfoCrud1.Enabled)
                checkBoxLenderLoanInfoCrud1.Checked = true;
            if (checkBoxLenderLoanInfoValidation1.Enabled)
                checkBoxLenderLoanInfoValidation1.Checked = true;
            checkBoxLiabilitiesCrud1.Checked = true;
            checkBoxLiabilitiesValidation1.Checked = true;
            checkBoxLoanPanelsValidation1.Checked = true;
            checkBoxQualifyingTheBorrowerValidation1.Checked = true;
            checkBoxReoCrud1.Checked = true;
            checkBoxReoValidation1.Checked = true;
            if (checkBoxSavingsPlanCrud1.Enabled)
                checkBoxSavingsPlanCrud1.Checked = true;
            if (checkBoxSavingsPlanValidation1.Enabled)
                checkBoxSavingsPlanValidation1.Checked = true;
            checkBoxSubjectPropCrud1.Checked = true;
            checkBoxSubjectPropertyValidation1.Checked = true;
        }

        private void buttonAllTwoUrlaTests_Click(object sender, EventArgs e)
        {
            DeselectAllTests();

            checkBoxAssetsCrud2.Checked = true;
            checkBoxAssetsValidation2.Checked = true;
            if (checkBoxBorrowerInfoCrud2.Enabled)
                checkBoxBorrowerInfoCrud2.Checked = true;
            checkBoxBorrowerInfoValidation2.Checked = true;
            checkBoxCreditScoreCrud2.Checked = true;
            checkBoxCreditScoreValidation2.Checked = true;
            checkBoxDeclarationsValidation2.Checked = true;
            checkBoxEmpAndIncCrud2.Checked = true;
            checkBoxEmploymentAndIncomeValidation2.Checked = true;
            checkBoxLiabilitiesCrud2.Checked = true;
            checkBoxLiabilitiesValidation2.Checked = true;
            checkBoxLoanPanelsValidation2.Checked = true;
            checkBoxQualifyingTheBorrowerValidation2.Checked = true;
            checkBoxReoCrud2.Checked = true;
            checkBoxReoValidation2.Checked = true;
            if (checkBoxSubjectPropCrud2.Enabled)
                checkBoxSubjectPropCrud2.Checked = true;
            if (checkBoxSubjectPropertyValidation2.Enabled)
                checkBoxSubjectPropertyValidation2.Checked = true;
        }

        private void dataGridViewTestConfigurationsExecuted_SelectionChanged(object sender, EventArgs e)
        {
            dataGridViewTestConfigurationsExecuted.ClearSelection();
        }

        public DialogResult ShowEmailMessageDialog(string beginningText)
        {
            DialogResult result = DialogResult.Cancel;

            EmailMessageForm emailForm = new EmailMessageForm();

            emailForm.richTextBoxMessage.Text = beginningText;

            emailForm.richTextBoxMessage.SelectionStart = 0;

            if (emailForm.ShowDialog(this) == DialogResult.OK)
            {
                string[] lines = emailForm.richTextBoxMessage.Lines;

                for (int i = 0; i < lines.Length; i++)
                {
                    _emailMessage += lines[i] + "\r\n";
                }

                _emailRecipients = DetermineEmailRecipients(emailForm);

                result = DialogResult.OK;
            }
            else
            {
                result = DialogResult.Cancel;
            }

            emailForm.Dispose();

            return result;
        }

        private void buttonEmailSelectedReports_Click(object sender, EventArgs e)
        {
            int count = 0;

            string dialogText = "\r\n\r\n";

            foreach (DataGridViewRow row in dataGridViewTestConfigurationsExecuted.Rows)
            {

                if (Convert.ToBoolean(row.Cells[2].Value))
                {
                    count++;

                    dialogText += row.Cells[0].Value.ToString() + "\t" + row.Cells[1].Value.ToString() + "\r\n";
                }
            }

            if (count > 0)
            {
                DialogResult result = ShowEmailMessageDialog(dialogText);

                if (result == DialogResult.OK)
                {
                    // Determine recipients

                    foreach (EmailDto emailDto in _emailRecipients)
                    {
                        NotificationView view = new NotificationView();
                        view.SenderFullName = emailDto.SenderFullName;
                        view.SenderFirstName = emailDto.SenderFirstName;
                        view.SenderEmail = emailDto.SenderEmail;
                        view.RecipientFullName = emailDto.RecipientFullName;
                        view.RecipientFirstName = emailDto.RecipientFirstName;
                        view.RecipientEmail = emailDto.RecipientEmail;
                        view.Subject = emailDto.Subject + $" Environment: {Settings.Instance.SettingsDto.AppSettingsDto.Environment}.";
                        view.Message = _emailMessage;

                        //Send(view);
                    }
                    ShowEmailToast();
                    _emailMessage = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("You must select at least one report to email.", "Automated Test Runner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SendEmail(List<EmailDto> recipients, string message)
        {
            foreach (EmailDto emailDto in recipients)
            {
                NotificationView view = new NotificationView();
                view.SenderFullName = emailDto.SenderFullName;
                view.SenderFirstName = emailDto.SenderFirstName;
                view.SenderEmail = emailDto.SenderEmail;
                view.RecipientFullName = emailDto.RecipientFullName;
                view.RecipientFirstName = emailDto.RecipientFirstName;
                view.RecipientEmail = emailDto.RecipientEmail;
                view.Subject = emailDto.Subject + $"Environment: {Settings.Instance.SettingsDto.AppSettingsDto.Environment}.";
                view.Message = message;

                //Send(view);
            }
        }

        public List<EmailDto> DetermineEmailRecipients(EmailMessageForm emailForm)
        {
            List<EmailDto> recipients = new List<EmailDto>();

            if (emailForm.checkBoxPrimary.Checked == true)
            {
                if (emailForm.checkBoxSecondary.Checked == true)
                {
                    recipients.Add(Settings.Instance.SettingsDto.EmailDtos[0]);
                    recipients.Add(Settings.Instance.SettingsDto.EmailDtos[1]);
                }
                else
                    recipients.Add(Settings.Instance.SettingsDto.EmailDtos[0]);
            }
            else if (emailForm.checkBoxSecondary.Checked == true)
                recipients.Add(Settings.Instance.SettingsDto.EmailDtos[1]);
            else
                recipients = null;

            return recipients;
        }

         /*
        public void Send(NotificationView view)
        {
            try
            {
                var notificationsMgtGateway = CreateNotificationsMgtGateway();
                var command = CreateNotificationCommand(view);
                notificationsMgtGateway.ProcessBroadcastNotification(command);
            }
            catch (Exception ex)
            {
                DBLogger.Instance.WriteLogMessage("AutomationTestRunner", "Email Functionality", null, $"An exception occurred in trying to send email to '{view.RecipientFullName}'.  The error was '{ex.Message}'.", LogMessageTypes.ERROR.ToString());
                throw;
            }
        }
        private INotificationsMgtGateway CreateNotificationsMgtGateway()
        {
            // Mike - Here are the configurations available.  I'll refactor this code to the preferred way (which I guess will be the IConfuration way instead of
            // the way I origionally implmented.  Anyway, are we perhaps missing a particular configuration setting?  Are we invoking the right method in the
            // gateway?  Just some thoughts...

            var configuration = Program.Configuration;
            return new NotificationsMgtGatewayFactory(configuration, new PFNullLoggerFactory()).Create();
        }

        private BusinessNotificationBroadcastRequestCommand CreateNotificationCommand(NotificationView notificationView)
        {
            string loanId = "78-262047A";
            string subject = notificationView.Subject;

            var command =
                new BusinessNotificationBroadcastRequestCommand
                {
                    BusinessObjectType = "Loan",
                    BusinessObjectId = loanId,
                    Summary = subject
                };

            // note: Subject of email
            command.ContentsShort = command.Summary;

            // note: Leave empty as we're providing only rich/html email contents
            command.ContentsPlain = string.Empty;

            command.ContentsRich = notificationView.Message;
            command.NotificationBroadcastId = Guid.NewGuid();
            command.NotificationName = PFBusinessNotificationNameType.RevenueScenarioProposed;
            command.Publisher = "LendingCenter";
            command.TargetRole = string.Empty; // note: Leave empty as we are targeting very specific users via their email addresss
            command.TraceabilityId = $"{loanId}:1";
            command.TraceabilityName = "Test Automation";
            command.TraceabilityType = "PriceAndFeeException"; // todo: what are we notifying about?

            command.Channels.Add(
                new ChannelDefinition
                {
                    TargetPlatformType = TargetPlatformType.Windows,
                    TargetChannelType = TargetChannelType.Email,
                    TargetAddressType = TargetAddressType.Email,
                    TargetAddress = notificationView.RecipientEmail,
                    TargetRecipient = notificationView.RecipientFullName,
                    TargetRole = string.Empty
                });

            return command;
        }
        */
        private void ShowEmailToast()
        {
            PopupNotifier toast = new PopupNotifier();
            toast.TitleText = "Test Runner";
            toast.ContentText = "Email(s) have been sent!";
            toast.BodyColor = Color.Aqua;
            toast.AnimationInterval = 5000;
            toast.Popup();
        }

        private void DeselectAllTests()
        {
            checkBoxAssetsCrud1.Checked = false;
            checkBoxAssetsCrud2.Checked = false;
            checkBoxAssetsValidation1.Checked = false;
            checkBoxAssetsValidation2.Checked = false;
            checkBoxBorrowerInfoCrud1.Checked = false;
            checkBoxBorrowerInfoCrud2.Checked = false;
            checkBoxBorrowerInfoValidation1.Checked = false;
            checkBoxBorrowerInfoValidation2.Checked = false;
            checkBoxCreditScoreCrud1.Checked = false;
            checkBoxCreditScoreCrud2.Checked = false;
            checkBoxCreditScoreValidation1.Checked = false;
            checkBoxCreditScoreValidation2.Checked = false;
            checkBoxDeclarationsValidation1.Checked = false;
            checkBoxDeclarationsValidation2.Checked = false;
            checkBoxEmpAndIncCrud1.Checked = false;
            checkBoxEmpAndIncCrud2.Checked = false;
            checkBoxEmploymentAndIncomeValidation1.Checked = false;
            checkBoxEmploymentAndIncomeValidation2.Checked = false;
            checkBoxLenderLoanInfoCrud1.Checked = false;
            checkBoxLenderLoanInfoValidation1.Checked = false;
            checkBoxLiabilitiesCrud1.Checked = false;
            checkBoxLiabilitiesCrud2.Checked = false;
            checkBoxLiabilitiesValidation1.Checked = false;
            checkBoxLiabilitiesValidation2.Checked = false;
            checkBoxLoanPanelsValidation1.Checked = false;
            checkBoxLoanPanelsValidation2.Checked = false;
            checkBoxNavTest.Checked = false;
            checkBoxQualifyingTheBorrowerValidation1.Checked = false;
            checkBoxQualifyingTheBorrowerValidation2.Checked = false;
            checkBoxReoCrud1.Checked = false;
            checkBoxReoCrud2.Checked = false;
            checkBoxReoValidation1.Checked = false;
            checkBoxReoValidation2.Checked = false;
            checkBoxSavingsPlanCrud1.Checked = false;
            checkBoxSavingsPlanValidation1.Checked = false;
            checkBoxSubjectPropCrud1.Checked = false;
            checkBoxSubjectPropCrud2.Checked = false;
            checkBoxSubjectPropertyValidation1.Checked = false;
            checkBoxSubjectPropertyValidation2.Checked = false;
        }

        private void radioButtonAllMessagesSansDebugInfoAndSuccess_CheckedChanged(object sender, EventArgs e)
        {
            _logVerbosity = "AllMessagesSansDebugInfoAndSuccess";
        }

        private void radioButtonAllMessagesSansDebug_CheckedChanged(object sender, EventArgs e)
        {
            _logVerbosity = "AllMessagesSansDebug";
        }

        private void radioButtonAllMessagesSansDebugAndInfo_CheckedChanged(object sender, EventArgs e)
        {
            _logVerbosity = "AllMessagesSansDebugAndInfo";
        }

        private void radioButtonAllMessages_CheckedChanged(object sender, EventArgs e)
        {
            _logVerbosity = "AllMessages";
        }

        private void radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo_CheckedChanged(object sender, EventArgs e)
        {
            _logVerbosity = "OnlySectionsWarningsErrorsFailuresCriticalInfo";
        }

        private void radioButtonOnlySectionsErrorsFailuresCriticalInfo_CheckedChanged(object sender, EventArgs e)
        {
            _logVerbosity = "OnlySectionsErrorsFailuresCriticalInfo";
        }

        private void checkBoxRunForRecord_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRunForRecord.Checked == true)
            {
                checkBoxNotifyUponCompletion.Checked = true;

                if (radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Checked == false)
                {
                    radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Checked = true;
                    MessageBox.Show("The Log Verbosity Setting has been changed to 'Sections, Warnings, Errors, Failures and Critical Info'.\r\n\r\nHowever, you may change it a different setting via the Verbosity radio buttons.", "Automated Test Runner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

		private void groupBoxSelectDeselectButtons_Enter(object sender, EventArgs e)
		{

		}
	}

	public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
