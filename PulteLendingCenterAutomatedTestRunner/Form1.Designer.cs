
using PulteLendingCenterAutomatedTestRunner.Controls;
using System.Threading.Tasks;

namespace PulteLendingCenterAutomatedTestRunner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBoxScreenTestCheckboxes = new System.Windows.Forms.GroupBox();
			this.groupBoxSavingsPlan = new System.Windows.Forms.GroupBox();
			this.checkBoxSavingsPlanCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxSavingsPlanValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxLenderLoanInfo = new System.Windows.Forms.GroupBox();
			this.checkBoxLenderLoanInfoCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxLenderLoanInfoValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxCreditScore = new System.Windows.Forms.GroupBox();
			this.checkBoxCreditScoreCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxCreditScoreCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxCreditScoreValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxCreditScoreValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxEmploymentAndIncomeScreen = new System.Windows.Forms.GroupBox();
			this.checkBoxEmpAndIncCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxEmpAndIncCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxEmploymentAndIncomeValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxEmploymentAndIncomeValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxNavTest = new System.Windows.Forms.GroupBox();
			this.checkBoxNavTest = new System.Windows.Forms.CheckBox();
			this.groupBoxAssetsScreen = new System.Windows.Forms.GroupBox();
			this.checkBoxAssetsCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxAssetsCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxAssetsValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxAssetsValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxLiabilitiesScreen = new System.Windows.Forms.GroupBox();
			this.checkBoxLiabilitiesCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxLiabilitiesCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxLiabilitiesValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxLiabilitiesValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxBorrowerInfo = new System.Windows.Forms.GroupBox();
			this.checkBoxBorrowerInfoCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxBorrowerInfoCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxBorrowerInfoValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxBorrowerInfoValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.checkBoxDeclarationsValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxDeclarationsValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxSubjectPropertyScreen = new System.Windows.Forms.GroupBox();
			this.checkBoxSubjectPropCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxSubjectPropCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxSubjectPropertyValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxSubjectPropertyValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxQualifyingTheBorrower = new System.Windows.Forms.GroupBox();
			this.checkBoxQualifyingTheBorrowerValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxQualifyingTheBorrowerValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkBoxReoCrud2 = new System.Windows.Forms.CheckBox();
			this.checkBoxReoCrud1 = new System.Windows.Forms.CheckBox();
			this.checkBoxReoValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxReoValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxLoanPanels = new System.Windows.Forms.GroupBox();
			this.checkBoxLoanPanelsValidation2 = new System.Windows.Forms.CheckBox();
			this.checkBoxLoanPanelsValidation1 = new System.Windows.Forms.CheckBox();
			this.groupBoxRunGroup = new System.Windows.Forms.GroupBox();
			this.checkBoxNotifyUponCompletion = new System.Windows.Forms.CheckBox();
			this.buttonRunSelectedTests = new System.Windows.Forms.Button();
			this.checkBoxRunForRecord = new System.Windows.Forms.CheckBox();
			this.buttonEmailSelectedReports = new System.Windows.Forms.Button();
			this.linkLabelRanorexReportDirectory = new System.Windows.Forms.LinkLabel();
			this.dataGridViewTestConfigurationsExecuted = new System.Windows.Forms.DataGridView();
			this.labelTestConfiguratonsExecuted = new System.Windows.Forms.Label();
			this.groupBoxSelectDeselectButtons = new System.Windows.Forms.GroupBox();
			this.buttonAllSavingsPlanTests = new System.Windows.Forms.Button();
			this.buttonAllLenderLoanInfoTests = new System.Windows.Forms.Button();
			this.buttonAllCreditScoreTests = new System.Windows.Forms.Button();
			this.buttonAllBorrowerInfoTests = new System.Windows.Forms.Button();
			this.buttonAllCrudTests = new System.Windows.Forms.Button();
			this.buttonAllOneUrlaLoanTests = new System.Windows.Forms.Button();
			this.buttonAllDeclarationsTests = new System.Windows.Forms.Button();
			this.buttonAllValidationOneUrlaTests = new System.Windows.Forms.Button();
			this.buttonAllCrudTwoUrlaTests = new System.Windows.Forms.Button();
			this.buttonAllValidationTests = new System.Windows.Forms.Button();
			this.buttonAllAssetsTests = new System.Windows.Forms.Button();
			this.buttonAllCrudOneUrlaTests = new System.Windows.Forms.Button();
			this.buttonAllValidationTwoUrlaTests = new System.Windows.Forms.Button();
			this.buttonAllSubjectPropertyTests = new System.Windows.Forms.Button();
			this.buttonAllQualifyingTheBorrowerTests = new System.Windows.Forms.Button();
			this.buttonAllTwoUrlaLoanTests = new System.Windows.Forms.Button();
			this.buttonSelectAll = new System.Windows.Forms.Button();
			this.buttonDeselectAll = new System.Windows.Forms.Button();
			this.buttonAllLoanPanelTests = new System.Windows.Forms.Button();
			this.buttonAllReoTests = new System.Windows.Forms.Button();
			this.buttonAllLiabilitesTests = new System.Windows.Forms.Button();
			this.buttonAllEmploymentAndIncomeTests = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.labelNumTestsSelected = new System.Windows.Forms.Label();
			this.groupBoxTestMode = new System.Windows.Forms.GroupBox();
			this.radioButtonScenarioTests = new System.Windows.Forms.RadioButton();
			this.radioButtonScreenTests = new System.Windows.Forms.RadioButton();
			this.radioButtonAllMessages = new System.Windows.Forms.RadioButton();
			this.radioButtonAllMessagesSansDebug = new System.Windows.Forms.RadioButton();
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo = new System.Windows.Forms.RadioButton();
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo = new System.Windows.Forms.RadioButton();
			this.groupBoxLogVerbosity = new System.Windows.Forms.GroupBox();
			this.radioButtonAllMessagesSansDebugInfoAndSuccess = new System.Windows.Forms.RadioButton();
			this.radioButtonAllMessagesSansDebugAndInfo = new System.Windows.Forms.RadioButton();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.pictureBoxRunner = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.groupBoxScreenTestCheckboxes.SuspendLayout();
			this.groupBoxSavingsPlan.SuspendLayout();
			this.groupBoxLenderLoanInfo.SuspendLayout();
			this.groupBoxCreditScore.SuspendLayout();
			this.groupBoxEmploymentAndIncomeScreen.SuspendLayout();
			this.groupBoxNavTest.SuspendLayout();
			this.groupBoxAssetsScreen.SuspendLayout();
			this.groupBoxLiabilitiesScreen.SuspendLayout();
			this.groupBoxBorrowerInfo.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBoxSubjectPropertyScreen.SuspendLayout();
			this.groupBoxQualifyingTheBorrower.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBoxLoanPanels.SuspendLayout();
			this.groupBoxRunGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestConfigurationsExecuted)).BeginInit();
			this.groupBoxSelectDeselectButtons.SuspendLayout();
			this.groupBoxTestMode.SuspendLayout();
			this.groupBoxLogVerbosity.SuspendLayout();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunner)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(495, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(482, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pulte Lending Center Automated Test Runner";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBoxScreenTestCheckboxes);
			this.groupBox1.Controls.Add(this.groupBoxRunGroup);
			this.groupBox1.Controls.Add(this.groupBoxSelectDeselectButtons);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBox1.ForeColor = System.Drawing.Color.DarkViolet;
			this.groupBox1.Location = new System.Drawing.Point(14, 125);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1519, 779);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "PLC Screen Tests";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBoxScreenTestCheckboxes
			// 
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxSavingsPlan);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxLenderLoanInfo);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxCreditScore);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxEmploymentAndIncomeScreen);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxNavTest);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxAssetsScreen);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxLiabilitiesScreen);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxBorrowerInfo);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBox3);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxSubjectPropertyScreen);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxQualifyingTheBorrower);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBox4);
			this.groupBoxScreenTestCheckboxes.Controls.Add(this.groupBoxLoanPanels);
			this.groupBoxScreenTestCheckboxes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxScreenTestCheckboxes.Location = new System.Drawing.Point(8, 173);
			this.groupBoxScreenTestCheckboxes.Name = "groupBoxScreenTestCheckboxes";
			this.groupBoxScreenTestCheckboxes.Size = new System.Drawing.Size(1509, 337);
			this.groupBoxScreenTestCheckboxes.TabIndex = 14;
			this.groupBoxScreenTestCheckboxes.TabStop = false;
			this.groupBoxScreenTestCheckboxes.Text = "Screen Test Checkboxes";
			// 
			// groupBoxSavingsPlan
			// 
			this.groupBoxSavingsPlan.Controls.Add(this.checkBoxSavingsPlanCrud1);
			this.groupBoxSavingsPlan.Controls.Add(this.checkBoxSavingsPlanValidation1);
			this.groupBoxSavingsPlan.Location = new System.Drawing.Point(8, 176);
			this.groupBoxSavingsPlan.Name = "groupBoxSavingsPlan";
			this.groupBoxSavingsPlan.Size = new System.Drawing.Size(300, 69);
			this.groupBoxSavingsPlan.TabIndex = 8;
			this.groupBoxSavingsPlan.TabStop = false;
			this.groupBoxSavingsPlan.Text = "Savings Plan Screen";
			// 
			// checkBoxSavingsPlanCrud1
			// 
			this.checkBoxSavingsPlanCrud1.AutoSize = true;
			this.checkBoxSavingsPlanCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxSavingsPlanCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxSavingsPlanCrud1.Location = new System.Drawing.Point(170, 27);
			this.checkBoxSavingsPlanCrud1.Name = "checkBoxSavingsPlanCrud1";
			this.checkBoxSavingsPlanCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxSavingsPlanCrud1.TabIndex = 2;
			this.checkBoxSavingsPlanCrud1.Text = "CRUD One URLA";
			this.checkBoxSavingsPlanCrud1.UseVisualStyleBackColor = true;
			this.checkBoxSavingsPlanCrud1.CheckedChanged += new System.EventHandler(this.checkBoxSavingsPlanCrud1_CheckedChanged);
			// 
			// checkBoxSavingsPlanValidation1
			// 
			this.checkBoxSavingsPlanValidation1.AutoSize = true;
			this.checkBoxSavingsPlanValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxSavingsPlanValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxSavingsPlanValidation1.Location = new System.Drawing.Point(8, 27);
			this.checkBoxSavingsPlanValidation1.Name = "checkBoxSavingsPlanValidation1";
			this.checkBoxSavingsPlanValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxSavingsPlanValidation1.TabIndex = 0;
			this.checkBoxSavingsPlanValidation1.Text = "Validation One URLA";
			this.checkBoxSavingsPlanValidation1.UseVisualStyleBackColor = true;
			this.checkBoxSavingsPlanValidation1.CheckedChanged += new System.EventHandler(this.checkBoxSavingsPlanValidation1_CheckedChanged);
			// 
			// groupBoxLenderLoanInfo
			// 
			this.groupBoxLenderLoanInfo.Controls.Add(this.checkBoxLenderLoanInfoCrud1);
			this.groupBoxLenderLoanInfo.Controls.Add(this.checkBoxLenderLoanInfoValidation1);
			this.groupBoxLenderLoanInfo.Location = new System.Drawing.Point(8, 100);
			this.groupBoxLenderLoanInfo.Name = "groupBoxLenderLoanInfo";
			this.groupBoxLenderLoanInfo.Size = new System.Drawing.Size(300, 69);
			this.groupBoxLenderLoanInfo.TabIndex = 7;
			this.groupBoxLenderLoanInfo.TabStop = false;
			this.groupBoxLenderLoanInfo.Text = "Lender Loan Info Screen";
			// 
			// checkBoxLenderLoanInfoCrud1
			// 
			this.checkBoxLenderLoanInfoCrud1.AutoSize = true;
			this.checkBoxLenderLoanInfoCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLenderLoanInfoCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLenderLoanInfoCrud1.Location = new System.Drawing.Point(170, 28);
			this.checkBoxLenderLoanInfoCrud1.Name = "checkBoxLenderLoanInfoCrud1";
			this.checkBoxLenderLoanInfoCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxLenderLoanInfoCrud1.TabIndex = 2;
			this.checkBoxLenderLoanInfoCrud1.Text = "CRUD One URLA";
			this.checkBoxLenderLoanInfoCrud1.UseVisualStyleBackColor = true;
			this.checkBoxLenderLoanInfoCrud1.CheckedChanged += new System.EventHandler(this.checkBoxLenderLoanInfoCrud1_CheckedChanged);
			// 
			// checkBoxLenderLoanInfoValidation1
			// 
			this.checkBoxLenderLoanInfoValidation1.AutoSize = true;
			this.checkBoxLenderLoanInfoValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLenderLoanInfoValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLenderLoanInfoValidation1.Location = new System.Drawing.Point(8, 28);
			this.checkBoxLenderLoanInfoValidation1.Name = "checkBoxLenderLoanInfoValidation1";
			this.checkBoxLenderLoanInfoValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxLenderLoanInfoValidation1.TabIndex = 0;
			this.checkBoxLenderLoanInfoValidation1.Text = "Validation One URLA";
			this.checkBoxLenderLoanInfoValidation1.UseVisualStyleBackColor = true;
			this.checkBoxLenderLoanInfoValidation1.CheckedChanged += new System.EventHandler(this.checkBoxLenderLoanInfoValidation1_CheckedChanged);
			// 
			// groupBoxCreditScore
			// 
			this.groupBoxCreditScore.Controls.Add(this.checkBoxCreditScoreCrud2);
			this.groupBoxCreditScore.Controls.Add(this.checkBoxCreditScoreCrud1);
			this.groupBoxCreditScore.Controls.Add(this.checkBoxCreditScoreValidation2);
			this.groupBoxCreditScore.Controls.Add(this.checkBoxCreditScoreValidation1);
			this.groupBoxCreditScore.Location = new System.Drawing.Point(620, 24);
			this.groupBoxCreditScore.Name = "groupBoxCreditScore";
			this.groupBoxCreditScore.Size = new System.Drawing.Size(300, 69);
			this.groupBoxCreditScore.TabIndex = 6;
			this.groupBoxCreditScore.TabStop = false;
			this.groupBoxCreditScore.Text = "Credit Score Screen";
			// 
			// checkBoxCreditScoreCrud2
			// 
			this.checkBoxCreditScoreCrud2.AutoSize = true;
			this.checkBoxCreditScoreCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxCreditScoreCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxCreditScoreCrud2.Location = new System.Drawing.Point(170, 41);
			this.checkBoxCreditScoreCrud2.Name = "checkBoxCreditScoreCrud2";
			this.checkBoxCreditScoreCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxCreditScoreCrud2.TabIndex = 3;
			this.checkBoxCreditScoreCrud2.Text = "CRUD Two URLA";
			this.checkBoxCreditScoreCrud2.UseVisualStyleBackColor = true;
			this.checkBoxCreditScoreCrud2.CheckedChanged += new System.EventHandler(this.checkBoxCreditScoreCrud2_CheckedChanged);
			// 
			// checkBoxCreditScoreCrud1
			// 
			this.checkBoxCreditScoreCrud1.AutoSize = true;
			this.checkBoxCreditScoreCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxCreditScoreCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxCreditScoreCrud1.Location = new System.Drawing.Point(170, 24);
			this.checkBoxCreditScoreCrud1.Name = "checkBoxCreditScoreCrud1";
			this.checkBoxCreditScoreCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxCreditScoreCrud1.TabIndex = 2;
			this.checkBoxCreditScoreCrud1.Text = "CRUD One URLA";
			this.checkBoxCreditScoreCrud1.UseVisualStyleBackColor = true;
			this.checkBoxCreditScoreCrud1.CheckedChanged += new System.EventHandler(this.checkBoxCreditScoreCrud1_CheckedChanged);
			// 
			// checkBoxCreditScoreValidation2
			// 
			this.checkBoxCreditScoreValidation2.AutoSize = true;
			this.checkBoxCreditScoreValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxCreditScoreValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxCreditScoreValidation2.Location = new System.Drawing.Point(8, 41);
			this.checkBoxCreditScoreValidation2.Name = "checkBoxCreditScoreValidation2";
			this.checkBoxCreditScoreValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxCreditScoreValidation2.TabIndex = 1;
			this.checkBoxCreditScoreValidation2.Text = "Validation Two URLA";
			this.checkBoxCreditScoreValidation2.UseVisualStyleBackColor = true;
			this.checkBoxCreditScoreValidation2.CheckedChanged += new System.EventHandler(this.checkBoxCreditScoreValidation2_CheckedChanged);
			// 
			// checkBoxCreditScoreValidation1
			// 
			this.checkBoxCreditScoreValidation1.AutoSize = true;
			this.checkBoxCreditScoreValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxCreditScoreValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxCreditScoreValidation1.Location = new System.Drawing.Point(8, 24);
			this.checkBoxCreditScoreValidation1.Name = "checkBoxCreditScoreValidation1";
			this.checkBoxCreditScoreValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxCreditScoreValidation1.TabIndex = 0;
			this.checkBoxCreditScoreValidation1.Text = "Validation One URLA";
			this.checkBoxCreditScoreValidation1.UseVisualStyleBackColor = true;
			this.checkBoxCreditScoreValidation1.CheckedChanged += new System.EventHandler(this.checkBoxCreditScoreValidation1_CheckedChanged);
			// 
			// groupBoxEmploymentAndIncomeScreen
			// 
			this.groupBoxEmploymentAndIncomeScreen.Controls.Add(this.checkBoxEmpAndIncCrud2);
			this.groupBoxEmploymentAndIncomeScreen.Controls.Add(this.checkBoxEmpAndIncCrud1);
			this.groupBoxEmploymentAndIncomeScreen.Controls.Add(this.checkBoxEmploymentAndIncomeValidation2);
			this.groupBoxEmploymentAndIncomeScreen.Controls.Add(this.checkBoxEmploymentAndIncomeValidation1);
			this.groupBoxEmploymentAndIncomeScreen.Location = new System.Drawing.Point(1095, 24);
			this.groupBoxEmploymentAndIncomeScreen.Name = "groupBoxEmploymentAndIncomeScreen";
			this.groupBoxEmploymentAndIncomeScreen.Size = new System.Drawing.Size(300, 69);
			this.groupBoxEmploymentAndIncomeScreen.TabIndex = 3;
			this.groupBoxEmploymentAndIncomeScreen.TabStop = false;
			this.groupBoxEmploymentAndIncomeScreen.Text = "E && I Screen";
			// 
			// checkBoxEmpAndIncCrud2
			// 
			this.checkBoxEmpAndIncCrud2.AutoSize = true;
			this.checkBoxEmpAndIncCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxEmpAndIncCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxEmpAndIncCrud2.Location = new System.Drawing.Point(170, 41);
			this.checkBoxEmpAndIncCrud2.Name = "checkBoxEmpAndIncCrud2";
			this.checkBoxEmpAndIncCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxEmpAndIncCrud2.TabIndex = 5;
			this.checkBoxEmpAndIncCrud2.Text = "CRUD Two URLA";
			this.checkBoxEmpAndIncCrud2.UseVisualStyleBackColor = true;
			this.checkBoxEmpAndIncCrud2.CheckedChanged += new System.EventHandler(this.checkBoxEmpAndIncCrud2_CheckedChanged);
			// 
			// checkBoxEmpAndIncCrud1
			// 
			this.checkBoxEmpAndIncCrud1.AutoSize = true;
			this.checkBoxEmpAndIncCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxEmpAndIncCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxEmpAndIncCrud1.Location = new System.Drawing.Point(170, 24);
			this.checkBoxEmpAndIncCrud1.Name = "checkBoxEmpAndIncCrud1";
			this.checkBoxEmpAndIncCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxEmpAndIncCrud1.TabIndex = 4;
			this.checkBoxEmpAndIncCrud1.Text = "CRUD One URLA";
			this.checkBoxEmpAndIncCrud1.UseVisualStyleBackColor = true;
			this.checkBoxEmpAndIncCrud1.CheckedChanged += new System.EventHandler(this.checkBoxEmpAndIncCrud1_CheckedChanged);
			// 
			// checkBoxEmploymentAndIncomeValidation2
			// 
			this.checkBoxEmploymentAndIncomeValidation2.AutoSize = true;
			this.checkBoxEmploymentAndIncomeValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxEmploymentAndIncomeValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxEmploymentAndIncomeValidation2.Location = new System.Drawing.Point(7, 41);
			this.checkBoxEmploymentAndIncomeValidation2.Name = "checkBoxEmploymentAndIncomeValidation2";
			this.checkBoxEmploymentAndIncomeValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxEmploymentAndIncomeValidation2.TabIndex = 1;
			this.checkBoxEmploymentAndIncomeValidation2.Text = "Validation Two URLA";
			this.checkBoxEmploymentAndIncomeValidation2.UseVisualStyleBackColor = true;
			this.checkBoxEmploymentAndIncomeValidation2.CheckedChanged += new System.EventHandler(this.employmentAndIncomeValidationCheckBox2_CheckedChanged);
			// 
			// checkBoxEmploymentAndIncomeValidation1
			// 
			this.checkBoxEmploymentAndIncomeValidation1.AutoSize = true;
			this.checkBoxEmploymentAndIncomeValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxEmploymentAndIncomeValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxEmploymentAndIncomeValidation1.Location = new System.Drawing.Point(7, 24);
			this.checkBoxEmploymentAndIncomeValidation1.Name = "checkBoxEmploymentAndIncomeValidation1";
			this.checkBoxEmploymentAndIncomeValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxEmploymentAndIncomeValidation1.TabIndex = 0;
			this.checkBoxEmploymentAndIncomeValidation1.Text = "Validation One URLA";
			this.checkBoxEmploymentAndIncomeValidation1.UseVisualStyleBackColor = true;
			this.checkBoxEmploymentAndIncomeValidation1.CheckedChanged += new System.EventHandler(this.employmentAndIncomeValidationCheckBox1_CheckedChanged);
			// 
			// groupBoxNavTest
			// 
			this.groupBoxNavTest.Controls.Add(this.checkBoxNavTest);
			this.groupBoxNavTest.Location = new System.Drawing.Point(789, 99);
			this.groupBoxNavTest.Name = "groupBoxNavTest";
			this.groupBoxNavTest.Size = new System.Drawing.Size(131, 70);
			this.groupBoxNavTest.TabIndex = 6;
			this.groupBoxNavTest.TabStop = false;
			this.groupBoxNavTest.Text = "Navigation Test";
			// 
			// checkBoxNavTest
			// 
			this.checkBoxNavTest.AutoSize = true;
			this.checkBoxNavTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxNavTest.ForeColor = System.Drawing.Color.Black;
			this.checkBoxNavTest.Location = new System.Drawing.Point(9, 28);
			this.checkBoxNavTest.Name = "checkBoxNavTest";
			this.checkBoxNavTest.Size = new System.Drawing.Size(117, 21);
			this.checkBoxNavTest.TabIndex = 1;
			this.checkBoxNavTest.Text = "Navigation Test";
			this.checkBoxNavTest.UseVisualStyleBackColor = true;
			this.checkBoxNavTest.CheckedChanged += new System.EventHandler(this.checkBoxNavTest_CheckedChanged);
			// 
			// groupBoxAssetsScreen
			// 
			this.groupBoxAssetsScreen.Controls.Add(this.checkBoxAssetsCrud2);
			this.groupBoxAssetsScreen.Controls.Add(this.checkBoxAssetsCrud1);
			this.groupBoxAssetsScreen.Controls.Add(this.checkBoxAssetsValidation2);
			this.groupBoxAssetsScreen.Controls.Add(this.checkBoxAssetsValidation1);
			this.groupBoxAssetsScreen.Location = new System.Drawing.Point(8, 24);
			this.groupBoxAssetsScreen.Name = "groupBoxAssetsScreen";
			this.groupBoxAssetsScreen.Size = new System.Drawing.Size(300, 67);
			this.groupBoxAssetsScreen.TabIndex = 0;
			this.groupBoxAssetsScreen.TabStop = false;
			this.groupBoxAssetsScreen.Text = "Assets Screen";
			// 
			// checkBoxAssetsCrud2
			// 
			this.checkBoxAssetsCrud2.AutoSize = true;
			this.checkBoxAssetsCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxAssetsCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxAssetsCrud2.Location = new System.Drawing.Point(170, 41);
			this.checkBoxAssetsCrud2.Name = "checkBoxAssetsCrud2";
			this.checkBoxAssetsCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxAssetsCrud2.TabIndex = 6;
			this.checkBoxAssetsCrud2.Text = "CRUD Two URLA";
			this.checkBoxAssetsCrud2.UseVisualStyleBackColor = true;
			this.checkBoxAssetsCrud2.CheckedChanged += new System.EventHandler(this.checkBoxAssetsCrud2_CheckedChanged);
			// 
			// checkBoxAssetsCrud1
			// 
			this.checkBoxAssetsCrud1.AutoSize = true;
			this.checkBoxAssetsCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxAssetsCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxAssetsCrud1.Location = new System.Drawing.Point(170, 24);
			this.checkBoxAssetsCrud1.Name = "checkBoxAssetsCrud1";
			this.checkBoxAssetsCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxAssetsCrud1.TabIndex = 5;
			this.checkBoxAssetsCrud1.Text = "CRUD One URLA";
			this.checkBoxAssetsCrud1.UseVisualStyleBackColor = true;
			this.checkBoxAssetsCrud1.CheckedChanged += new System.EventHandler(this.checkBoxAssetsCrud1_CheckedChanged);
			// 
			// checkBoxAssetsValidation2
			// 
			this.checkBoxAssetsValidation2.AutoSize = true;
			this.checkBoxAssetsValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxAssetsValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxAssetsValidation2.Location = new System.Drawing.Point(8, 41);
			this.checkBoxAssetsValidation2.Name = "checkBoxAssetsValidation2";
			this.checkBoxAssetsValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxAssetsValidation2.TabIndex = 1;
			this.checkBoxAssetsValidation2.Text = "Validation Two URLA";
			this.checkBoxAssetsValidation2.UseVisualStyleBackColor = true;
			this.checkBoxAssetsValidation2.CheckedChanged += new System.EventHandler(this.assetsValidationCheckBox2_CheckedChanged);
			// 
			// checkBoxAssetsValidation1
			// 
			this.checkBoxAssetsValidation1.AutoSize = true;
			this.checkBoxAssetsValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxAssetsValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxAssetsValidation1.Location = new System.Drawing.Point(8, 24);
			this.checkBoxAssetsValidation1.Name = "checkBoxAssetsValidation1";
			this.checkBoxAssetsValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxAssetsValidation1.TabIndex = 0;
			this.checkBoxAssetsValidation1.Text = "Validation One URLA";
			this.checkBoxAssetsValidation1.UseVisualStyleBackColor = true;
			this.checkBoxAssetsValidation1.CheckedChanged += new System.EventHandler(this.assetsValidationCheckBox1_CheckedChanged);
			// 
			// groupBoxLiabilitiesScreen
			// 
			this.groupBoxLiabilitiesScreen.Controls.Add(this.checkBoxLiabilitiesCrud2);
			this.groupBoxLiabilitiesScreen.Controls.Add(this.checkBoxLiabilitiesCrud1);
			this.groupBoxLiabilitiesScreen.Controls.Add(this.checkBoxLiabilitiesValidation2);
			this.groupBoxLiabilitiesScreen.Controls.Add(this.checkBoxLiabilitiesValidation1);
			this.groupBoxLiabilitiesScreen.Location = new System.Drawing.Point(314, 99);
			this.groupBoxLiabilitiesScreen.Name = "groupBoxLiabilitiesScreen";
			this.groupBoxLiabilitiesScreen.Size = new System.Drawing.Size(300, 69);
			this.groupBoxLiabilitiesScreen.TabIndex = 4;
			this.groupBoxLiabilitiesScreen.TabStop = false;
			this.groupBoxLiabilitiesScreen.Text = "Liabilities Screen";
			// 
			// checkBoxLiabilitiesCrud2
			// 
			this.checkBoxLiabilitiesCrud2.AutoSize = true;
			this.checkBoxLiabilitiesCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLiabilitiesCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLiabilitiesCrud2.Location = new System.Drawing.Point(168, 41);
			this.checkBoxLiabilitiesCrud2.Name = "checkBoxLiabilitiesCrud2";
			this.checkBoxLiabilitiesCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxLiabilitiesCrud2.TabIndex = 3;
			this.checkBoxLiabilitiesCrud2.Text = "CRUD Two URLA";
			this.checkBoxLiabilitiesCrud2.UseVisualStyleBackColor = true;
			this.checkBoxLiabilitiesCrud2.CheckedChanged += new System.EventHandler(this.checkBoxLiabilitiesCrud2_CheckedChanged);
			// 
			// checkBoxLiabilitiesCrud1
			// 
			this.checkBoxLiabilitiesCrud1.AutoSize = true;
			this.checkBoxLiabilitiesCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLiabilitiesCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLiabilitiesCrud1.Location = new System.Drawing.Point(168, 24);
			this.checkBoxLiabilitiesCrud1.Name = "checkBoxLiabilitiesCrud1";
			this.checkBoxLiabilitiesCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxLiabilitiesCrud1.TabIndex = 2;
			this.checkBoxLiabilitiesCrud1.Text = "CRUD One URLA";
			this.checkBoxLiabilitiesCrud1.UseVisualStyleBackColor = true;
			this.checkBoxLiabilitiesCrud1.CheckedChanged += new System.EventHandler(this.checkBoxLiabilitiesCrud1_CheckedChanged);
			// 
			// checkBoxLiabilitiesValidation2
			// 
			this.checkBoxLiabilitiesValidation2.AutoSize = true;
			this.checkBoxLiabilitiesValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLiabilitiesValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLiabilitiesValidation2.Location = new System.Drawing.Point(8, 41);
			this.checkBoxLiabilitiesValidation2.Name = "checkBoxLiabilitiesValidation2";
			this.checkBoxLiabilitiesValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxLiabilitiesValidation2.TabIndex = 1;
			this.checkBoxLiabilitiesValidation2.Text = "Validation Two URLA";
			this.checkBoxLiabilitiesValidation2.UseVisualStyleBackColor = true;
			this.checkBoxLiabilitiesValidation2.CheckedChanged += new System.EventHandler(this.checkBoxLiabilitiesValidation2_CheckedChanged);
			// 
			// checkBoxLiabilitiesValidation1
			// 
			this.checkBoxLiabilitiesValidation1.AutoSize = true;
			this.checkBoxLiabilitiesValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLiabilitiesValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLiabilitiesValidation1.Location = new System.Drawing.Point(8, 24);
			this.checkBoxLiabilitiesValidation1.Name = "checkBoxLiabilitiesValidation1";
			this.checkBoxLiabilitiesValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxLiabilitiesValidation1.TabIndex = 0;
			this.checkBoxLiabilitiesValidation1.Text = "Validation One URLA";
			this.checkBoxLiabilitiesValidation1.UseVisualStyleBackColor = true;
			this.checkBoxLiabilitiesValidation1.CheckedChanged += new System.EventHandler(this.checkBoxLiabilitiesValidation1_CheckedChanged);
			// 
			// groupBoxBorrowerInfo
			// 
			this.groupBoxBorrowerInfo.Controls.Add(this.checkBoxBorrowerInfoCrud2);
			this.groupBoxBorrowerInfo.Controls.Add(this.checkBoxBorrowerInfoCrud1);
			this.groupBoxBorrowerInfo.Controls.Add(this.checkBoxBorrowerInfoValidation2);
			this.groupBoxBorrowerInfo.Controls.Add(this.checkBoxBorrowerInfoValidation1);
			this.groupBoxBorrowerInfo.Location = new System.Drawing.Point(314, 24);
			this.groupBoxBorrowerInfo.Name = "groupBoxBorrowerInfo";
			this.groupBoxBorrowerInfo.Size = new System.Drawing.Size(300, 69);
			this.groupBoxBorrowerInfo.TabIndex = 5;
			this.groupBoxBorrowerInfo.TabStop = false;
			this.groupBoxBorrowerInfo.Text = "Borrower Info Screen";
			// 
			// checkBoxBorrowerInfoCrud2
			// 
			this.checkBoxBorrowerInfoCrud2.AutoSize = true;
			this.checkBoxBorrowerInfoCrud2.Enabled = false;
			this.checkBoxBorrowerInfoCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxBorrowerInfoCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxBorrowerInfoCrud2.Location = new System.Drawing.Point(170, 41);
			this.checkBoxBorrowerInfoCrud2.Name = "checkBoxBorrowerInfoCrud2";
			this.checkBoxBorrowerInfoCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxBorrowerInfoCrud2.TabIndex = 3;
			this.checkBoxBorrowerInfoCrud2.Text = "CRUD Two URLA";
			this.checkBoxBorrowerInfoCrud2.UseVisualStyleBackColor = true;
			this.checkBoxBorrowerInfoCrud2.CheckedChanged += new System.EventHandler(this.checkBoxBorrowerInfoCrud2_CheckedChanged);
			// 
			// checkBoxBorrowerInfoCrud1
			// 
			this.checkBoxBorrowerInfoCrud1.AutoSize = true;
			this.checkBoxBorrowerInfoCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxBorrowerInfoCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxBorrowerInfoCrud1.Location = new System.Drawing.Point(170, 24);
			this.checkBoxBorrowerInfoCrud1.Name = "checkBoxBorrowerInfoCrud1";
			this.checkBoxBorrowerInfoCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxBorrowerInfoCrud1.TabIndex = 2;
			this.checkBoxBorrowerInfoCrud1.Text = "CRUD One URLA";
			this.checkBoxBorrowerInfoCrud1.UseVisualStyleBackColor = true;
			this.checkBoxBorrowerInfoCrud1.CheckedChanged += new System.EventHandler(this.checkBoxBorrowerInfoCrud1_CheckedChanged);
			// 
			// checkBoxBorrowerInfoValidation2
			// 
			this.checkBoxBorrowerInfoValidation2.AutoSize = true;
			this.checkBoxBorrowerInfoValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxBorrowerInfoValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxBorrowerInfoValidation2.Location = new System.Drawing.Point(8, 41);
			this.checkBoxBorrowerInfoValidation2.Name = "checkBoxBorrowerInfoValidation2";
			this.checkBoxBorrowerInfoValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxBorrowerInfoValidation2.TabIndex = 1;
			this.checkBoxBorrowerInfoValidation2.Text = "Validation Two URLA";
			this.checkBoxBorrowerInfoValidation2.UseVisualStyleBackColor = true;
			this.checkBoxBorrowerInfoValidation2.CheckedChanged += new System.EventHandler(this.checkBoxBorrowerInfoValidation2_CheckedChanged);
			// 
			// checkBoxBorrowerInfoValidation1
			// 
			this.checkBoxBorrowerInfoValidation1.AutoSize = true;
			this.checkBoxBorrowerInfoValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxBorrowerInfoValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxBorrowerInfoValidation1.Location = new System.Drawing.Point(8, 24);
			this.checkBoxBorrowerInfoValidation1.Name = "checkBoxBorrowerInfoValidation1";
			this.checkBoxBorrowerInfoValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxBorrowerInfoValidation1.TabIndex = 0;
			this.checkBoxBorrowerInfoValidation1.Text = "Validation One URLA";
			this.checkBoxBorrowerInfoValidation1.UseVisualStyleBackColor = true;
			this.checkBoxBorrowerInfoValidation1.CheckedChanged += new System.EventHandler(this.checkBoxBorrowerInfoValidation1_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.checkBoxDeclarationsValidation2);
			this.groupBox3.Controls.Add(this.checkBoxDeclarationsValidation1);
			this.groupBox3.Location = new System.Drawing.Point(926, 24);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(163, 69);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Declarations Screen";
			// 
			// checkBoxDeclarationsValidation2
			// 
			this.checkBoxDeclarationsValidation2.AutoSize = true;
			this.checkBoxDeclarationsValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxDeclarationsValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxDeclarationsValidation2.Location = new System.Drawing.Point(5, 41);
			this.checkBoxDeclarationsValidation2.Name = "checkBoxDeclarationsValidation2";
			this.checkBoxDeclarationsValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxDeclarationsValidation2.TabIndex = 1;
			this.checkBoxDeclarationsValidation2.Text = "Validation Two URLA";
			this.checkBoxDeclarationsValidation2.UseVisualStyleBackColor = true;
			this.checkBoxDeclarationsValidation2.CheckedChanged += new System.EventHandler(this.declarationsValidationCheckBox2_CheckedChanged);
			// 
			// checkBoxDeclarationsValidation1
			// 
			this.checkBoxDeclarationsValidation1.AutoSize = true;
			this.checkBoxDeclarationsValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxDeclarationsValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxDeclarationsValidation1.Location = new System.Drawing.Point(5, 24);
			this.checkBoxDeclarationsValidation1.Name = "checkBoxDeclarationsValidation1";
			this.checkBoxDeclarationsValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxDeclarationsValidation1.TabIndex = 0;
			this.checkBoxDeclarationsValidation1.Text = "Validation One URLA";
			this.checkBoxDeclarationsValidation1.UseVisualStyleBackColor = true;
			this.checkBoxDeclarationsValidation1.CheckedChanged += new System.EventHandler(this.declarationsValidationCheckBox1_CheckedChanged);
			// 
			// groupBoxSubjectPropertyScreen
			// 
			this.groupBoxSubjectPropertyScreen.Controls.Add(this.checkBoxSubjectPropCrud1);
			this.groupBoxSubjectPropertyScreen.Controls.Add(this.checkBoxSubjectPropCrud2);
			this.groupBoxSubjectPropertyScreen.Controls.Add(this.checkBoxSubjectPropertyValidation2);
			this.groupBoxSubjectPropertyScreen.Controls.Add(this.checkBoxSubjectPropertyValidation1);
			this.groupBoxSubjectPropertyScreen.Location = new System.Drawing.Point(314, 175);
			this.groupBoxSubjectPropertyScreen.Name = "groupBoxSubjectPropertyScreen";
			this.groupBoxSubjectPropertyScreen.Size = new System.Drawing.Size(300, 70);
			this.groupBoxSubjectPropertyScreen.TabIndex = 7;
			this.groupBoxSubjectPropertyScreen.TabStop = false;
			this.groupBoxSubjectPropertyScreen.Text = "Subject Prop Screen";
			// 
			// checkBoxSubjectPropCrud1
			// 
			this.checkBoxSubjectPropCrud1.AutoSize = true;
			this.checkBoxSubjectPropCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxSubjectPropCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxSubjectPropCrud1.Location = new System.Drawing.Point(169, 28);
			this.checkBoxSubjectPropCrud1.Name = "checkBoxSubjectPropCrud1";
			this.checkBoxSubjectPropCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxSubjectPropCrud1.TabIndex = 3;
			this.checkBoxSubjectPropCrud1.Text = "CRUD One URLA";
			this.checkBoxSubjectPropCrud1.UseVisualStyleBackColor = true;
			this.checkBoxSubjectPropCrud1.CheckedChanged += new System.EventHandler(this.checkBoxSubjectPropCrud1_CheckedChanged);
			// 
			// checkBoxSubjectPropCrud2
			// 
			this.checkBoxSubjectPropCrud2.AutoSize = true;
			this.checkBoxSubjectPropCrud2.Enabled = false;
			this.checkBoxSubjectPropCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxSubjectPropCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxSubjectPropCrud2.Location = new System.Drawing.Point(169, 45);
			this.checkBoxSubjectPropCrud2.Name = "checkBoxSubjectPropCrud2";
			this.checkBoxSubjectPropCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxSubjectPropCrud2.TabIndex = 2;
			this.checkBoxSubjectPropCrud2.Text = "CRUD Two URLA";
			this.checkBoxSubjectPropCrud2.UseVisualStyleBackColor = true;
			this.checkBoxSubjectPropCrud2.CheckedChanged += new System.EventHandler(this.checkBoxSubjectPropCrud2_CheckedChanged);
			// 
			// checkBoxSubjectPropertyValidation2
			// 
			this.checkBoxSubjectPropertyValidation2.AutoSize = true;
			this.checkBoxSubjectPropertyValidation2.Enabled = false;
			this.checkBoxSubjectPropertyValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxSubjectPropertyValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxSubjectPropertyValidation2.Location = new System.Drawing.Point(8, 45);
			this.checkBoxSubjectPropertyValidation2.Name = "checkBoxSubjectPropertyValidation2";
			this.checkBoxSubjectPropertyValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxSubjectPropertyValidation2.TabIndex = 1;
			this.checkBoxSubjectPropertyValidation2.Text = "Validation Two URLA";
			this.checkBoxSubjectPropertyValidation2.UseVisualStyleBackColor = true;
			this.checkBoxSubjectPropertyValidation2.CheckedChanged += new System.EventHandler(this.checkBoxSubjectPropertyValidation2_CheckedChanged);
			// 
			// checkBoxSubjectPropertyValidation1
			// 
			this.checkBoxSubjectPropertyValidation1.AutoSize = true;
			this.checkBoxSubjectPropertyValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxSubjectPropertyValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxSubjectPropertyValidation1.Location = new System.Drawing.Point(8, 28);
			this.checkBoxSubjectPropertyValidation1.Name = "checkBoxSubjectPropertyValidation1";
			this.checkBoxSubjectPropertyValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxSubjectPropertyValidation1.TabIndex = 0;
			this.checkBoxSubjectPropertyValidation1.Text = "Validation One URLA";
			this.checkBoxSubjectPropertyValidation1.UseVisualStyleBackColor = true;
			this.checkBoxSubjectPropertyValidation1.CheckedChanged += new System.EventHandler(this.checkBoxSubjectPropertyValidation1_CheckedChanged);
			// 
			// groupBoxQualifyingTheBorrower
			// 
			this.groupBoxQualifyingTheBorrower.Controls.Add(this.checkBoxQualifyingTheBorrowerValidation2);
			this.groupBoxQualifyingTheBorrower.Controls.Add(this.checkBoxQualifyingTheBorrowerValidation1);
			this.groupBoxQualifyingTheBorrower.Location = new System.Drawing.Point(923, 99);
			this.groupBoxQualifyingTheBorrower.Name = "groupBoxQualifyingTheBorrower";
			this.groupBoxQualifyingTheBorrower.Size = new System.Drawing.Size(166, 70);
			this.groupBoxQualifyingTheBorrower.TabIndex = 5;
			this.groupBoxQualifyingTheBorrower.TabStop = false;
			this.groupBoxQualifyingTheBorrower.Text = "Qual the Borr Screen";
			// 
			// checkBoxQualifyingTheBorrowerValidation2
			// 
			this.checkBoxQualifyingTheBorrowerValidation2.AutoSize = true;
			this.checkBoxQualifyingTheBorrowerValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxQualifyingTheBorrowerValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxQualifyingTheBorrowerValidation2.Location = new System.Drawing.Point(8, 45);
			this.checkBoxQualifyingTheBorrowerValidation2.Name = "checkBoxQualifyingTheBorrowerValidation2";
			this.checkBoxQualifyingTheBorrowerValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxQualifyingTheBorrowerValidation2.TabIndex = 1;
			this.checkBoxQualifyingTheBorrowerValidation2.Text = "Validation Two URLA";
			this.checkBoxQualifyingTheBorrowerValidation2.UseVisualStyleBackColor = true;
			this.checkBoxQualifyingTheBorrowerValidation2.CheckedChanged += new System.EventHandler(this.qualifyingTheBorrowerValidationCheckBox2_CheckedChanged);
			// 
			// checkBoxQualifyingTheBorrowerValidation1
			// 
			this.checkBoxQualifyingTheBorrowerValidation1.AutoSize = true;
			this.checkBoxQualifyingTheBorrowerValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxQualifyingTheBorrowerValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxQualifyingTheBorrowerValidation1.Location = new System.Drawing.Point(8, 28);
			this.checkBoxQualifyingTheBorrowerValidation1.Name = "checkBoxQualifyingTheBorrowerValidation1";
			this.checkBoxQualifyingTheBorrowerValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxQualifyingTheBorrowerValidation1.TabIndex = 0;
			this.checkBoxQualifyingTheBorrowerValidation1.Text = "Validation One URLA";
			this.checkBoxQualifyingTheBorrowerValidation1.UseVisualStyleBackColor = true;
			this.checkBoxQualifyingTheBorrowerValidation1.CheckedChanged += new System.EventHandler(this.qualifyingTheBorrowerValidationCheckBox1_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkBoxReoCrud2);
			this.groupBox4.Controls.Add(this.checkBoxReoCrud1);
			this.groupBox4.Controls.Add(this.checkBoxReoValidation2);
			this.groupBox4.Controls.Add(this.checkBoxReoValidation1);
			this.groupBox4.Location = new System.Drawing.Point(1095, 100);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(300, 70);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "REO Screen";
			// 
			// checkBoxReoCrud2
			// 
			this.checkBoxReoCrud2.AutoSize = true;
			this.checkBoxReoCrud2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxReoCrud2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxReoCrud2.Location = new System.Drawing.Point(169, 45);
			this.checkBoxReoCrud2.Name = "checkBoxReoCrud2";
			this.checkBoxReoCrud2.Size = new System.Drawing.Size(123, 21);
			this.checkBoxReoCrud2.TabIndex = 7;
			this.checkBoxReoCrud2.Text = "CRUD Two URLA";
			this.checkBoxReoCrud2.UseVisualStyleBackColor = true;
			this.checkBoxReoCrud2.CheckedChanged += new System.EventHandler(this.checkBoxReoCrud2_CheckedChanged);
			// 
			// checkBoxReoCrud1
			// 
			this.checkBoxReoCrud1.AutoSize = true;
			this.checkBoxReoCrud1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxReoCrud1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxReoCrud1.Location = new System.Drawing.Point(169, 28);
			this.checkBoxReoCrud1.Name = "checkBoxReoCrud1";
			this.checkBoxReoCrud1.Size = new System.Drawing.Size(124, 21);
			this.checkBoxReoCrud1.TabIndex = 6;
			this.checkBoxReoCrud1.Text = "CRUD One URLA";
			this.checkBoxReoCrud1.UseVisualStyleBackColor = true;
			this.checkBoxReoCrud1.CheckedChanged += new System.EventHandler(this.checkBoxReoCrud1_CheckedChanged);
			// 
			// checkBoxReoValidation2
			// 
			this.checkBoxReoValidation2.AutoSize = true;
			this.checkBoxReoValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxReoValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxReoValidation2.Location = new System.Drawing.Point(8, 45);
			this.checkBoxReoValidation2.Name = "checkBoxReoValidation2";
			this.checkBoxReoValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxReoValidation2.TabIndex = 1;
			this.checkBoxReoValidation2.Text = "Validation Two URLA";
			this.checkBoxReoValidation2.UseVisualStyleBackColor = true;
			this.checkBoxReoValidation2.CheckedChanged += new System.EventHandler(this.reoValidationCheckBox2_CheckedChanged);
			// 
			// checkBoxReoValidation1
			// 
			this.checkBoxReoValidation1.AutoSize = true;
			this.checkBoxReoValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxReoValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxReoValidation1.Location = new System.Drawing.Point(8, 28);
			this.checkBoxReoValidation1.Name = "checkBoxReoValidation1";
			this.checkBoxReoValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxReoValidation1.TabIndex = 0;
			this.checkBoxReoValidation1.Text = "Validation One URLA";
			this.checkBoxReoValidation1.UseVisualStyleBackColor = true;
			this.checkBoxReoValidation1.CheckedChanged += new System.EventHandler(this.reoValidationCheckBox1_CheckedChanged);
			// 
			// groupBoxLoanPanels
			// 
			this.groupBoxLoanPanels.Controls.Add(this.checkBoxLoanPanelsValidation2);
			this.groupBoxLoanPanels.Controls.Add(this.checkBoxLoanPanelsValidation1);
			this.groupBoxLoanPanels.Location = new System.Drawing.Point(620, 99);
			this.groupBoxLoanPanels.Name = "groupBoxLoanPanels";
			this.groupBoxLoanPanels.Size = new System.Drawing.Size(162, 70);
			this.groupBoxLoanPanels.TabIndex = 5;
			this.groupBoxLoanPanels.TabStop = false;
			this.groupBoxLoanPanels.Text = "Loan Panels";
			// 
			// checkBoxLoanPanelsValidation2
			// 
			this.checkBoxLoanPanelsValidation2.AutoSize = true;
			this.checkBoxLoanPanelsValidation2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLoanPanelsValidation2.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLoanPanelsValidation2.Location = new System.Drawing.Point(8, 45);
			this.checkBoxLoanPanelsValidation2.Name = "checkBoxLoanPanelsValidation2";
			this.checkBoxLoanPanelsValidation2.Size = new System.Drawing.Size(146, 21);
			this.checkBoxLoanPanelsValidation2.TabIndex = 1;
			this.checkBoxLoanPanelsValidation2.Text = "Validation Two URLA";
			this.checkBoxLoanPanelsValidation2.UseVisualStyleBackColor = true;
			this.checkBoxLoanPanelsValidation2.CheckedChanged += new System.EventHandler(this.checkBoxLoanPanelsValidation2_CheckedChanged);
			// 
			// checkBoxLoanPanelsValidation1
			// 
			this.checkBoxLoanPanelsValidation1.AutoSize = true;
			this.checkBoxLoanPanelsValidation1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBoxLoanPanelsValidation1.ForeColor = System.Drawing.Color.Black;
			this.checkBoxLoanPanelsValidation1.Location = new System.Drawing.Point(8, 28);
			this.checkBoxLoanPanelsValidation1.Name = "checkBoxLoanPanelsValidation1";
			this.checkBoxLoanPanelsValidation1.Size = new System.Drawing.Size(147, 21);
			this.checkBoxLoanPanelsValidation1.TabIndex = 0;
			this.checkBoxLoanPanelsValidation1.Text = "Validation One URLA";
			this.checkBoxLoanPanelsValidation1.UseVisualStyleBackColor = true;
			this.checkBoxLoanPanelsValidation1.CheckedChanged += new System.EventHandler(this.checkBoxLoanPanelsValidation1_CheckedChanged);
			// 
			// groupBoxRunGroup
			// 
			this.groupBoxRunGroup.Controls.Add(this.checkBoxNotifyUponCompletion);
			this.groupBoxRunGroup.Controls.Add(this.buttonRunSelectedTests);
			this.groupBoxRunGroup.Controls.Add(this.checkBoxRunForRecord);
			this.groupBoxRunGroup.Controls.Add(this.buttonEmailSelectedReports);
			this.groupBoxRunGroup.Controls.Add(this.linkLabelRanorexReportDirectory);
			this.groupBoxRunGroup.Controls.Add(this.dataGridViewTestConfigurationsExecuted);
			this.groupBoxRunGroup.Controls.Add(this.labelTestConfiguratonsExecuted);
			this.groupBoxRunGroup.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxRunGroup.Location = new System.Drawing.Point(226, 528);
			this.groupBoxRunGroup.Name = "groupBoxRunGroup";
			this.groupBoxRunGroup.Size = new System.Drawing.Size(1122, 243);
			this.groupBoxRunGroup.TabIndex = 13;
			this.groupBoxRunGroup.TabStop = false;
			this.groupBoxRunGroup.Text = "Run Tests";
			// 
			// checkBoxNotifyUponCompletion
			// 
			this.checkBoxNotifyUponCompletion.AutoSize = true;
			this.checkBoxNotifyUponCompletion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.checkBoxNotifyUponCompletion.ForeColor = System.Drawing.Color.DarkBlue;
			this.checkBoxNotifyUponCompletion.Location = new System.Drawing.Point(898, 24);
			this.checkBoxNotifyUponCompletion.Name = "checkBoxNotifyUponCompletion";
			this.checkBoxNotifyUponCompletion.Size = new System.Drawing.Size(218, 25);
			this.checkBoxNotifyUponCompletion.TabIndex = 13;
			this.checkBoxNotifyUponCompletion.Text = "Notify Upon Completion";
			this.checkBoxNotifyUponCompletion.UseVisualStyleBackColor = true;
			// 
			// buttonRunSelectedTests
			// 
			this.buttonRunSelectedTests.BackColor = System.Drawing.Color.ForestGreen;
			this.buttonRunSelectedTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonRunSelectedTests.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonRunSelectedTests.ForeColor = System.Drawing.Color.White;
			this.buttonRunSelectedTests.Location = new System.Drawing.Point(391, 24);
			this.buttonRunSelectedTests.Name = "buttonRunSelectedTests";
			this.buttonRunSelectedTests.Size = new System.Drawing.Size(375, 50);
			this.buttonRunSelectedTests.TabIndex = 2;
			this.buttonRunSelectedTests.Text = "Run Selected Tests";
			this.buttonRunSelectedTests.UseVisualStyleBackColor = false;
			this.buttonRunSelectedTests.Click += new System.EventHandler(this.buttonRunSelectedTests_Click);
			// 
			// checkBoxRunForRecord
			// 
			this.checkBoxRunForRecord.AutoSize = true;
			this.checkBoxRunForRecord.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.checkBoxRunForRecord.ForeColor = System.Drawing.Color.Red;
			this.checkBoxRunForRecord.Location = new System.Drawing.Point(9, 40);
			this.checkBoxRunForRecord.Name = "checkBoxRunForRecord";
			this.checkBoxRunForRecord.Size = new System.Drawing.Size(189, 34);
			this.checkBoxRunForRecord.TabIndex = 12;
			this.checkBoxRunForRecord.Text = "Run For Record";
			this.checkBoxRunForRecord.UseVisualStyleBackColor = true;
			this.checkBoxRunForRecord.CheckedChanged += new System.EventHandler(this.checkBoxRunForRecord_CheckedChanged);
			// 
			// buttonEmailSelectedReports
			// 
			this.buttonEmailSelectedReports.BackColor = System.Drawing.Color.Violet;
			this.buttonEmailSelectedReports.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonEmailSelectedReports.ForeColor = System.Drawing.Color.Black;
			this.buttonEmailSelectedReports.Location = new System.Drawing.Point(956, 60);
			this.buttonEmailSelectedReports.Name = "buttonEmailSelectedReports";
			this.buttonEmailSelectedReports.Size = new System.Drawing.Size(160, 42);
			this.buttonEmailSelectedReports.TabIndex = 11;
			this.buttonEmailSelectedReports.Text = "Email Selected Reports";
			this.buttonEmailSelectedReports.UseVisualStyleBackColor = false;
			this.buttonEmailSelectedReports.Click += new System.EventHandler(this.buttonEmailSelectedReports_Click);
			// 
			// linkLabelRanorexReportDirectory
			// 
			this.linkLabelRanorexReportDirectory.AutoSize = true;
			this.linkLabelRanorexReportDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.linkLabelRanorexReportDirectory.Location = new System.Drawing.Point(477, 81);
			this.linkLabelRanorexReportDirectory.Name = "linkLabelRanorexReportDirectory";
			this.linkLabelRanorexReportDirectory.Size = new System.Drawing.Size(200, 20);
			this.linkLabelRanorexReportDirectory.TabIndex = 3;
			this.linkLabelRanorexReportDirectory.TabStop = true;
			this.linkLabelRanorexReportDirectory.Text = "Go to Ranorex Reports ";
			this.linkLabelRanorexReportDirectory.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkLabelRanorexReportDirectory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRanorexReportDirectory_LinkClicked);
			// 
			// dataGridViewTestConfigurationsExecuted
			// 
			this.dataGridViewTestConfigurationsExecuted.AllowUserToAddRows = false;
			this.dataGridViewTestConfigurationsExecuted.AllowUserToDeleteRows = false;
			this.dataGridViewTestConfigurationsExecuted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewTestConfigurationsExecuted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTestConfigurationsExecuted.Location = new System.Drawing.Point(9, 105);
			this.dataGridViewTestConfigurationsExecuted.Name = "dataGridViewTestConfigurationsExecuted";
			this.dataGridViewTestConfigurationsExecuted.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.dataGridViewTestConfigurationsExecuted.RowTemplate.Height = 25;
			this.dataGridViewTestConfigurationsExecuted.Size = new System.Drawing.Size(1107, 123);
			this.dataGridViewTestConfigurationsExecuted.TabIndex = 8;
			this.dataGridViewTestConfigurationsExecuted.SelectionChanged += new System.EventHandler(this.dataGridViewTestConfigurationsExecuted_SelectionChanged);
			// 
			// labelTestConfiguratonsExecuted
			// 
			this.labelTestConfiguratonsExecuted.AutoSize = true;
			this.labelTestConfiguratonsExecuted.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelTestConfiguratonsExecuted.ForeColor = System.Drawing.Color.Black;
			this.labelTestConfiguratonsExecuted.Location = new System.Drawing.Point(9, 77);
			this.labelTestConfiguratonsExecuted.Name = "labelTestConfiguratonsExecuted";
			this.labelTestConfiguratonsExecuted.Size = new System.Drawing.Size(295, 25);
			this.labelTestConfiguratonsExecuted.TabIndex = 5;
			this.labelTestConfiguratonsExecuted.Text = "Test Configurations Executed:  ↓";
			// 
			// groupBoxSelectDeselectButtons
			// 
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllSavingsPlanTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllLenderLoanInfoTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllCreditScoreTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllBorrowerInfoTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllCrudTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllOneUrlaLoanTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllDeclarationsTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllValidationOneUrlaTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllCrudTwoUrlaTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllValidationTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllAssetsTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllCrudOneUrlaTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllValidationTwoUrlaTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllSubjectPropertyTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllQualifyingTheBorrowerTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllTwoUrlaLoanTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonSelectAll);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonDeselectAll);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllLoanPanelTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllReoTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllLiabilitesTests);
			this.groupBoxSelectDeselectButtons.Controls.Add(this.buttonAllEmploymentAndIncomeTests);
			this.groupBoxSelectDeselectButtons.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.groupBoxSelectDeselectButtons.Location = new System.Drawing.Point(8, 24);
			this.groupBoxSelectDeselectButtons.Name = "groupBoxSelectDeselectButtons";
			this.groupBoxSelectDeselectButtons.Size = new System.Drawing.Size(1501, 143);
			this.groupBoxSelectDeselectButtons.TabIndex = 13;
			this.groupBoxSelectDeselectButtons.TabStop = false;
			this.groupBoxSelectDeselectButtons.Text = "Select/Deselect Buttons";
			this.groupBoxSelectDeselectButtons.Enter += new System.EventHandler(this.groupBoxSelectDeselectButtons_Enter);
			// 
			// buttonAllSavingsPlanTests
			// 
			this.buttonAllSavingsPlanTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllSavingsPlanTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllSavingsPlanTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllSavingsPlanTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllSavingsPlanTests.Location = new System.Drawing.Point(1261, 51);
			this.buttonAllSavingsPlanTests.Name = "buttonAllSavingsPlanTests";
			this.buttonAllSavingsPlanTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllSavingsPlanTests.TabIndex = 29;
			this.buttonAllSavingsPlanTests.Text = "All Savings Plan Tests";
			this.buttonAllSavingsPlanTests.UseVisualStyleBackColor = false;
			this.buttonAllSavingsPlanTests.Click += new System.EventHandler(this.buttonAllSavingsPlanTests_Click);
			// 
			// buttonAllLenderLoanInfoTests
			// 
			this.buttonAllLenderLoanInfoTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllLenderLoanInfoTests.Enabled = false;
			this.buttonAllLenderLoanInfoTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllLenderLoanInfoTests.Font = new System.Drawing.Font("Segoe UI", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllLenderLoanInfoTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllLenderLoanInfoTests.Location = new System.Drawing.Point(1381, 22);
			this.buttonAllLenderLoanInfoTests.Name = "buttonAllLenderLoanInfoTests";
			this.buttonAllLenderLoanInfoTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllLenderLoanInfoTests.TabIndex = 28;
			this.buttonAllLenderLoanInfoTests.Text = "All Lend Loan Info Tests";
			this.buttonAllLenderLoanInfoTests.UseVisualStyleBackColor = false;
			this.buttonAllLenderLoanInfoTests.Click += new System.EventHandler(this.buttonAllLenderLoanInfoTests_Click);
			// 
			// buttonAllCreditScoreTests
			// 
			this.buttonAllCreditScoreTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllCreditScoreTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllCreditScoreTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllCreditScoreTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllCreditScoreTests.Location = new System.Drawing.Point(1021, 22);
			this.buttonAllCreditScoreTests.Name = "buttonAllCreditScoreTests";
			this.buttonAllCreditScoreTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllCreditScoreTests.TabIndex = 27;
			this.buttonAllCreditScoreTests.Text = "All Credit Score Tests";
			this.buttonAllCreditScoreTests.UseVisualStyleBackColor = false;
			this.buttonAllCreditScoreTests.Click += new System.EventHandler(this.buttonAllCreditScoreTests_Click);
			// 
			// buttonAllBorrowerInfoTests
			// 
			this.buttonAllBorrowerInfoTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllBorrowerInfoTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllBorrowerInfoTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllBorrowerInfoTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllBorrowerInfoTests.Location = new System.Drawing.Point(901, 22);
			this.buttonAllBorrowerInfoTests.Name = "buttonAllBorrowerInfoTests";
			this.buttonAllBorrowerInfoTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllBorrowerInfoTests.TabIndex = 26;
			this.buttonAllBorrowerInfoTests.Text = "All Borr Info Tests";
			this.buttonAllBorrowerInfoTests.UseVisualStyleBackColor = false;
			this.buttonAllBorrowerInfoTests.Click += new System.EventHandler(this.buttonAllBorrowerInfoTests_Click);
			// 
			// buttonAllCrudTests
			// 
			this.buttonAllCrudTests.BackColor = System.Drawing.Color.LightGreen;
			this.buttonAllCrudTests.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllCrudTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllCrudTests.Location = new System.Drawing.Point(336, 53);
			this.buttonAllCrudTests.Name = "buttonAllCrudTests";
			this.buttonAllCrudTests.Size = new System.Drawing.Size(136, 26);
			this.buttonAllCrudTests.TabIndex = 21;
			this.buttonAllCrudTests.Text = "All CRUD Tests";
			this.buttonAllCrudTests.UseVisualStyleBackColor = false;
			this.buttonAllCrudTests.Click += new System.EventHandler(this.buttonAllCrudTests_Click);
			// 
			// buttonAllOneUrlaLoanTests
			// 
			this.buttonAllOneUrlaLoanTests.BackColor = System.Drawing.Color.Bisque;
			this.buttonAllOneUrlaLoanTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllOneUrlaLoanTests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllOneUrlaLoanTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllOneUrlaLoanTests.Location = new System.Drawing.Point(196, 53);
			this.buttonAllOneUrlaLoanTests.Name = "buttonAllOneUrlaLoanTests";
			this.buttonAllOneUrlaLoanTests.Size = new System.Drawing.Size(134, 26);
			this.buttonAllOneUrlaLoanTests.TabIndex = 14;
			this.buttonAllOneUrlaLoanTests.Text = "All One URLA Tests";
			this.buttonAllOneUrlaLoanTests.UseVisualStyleBackColor = false;
			this.buttonAllOneUrlaLoanTests.Click += new System.EventHandler(this.buttonAllOneUrlaLoanTests_Click);
			// 
			// buttonAllDeclarationsTests
			// 
			this.buttonAllDeclarationsTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllDeclarationsTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllDeclarationsTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllDeclarationsTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllDeclarationsTests.Location = new System.Drawing.Point(1141, 22);
			this.buttonAllDeclarationsTests.Name = "buttonAllDeclarationsTests";
			this.buttonAllDeclarationsTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllDeclarationsTests.TabIndex = 9;
			this.buttonAllDeclarationsTests.Text = "All Declarations Tests";
			this.buttonAllDeclarationsTests.UseVisualStyleBackColor = false;
			this.buttonAllDeclarationsTests.Click += new System.EventHandler(this.buttonAllDeclarationsTests_Click);
			// 
			// buttonAllValidationOneUrlaTests
			// 
			this.buttonAllValidationOneUrlaTests.BackColor = System.Drawing.Color.LightGreen;
			this.buttonAllValidationOneUrlaTests.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllValidationOneUrlaTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllValidationOneUrlaTests.Location = new System.Drawing.Point(478, 22);
			this.buttonAllValidationOneUrlaTests.Name = "buttonAllValidationOneUrlaTests";
			this.buttonAllValidationOneUrlaTests.Size = new System.Drawing.Size(153, 25);
			this.buttonAllValidationOneUrlaTests.TabIndex = 19;
			this.buttonAllValidationOneUrlaTests.Text = "All Validation 1 URLA Tests";
			this.buttonAllValidationOneUrlaTests.UseVisualStyleBackColor = false;
			this.buttonAllValidationOneUrlaTests.Click += new System.EventHandler(this.buttonAllValidationOneUrlaTests_Click);
			// 
			// buttonAllCrudTwoUrlaTests
			// 
			this.buttonAllCrudTwoUrlaTests.BackColor = System.Drawing.Color.LightGreen;
			this.buttonAllCrudTwoUrlaTests.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllCrudTwoUrlaTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllCrudTwoUrlaTests.Location = new System.Drawing.Point(639, 53);
			this.buttonAllCrudTwoUrlaTests.Name = "buttonAllCrudTwoUrlaTests";
			this.buttonAllCrudTwoUrlaTests.Size = new System.Drawing.Size(136, 26);
			this.buttonAllCrudTwoUrlaTests.TabIndex = 23;
			this.buttonAllCrudTwoUrlaTests.Text = "All CRUD 2 Urla Tests";
			this.buttonAllCrudTwoUrlaTests.UseVisualStyleBackColor = false;
			this.buttonAllCrudTwoUrlaTests.Click += new System.EventHandler(this.buttonAllCrudTwoUrlaTests_Click);
			// 
			// buttonAllValidationTests
			// 
			this.buttonAllValidationTests.BackColor = System.Drawing.Color.LightGreen;
			this.buttonAllValidationTests.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllValidationTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllValidationTests.Location = new System.Drawing.Point(336, 21);
			this.buttonAllValidationTests.Name = "buttonAllValidationTests";
			this.buttonAllValidationTests.Size = new System.Drawing.Size(136, 26);
			this.buttonAllValidationTests.TabIndex = 18;
			this.buttonAllValidationTests.Text = "All Validation Tests";
			this.buttonAllValidationTests.UseVisualStyleBackColor = false;
			this.buttonAllValidationTests.Click += new System.EventHandler(this.buttonAllValidationTests_Click);
			// 
			// buttonAllAssetsTests
			// 
			this.buttonAllAssetsTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllAssetsTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllAssetsTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllAssetsTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllAssetsTests.Location = new System.Drawing.Point(781, 21);
			this.buttonAllAssetsTests.Name = "buttonAllAssetsTests";
			this.buttonAllAssetsTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllAssetsTests.TabIndex = 8;
			this.buttonAllAssetsTests.Text = "All Assets Tests";
			this.buttonAllAssetsTests.UseVisualStyleBackColor = false;
			this.buttonAllAssetsTests.Click += new System.EventHandler(this.buttonAllAssetsTests_Click);
			// 
			// buttonAllCrudOneUrlaTests
			// 
			this.buttonAllCrudOneUrlaTests.BackColor = System.Drawing.Color.LightGreen;
			this.buttonAllCrudOneUrlaTests.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllCrudOneUrlaTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllCrudOneUrlaTests.Location = new System.Drawing.Point(639, 21);
			this.buttonAllCrudOneUrlaTests.Name = "buttonAllCrudOneUrlaTests";
			this.buttonAllCrudOneUrlaTests.Size = new System.Drawing.Size(136, 26);
			this.buttonAllCrudOneUrlaTests.TabIndex = 22;
			this.buttonAllCrudOneUrlaTests.Text = "All CRUD 1 Urla Tests";
			this.buttonAllCrudOneUrlaTests.UseVisualStyleBackColor = false;
			this.buttonAllCrudOneUrlaTests.Click += new System.EventHandler(this.buttonAllCrudOneUrlaTests_Click);
			// 
			// buttonAllValidationTwoUrlaTests
			// 
			this.buttonAllValidationTwoUrlaTests.BackColor = System.Drawing.Color.LightGreen;
			this.buttonAllValidationTwoUrlaTests.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllValidationTwoUrlaTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllValidationTwoUrlaTests.Location = new System.Drawing.Point(478, 53);
			this.buttonAllValidationTwoUrlaTests.Name = "buttonAllValidationTwoUrlaTests";
			this.buttonAllValidationTwoUrlaTests.Size = new System.Drawing.Size(153, 26);
			this.buttonAllValidationTwoUrlaTests.TabIndex = 20;
			this.buttonAllValidationTwoUrlaTests.Text = "All Validation 2 URLA Tests";
			this.buttonAllValidationTwoUrlaTests.UseVisualStyleBackColor = false;
			this.buttonAllValidationTwoUrlaTests.Click += new System.EventHandler(this.buttonAllValidationTwoUrlaTests_Click);
			// 
			// buttonAllSubjectPropertyTests
			// 
			this.buttonAllSubjectPropertyTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllSubjectPropertyTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllSubjectPropertyTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllSubjectPropertyTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllSubjectPropertyTests.Location = new System.Drawing.Point(1381, 51);
			this.buttonAllSubjectPropertyTests.Name = "buttonAllSubjectPropertyTests";
			this.buttonAllSubjectPropertyTests.Size = new System.Drawing.Size(114, 25);
			this.buttonAllSubjectPropertyTests.TabIndex = 17;
			this.buttonAllSubjectPropertyTests.Text = "All Subject Prop Tests";
			this.buttonAllSubjectPropertyTests.UseVisualStyleBackColor = false;
			this.buttonAllSubjectPropertyTests.Click += new System.EventHandler(this.buttonAllSubjectPropertyTests_Click);
			// 
			// buttonAllQualifyingTheBorrowerTests
			// 
			this.buttonAllQualifyingTheBorrowerTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllQualifyingTheBorrowerTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllQualifyingTheBorrowerTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllQualifyingTheBorrowerTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllQualifyingTheBorrowerTests.Location = new System.Drawing.Point(1021, 51);
			this.buttonAllQualifyingTheBorrowerTests.Name = "buttonAllQualifyingTheBorrowerTests";
			this.buttonAllQualifyingTheBorrowerTests.Size = new System.Drawing.Size(114, 25);
			this.buttonAllQualifyingTheBorrowerTests.TabIndex = 16;
			this.buttonAllQualifyingTheBorrowerTests.Text = "All Qual the Bor Tests";
			this.buttonAllQualifyingTheBorrowerTests.UseVisualStyleBackColor = false;
			this.buttonAllQualifyingTheBorrowerTests.Click += new System.EventHandler(this.buttonAllQualifyingTheBorrowerTests_Click);
			// 
			// buttonAllTwoUrlaLoanTests
			// 
			this.buttonAllTwoUrlaLoanTests.BackColor = System.Drawing.Color.Bisque;
			this.buttonAllTwoUrlaLoanTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllTwoUrlaLoanTests.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllTwoUrlaLoanTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllTwoUrlaLoanTests.Location = new System.Drawing.Point(196, 21);
			this.buttonAllTwoUrlaLoanTests.Name = "buttonAllTwoUrlaLoanTests";
			this.buttonAllTwoUrlaLoanTests.Size = new System.Drawing.Size(134, 26);
			this.buttonAllTwoUrlaLoanTests.TabIndex = 15;
			this.buttonAllTwoUrlaLoanTests.Text = "All Two URLA Tests";
			this.buttonAllTwoUrlaLoanTests.UseVisualStyleBackColor = false;
			this.buttonAllTwoUrlaLoanTests.Click += new System.EventHandler(this.buttonAllTwoUrlaLoanTests_Click);
			// 
			// buttonSelectAll
			// 
			this.buttonSelectAll.BackColor = System.Drawing.Color.MistyRose;
			this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSelectAll.ForeColor = System.Drawing.Color.Black;
			this.buttonSelectAll.Location = new System.Drawing.Point(3, 22);
			this.buttonSelectAll.Name = "buttonSelectAll";
			this.buttonSelectAll.Size = new System.Drawing.Size(187, 25);
			this.buttonSelectAll.TabIndex = 6;
			this.buttonSelectAll.Text = "Select ALL Tests";
			this.buttonSelectAll.UseVisualStyleBackColor = false;
			this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
			// 
			// buttonDeselectAll
			// 
			this.buttonDeselectAll.BackColor = System.Drawing.Color.MistyRose;
			this.buttonDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonDeselectAll.ForeColor = System.Drawing.Color.Black;
			this.buttonDeselectAll.Location = new System.Drawing.Point(3, 53);
			this.buttonDeselectAll.Name = "buttonDeselectAll";
			this.buttonDeselectAll.Size = new System.Drawing.Size(187, 25);
			this.buttonDeselectAll.TabIndex = 7;
			this.buttonDeselectAll.Text = "Deselect ALL Tests";
			this.buttonDeselectAll.UseVisualStyleBackColor = false;
			this.buttonDeselectAll.Click += new System.EventHandler(this.buttonDeselectAll_Click);
			// 
			// buttonAllLoanPanelTests
			// 
			this.buttonAllLoanPanelTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllLoanPanelTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllLoanPanelTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllLoanPanelTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllLoanPanelTests.Location = new System.Drawing.Point(901, 51);
			this.buttonAllLoanPanelTests.Name = "buttonAllLoanPanelTests";
			this.buttonAllLoanPanelTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllLoanPanelTests.TabIndex = 13;
			this.buttonAllLoanPanelTests.Text = "All Loan Panel Tests";
			this.buttonAllLoanPanelTests.UseVisualStyleBackColor = false;
			this.buttonAllLoanPanelTests.Click += new System.EventHandler(this.buttonAllLoanPanelTests_Click);
			// 
			// buttonAllReoTests
			// 
			this.buttonAllReoTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllReoTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllReoTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllReoTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllReoTests.Location = new System.Drawing.Point(1141, 51);
			this.buttonAllReoTests.Name = "buttonAllReoTests";
			this.buttonAllReoTests.Size = new System.Drawing.Size(114, 25);
			this.buttonAllReoTests.TabIndex = 12;
			this.buttonAllReoTests.Text = "All Reo Tests";
			this.buttonAllReoTests.UseVisualStyleBackColor = false;
			this.buttonAllReoTests.Click += new System.EventHandler(this.buttonAllReoTests_Click);
			// 
			// buttonAllLiabilitesTests
			// 
			this.buttonAllLiabilitesTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllLiabilitesTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllLiabilitesTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllLiabilitesTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllLiabilitesTests.Location = new System.Drawing.Point(781, 51);
			this.buttonAllLiabilitesTests.Name = "buttonAllLiabilitesTests";
			this.buttonAllLiabilitesTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllLiabilitesTests.TabIndex = 10;
			this.buttonAllLiabilitesTests.Text = "All Liabilities Tests";
			this.buttonAllLiabilitesTests.UseVisualStyleBackColor = false;
			this.buttonAllLiabilitesTests.Click += new System.EventHandler(this.buttonAllLiabilitesTests_Click);
			// 
			// buttonAllEmploymentAndIncomeTests
			// 
			this.buttonAllEmploymentAndIncomeTests.BackColor = System.Drawing.Color.LightBlue;
			this.buttonAllEmploymentAndIncomeTests.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonAllEmploymentAndIncomeTests.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.buttonAllEmploymentAndIncomeTests.ForeColor = System.Drawing.Color.Black;
			this.buttonAllEmploymentAndIncomeTests.Location = new System.Drawing.Point(1261, 22);
			this.buttonAllEmploymentAndIncomeTests.Name = "buttonAllEmploymentAndIncomeTests";
			this.buttonAllEmploymentAndIncomeTests.Size = new System.Drawing.Size(114, 26);
			this.buttonAllEmploymentAndIncomeTests.TabIndex = 11;
			this.buttonAllEmploymentAndIncomeTests.Text = "All E && I Tests";
			this.buttonAllEmploymentAndIncomeTests.UseVisualStyleBackColor = false;
			this.buttonAllEmploymentAndIncomeTests.Click += new System.EventHandler(this.buttonAllEmploymentAndIncomeTests_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(6, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(283, 30);
			this.label3.TabIndex = 9;
			this.label3.Text = "Number of Tests Selected:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// labelNumTestsSelected
			// 
			this.labelNumTestsSelected.AutoSize = true;
			this.labelNumTestsSelected.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.labelNumTestsSelected.ForeColor = System.Drawing.Color.Red;
			this.labelNumTestsSelected.Location = new System.Drawing.Point(305, 13);
			this.labelNumTestsSelected.Name = "labelNumTestsSelected";
			this.labelNumTestsSelected.Size = new System.Drawing.Size(38, 45);
			this.labelNumTestsSelected.TabIndex = 10;
			this.labelNumTestsSelected.Text = "0";
			// 
			// groupBoxTestMode
			// 
			this.groupBoxTestMode.BackColor = System.Drawing.SystemColors.Info;
			this.groupBoxTestMode.Controls.Add(this.radioButtonScenarioTests);
			this.groupBoxTestMode.Controls.Add(this.radioButtonScreenTests);
			this.groupBoxTestMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBoxTestMode.Location = new System.Drawing.Point(14, 50);
			this.groupBoxTestMode.Name = "groupBoxTestMode";
			this.groupBoxTestMode.Size = new System.Drawing.Size(295, 69);
			this.groupBoxTestMode.TabIndex = 7;
			this.groupBoxTestMode.TabStop = false;
			this.groupBoxTestMode.Text = "Test Mode";
			// 
			// radioButtonScenarioTests
			// 
			this.radioButtonScenarioTests.AutoSize = true;
			this.radioButtonScenarioTests.Enabled = false;
			this.radioButtonScenarioTests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonScenarioTests.Location = new System.Drawing.Point(139, 24);
			this.radioButtonScenarioTests.Name = "radioButtonScenarioTests";
			this.radioButtonScenarioTests.Size = new System.Drawing.Size(135, 25);
			this.radioButtonScenarioTests.TabIndex = 1;
			this.radioButtonScenarioTests.Text = "Scenario Tests";
			this.radioButtonScenarioTests.UseVisualStyleBackColor = true;
			// 
			// radioButtonScreenTests
			// 
			this.radioButtonScreenTests.AutoSize = true;
			this.radioButtonScreenTests.Checked = true;
			this.radioButtonScreenTests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonScreenTests.Location = new System.Drawing.Point(8, 24);
			this.radioButtonScreenTests.Name = "radioButtonScreenTests";
			this.radioButtonScreenTests.Size = new System.Drawing.Size(120, 25);
			this.radioButtonScreenTests.TabIndex = 0;
			this.radioButtonScreenTests.TabStop = true;
			this.radioButtonScreenTests.Text = "Screen Tests";
			this.radioButtonScreenTests.UseVisualStyleBackColor = true;
			// 
			// radioButtonAllMessages
			// 
			this.radioButtonAllMessages.AutoSize = true;
			this.radioButtonAllMessages.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonAllMessages.Location = new System.Drawing.Point(6, 24);
			this.radioButtonAllMessages.Name = "radioButtonAllMessages";
			this.radioButtonAllMessages.Size = new System.Drawing.Size(79, 21);
			this.radioButtonAllMessages.TabIndex = 15;
			this.radioButtonAllMessages.Text = "All Msgs";
			this.radioButtonAllMessages.UseVisualStyleBackColor = true;
			this.radioButtonAllMessages.CheckedChanged += new System.EventHandler(this.radioButtonAllMessages_CheckedChanged);
			// 
			// radioButtonAllMessagesSansDebug
			// 
			this.radioButtonAllMessagesSansDebug.AutoSize = true;
			this.radioButtonAllMessagesSansDebug.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonAllMessagesSansDebug.Location = new System.Drawing.Point(102, 24);
			this.radioButtonAllMessagesSansDebug.Name = "radioButtonAllMessagesSansDebug";
			this.radioButtonAllMessagesSansDebug.Size = new System.Drawing.Size(156, 21);
			this.radioButtonAllMessagesSansDebug.TabIndex = 16;
			this.radioButtonAllMessagesSansDebug.Text = "All Msgs Sans Debug";
			this.radioButtonAllMessagesSansDebug.UseVisualStyleBackColor = true;
			this.radioButtonAllMessagesSansDebug.CheckedChanged += new System.EventHandler(this.radioButtonAllMessagesSansDebug_CheckedChanged);
			// 
			// radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo
			// 
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.AutoSize = true;
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.ForeColor = System.Drawing.Color.Firebrick;
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Location = new System.Drawing.Point(6, 42);
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Name = "radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo";
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Size = new System.Drawing.Size(379, 21);
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.TabIndex = 17;
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.Text = "Only Sections, Warnings, Errors, Failures and Critical Info";
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.UseVisualStyleBackColor = true;
			this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo.CheckedChanged += new System.EventHandler(this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo_CheckedChanged);
			// 
			// radioButtonOnlySectionsErrorsFailuresCriticalInfo
			// 
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.AutoSize = true;
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.Location = new System.Drawing.Point(391, 42);
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.Name = "radioButtonOnlySectionsErrorsFailuresCriticalInfo";
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.Size = new System.Drawing.Size(313, 21);
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.TabIndex = 18;
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.Text = "Only Sections, Errors, Failures and Critical Info";
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.UseVisualStyleBackColor = true;
			this.radioButtonOnlySectionsErrorsFailuresCriticalInfo.CheckedChanged += new System.EventHandler(this.radioButtonOnlySectionsErrorsFailuresCriticalInfo_CheckedChanged);
			// 
			// groupBoxLogVerbosity
			// 
			this.groupBoxLogVerbosity.BackColor = System.Drawing.Color.PowderBlue;
			this.groupBoxLogVerbosity.Controls.Add(this.radioButtonAllMessagesSansDebugInfoAndSuccess);
			this.groupBoxLogVerbosity.Controls.Add(this.radioButtonAllMessagesSansDebugAndInfo);
			this.groupBoxLogVerbosity.Controls.Add(this.radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo);
			this.groupBoxLogVerbosity.Controls.Add(this.radioButtonAllMessagesSansDebug);
			this.groupBoxLogVerbosity.Controls.Add(this.radioButtonOnlySectionsErrorsFailuresCriticalInfo);
			this.groupBoxLogVerbosity.Controls.Add(this.radioButtonAllMessages);
			this.groupBoxLogVerbosity.Location = new System.Drawing.Point(339, 50);
			this.groupBoxLogVerbosity.Name = "groupBoxLogVerbosity";
			this.groupBoxLogVerbosity.Size = new System.Drawing.Size(772, 69);
			this.groupBoxLogVerbosity.TabIndex = 19;
			this.groupBoxLogVerbosity.TabStop = false;
			this.groupBoxLogVerbosity.Text = "Log Verbosity";
			// 
			// radioButtonAllMessagesSansDebugInfoAndSuccess
			// 
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.AutoSize = true;
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.Location = new System.Drawing.Point(504, 24);
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.Name = "radioButtonAllMessagesSansDebugInfoAndSuccess";
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.Size = new System.Drawing.Size(266, 21);
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.TabIndex = 20;
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.Text = "All Msgs Sans Debug, Info and Success";
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.UseVisualStyleBackColor = true;
			this.radioButtonAllMessagesSansDebugInfoAndSuccess.CheckedChanged += new System.EventHandler(this.radioButtonAllMessagesSansDebugInfoAndSuccess_CheckedChanged);
			// 
			// radioButtonAllMessagesSansDebugAndInfo
			// 
			this.radioButtonAllMessagesSansDebugAndInfo.AutoSize = true;
			this.radioButtonAllMessagesSansDebugAndInfo.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.radioButtonAllMessagesSansDebugAndInfo.Location = new System.Drawing.Point(275, 25);
			this.radioButtonAllMessagesSansDebugAndInfo.Name = "radioButtonAllMessagesSansDebugAndInfo";
			this.radioButtonAllMessagesSansDebugAndInfo.Size = new System.Drawing.Size(212, 21);
			this.radioButtonAllMessagesSansDebugAndInfo.TabIndex = 19;
			this.radioButtonAllMessagesSansDebugAndInfo.Text = "All Msgs Sans Debug and Info";
			this.radioButtonAllMessagesSansDebugAndInfo.UseVisualStyleBackColor = true;
			this.radioButtonAllMessagesSansDebugAndInfo.CheckedChanged += new System.EventHandler(this.radioButtonAllMessagesSansDebugAndInfo_CheckedChanged);
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.Wheat;
			this.groupBox6.Controls.Add(this.label3);
			this.groupBox6.Controls.Add(this.labelNumTestsSelected);
			this.groupBox6.Location = new System.Drawing.Point(1145, 50);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(374, 69);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			// 
			// pictureBoxRunner
			// 
			this.pictureBoxRunner.Image = global::PulteLendingCenterAutomatedTestRunner.Properties.Resources.sport;
			this.pictureBoxRunner.InitialImage = global::PulteLendingCenterAutomatedTestRunner.Properties.Resources.sport;
			this.pictureBoxRunner.Location = new System.Drawing.Point(982, 9);
			this.pictureBoxRunner.Name = "pictureBoxRunner";
			this.pictureBoxRunner.Size = new System.Drawing.Size(39, 35);
			this.pictureBoxRunner.TabIndex = 21;
			this.pictureBoxRunner.TabStop = false;
			this.pictureBoxRunner.WaitOnLoad = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1597, 908);
			this.Controls.Add(this.pictureBoxRunner);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBoxLogVerbosity);
			this.Controls.Add(this.groupBoxTestMode);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "Run Selected Tests";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBoxScreenTestCheckboxes.ResumeLayout(false);
			this.groupBoxSavingsPlan.ResumeLayout(false);
			this.groupBoxSavingsPlan.PerformLayout();
			this.groupBoxLenderLoanInfo.ResumeLayout(false);
			this.groupBoxLenderLoanInfo.PerformLayout();
			this.groupBoxCreditScore.ResumeLayout(false);
			this.groupBoxCreditScore.PerformLayout();
			this.groupBoxEmploymentAndIncomeScreen.ResumeLayout(false);
			this.groupBoxEmploymentAndIncomeScreen.PerformLayout();
			this.groupBoxNavTest.ResumeLayout(false);
			this.groupBoxNavTest.PerformLayout();
			this.groupBoxAssetsScreen.ResumeLayout(false);
			this.groupBoxAssetsScreen.PerformLayout();
			this.groupBoxLiabilitiesScreen.ResumeLayout(false);
			this.groupBoxLiabilitiesScreen.PerformLayout();
			this.groupBoxBorrowerInfo.ResumeLayout(false);
			this.groupBoxBorrowerInfo.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBoxSubjectPropertyScreen.ResumeLayout(false);
			this.groupBoxSubjectPropertyScreen.PerformLayout();
			this.groupBoxQualifyingTheBorrower.ResumeLayout(false);
			this.groupBoxQualifyingTheBorrower.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBoxLoanPanels.ResumeLayout(false);
			this.groupBoxLoanPanels.PerformLayout();
			this.groupBoxRunGroup.ResumeLayout(false);
			this.groupBoxRunGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTestConfigurationsExecuted)).EndInit();
			this.groupBoxSelectDeselectButtons.ResumeLayout(false);
			this.groupBoxTestMode.ResumeLayout(false);
			this.groupBoxTestMode.PerformLayout();
			this.groupBoxLogVerbosity.ResumeLayout(false);
			this.groupBoxLogVerbosity.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRunner)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxAssetsScreen;
        private System.Windows.Forms.CheckBox checkBoxAssetsValidation1;
        private System.Windows.Forms.GroupBox groupBoxQualifyingTheBorrower;
        private System.Windows.Forms.CheckBox checkBoxQualifyingTheBorrowerValidation1;
        private System.Windows.Forms.GroupBox groupBoxEmploymentAndIncomeScreen;
        private System.Windows.Forms.CheckBox checkBoxEmploymentAndIncomeValidation2;
        private System.Windows.Forms.CheckBox checkBoxEmploymentAndIncomeValidation1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxDeclarationsValidation2;
        private System.Windows.Forms.CheckBox checkBoxDeclarationsValidation1;
        private System.Windows.Forms.CheckBox checkBoxAssetsValidation2;
        private System.Windows.Forms.Button buttonRunSelectedTests;
        private System.Windows.Forms.LinkLabel linkLabelRanorexReportDirectory;
        private System.Windows.Forms.Label labelTestConfiguratonsExecuted;
        private System.Windows.Forms.CheckBox checkBoxQualifyingTheBorrowerValidation2;
        private System.Windows.Forms.GroupBox groupBoxTestMode;
        private System.Windows.Forms.RadioButton radioButtonScenarioTests;
        private System.Windows.Forms.RadioButton radioButtonScreenTests;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonAllEmploymentAndIncomeTests;
        private System.Windows.Forms.Button buttonAllLiabilitesTests;
        private System.Windows.Forms.Button buttonAllDeclarationsTests;
        private System.Windows.Forms.Button buttonAllAssetsTests;
        private System.Windows.Forms.GroupBox groupBoxSelectDeselectButtons;
        private System.Windows.Forms.Button buttonAllReoTests;
        private System.Windows.Forms.GroupBox groupBoxLoanPanels;
        private System.Windows.Forms.CheckBox checkBoxLoanPanelsValidation2;
        private System.Windows.Forms.CheckBox checkBoxLoanPanelsValidation1;
        private System.Windows.Forms.Button buttonAllLoanPanelTests;
        private System.Windows.Forms.GroupBox groupBoxLiabilitiesScreen;
        private System.Windows.Forms.CheckBox checkBoxLiabilitiesValidation2;
        private System.Windows.Forms.CheckBox checkBoxLiabilitiesValidation1;
        private System.Windows.Forms.Button buttonAllOneUrlaLoanTests;
        private System.Windows.Forms.DataGridView dataGridViewTestConfigurationsExecuted;
        private System.Windows.Forms.Button buttonAllTwoUrlaLoanTests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNumTestsSelected;
        private System.Windows.Forms.Button buttonEmailSelectedReports;
        private System.Windows.Forms.GroupBox groupBoxRunGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxReoValidation2;
        private System.Windows.Forms.CheckBox checkBoxReoValidation1;
        private System.Windows.Forms.Button buttonAllQualifyingTheBorrowerTests;
        private System.Windows.Forms.GroupBox groupBoxSubjectPropertyScreen;
        private System.Windows.Forms.CheckBox checkBoxSubjectPropertyValidation2;
        private System.Windows.Forms.CheckBox checkBoxSubjectPropertyValidation1;
        private System.Windows.Forms.Button buttonAllSubjectPropertyTests;
        private System.Windows.Forms.CheckBox checkBoxLiabilitiesCrud2;
        private System.Windows.Forms.CheckBox checkBoxLiabilitiesCrud1;
        private System.Windows.Forms.Button buttonAllValidationTests;
        private System.Windows.Forms.Button buttonAllValidationOneUrlaTests;
        private System.Windows.Forms.Button buttonAllCrudTwoUrlaTests;
        private System.Windows.Forms.Button buttonAllCrudOneUrlaTests;
        private System.Windows.Forms.Button buttonAllCrudTests;
        private System.Windows.Forms.Button buttonAllValidationTwoUrlaTests;
        private System.Windows.Forms.RadioButton radioButtonAllMessages;
        private System.Windows.Forms.RadioButton radioButtonAllMessagesSansDebug;
        private System.Windows.Forms.RadioButton radioButtonOnlySectionsWarningsErrorsFailuesCriticalInfo;
        private System.Windows.Forms.RadioButton radioButtonOnlySectionsErrorsFailuresCriticalInfo;
        private System.Windows.Forms.GroupBox groupBoxLogVerbosity;
        private System.Windows.Forms.GroupBox groupBoxBorrowerInfo;
        private System.Windows.Forms.CheckBox checkBoxBorrowerInfoCrud2;
        private System.Windows.Forms.CheckBox checkBoxBorrowerInfoCrud1;
        private System.Windows.Forms.CheckBox checkBoxBorrowerInfoValidation2;
        private System.Windows.Forms.CheckBox checkBoxBorrowerInfoValidation1;
        private System.Windows.Forms.Button buttonAllBorrowerInfoTests;
        private System.Windows.Forms.CheckBox checkBoxRunForRecord;
        private System.Windows.Forms.RadioButton radioButtonAllMessagesSansDebugAndInfo;
        private System.Windows.Forms.CheckBox checkBoxSubjectPropCrud1;
        private System.Windows.Forms.CheckBox checkBoxSubjectPropCrud2;
        private System.Windows.Forms.CheckBox checkBoxAssetsCrud2;
        private System.Windows.Forms.CheckBox checkBoxAssetsCrud1;
        private System.Windows.Forms.CheckBox checkBoxEmpAndIncCrud2;
        private System.Windows.Forms.CheckBox checkBoxEmpAndIncCrud1;
        private System.Windows.Forms.CheckBox checkBoxReoCrud2;
        private System.Windows.Forms.CheckBox checkBoxReoCrud1;
        private System.Windows.Forms.GroupBox groupBoxNavTest;
        private System.Windows.Forms.CheckBox checkBoxNavTest;
        private System.Windows.Forms.GroupBox groupBoxScreenTestCheckboxes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButtonAllMessagesSansDebugInfoAndSuccess;
        private System.Windows.Forms.CheckBox checkBoxNotifyUponCompletion;
        private System.Windows.Forms.GroupBox groupBoxSavingsPlan;
        private System.Windows.Forms.CheckBox checkBoxSavingsPlanCrud1;
        private System.Windows.Forms.CheckBox checkBoxSavingsPlanValidation1;
        private System.Windows.Forms.GroupBox groupBoxLenderLoanInfo;
        private System.Windows.Forms.CheckBox checkBoxLenderLoanInfoCrud1;
        private System.Windows.Forms.CheckBox checkBoxLenderLoanInfoValidation1;
        private System.Windows.Forms.GroupBox groupBoxCreditScore;
        private System.Windows.Forms.CheckBox checkBoxCreditScoreCrud2;
        private System.Windows.Forms.CheckBox checkBoxCreditScoreCrud1;
        private System.Windows.Forms.CheckBox checkBoxCreditScoreValidation2;
        private System.Windows.Forms.CheckBox checkBoxCreditScoreValidation1;
        private System.Windows.Forms.Button buttonAllLenderLoanInfoTests;
        private System.Windows.Forms.Button buttonAllCreditScoreTests;
        private System.Windows.Forms.Button buttonAllSavingsPlanTests;
        private System.Windows.Forms.PictureBox pictureBoxRunner;
    }
}

