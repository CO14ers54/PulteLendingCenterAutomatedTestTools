
namespace MyLoanToEmpowerLoanGenerator
{
    partial class MyLoanEmpowerLoanGeneratorForm
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
            this.labelLoansToGenerate = new System.Windows.Forms.Label();
            this.textNumLoansToGenerate = new System.Windows.Forms.TextBox();
            this.generateLoansButton = new System.Windows.Forms.Button();
            this.textBoxProcessing = new System.Windows.Forms.RichTextBox();
            this.comboBoxLoanType = new System.Windows.Forms.ComboBox();
            this.buttonSaveOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoansToGenerate
            // 
            this.labelLoansToGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLoansToGenerate.Location = new System.Drawing.Point(557, 67);
            this.labelLoansToGenerate.Name = "labelLoansToGenerate";
            this.labelLoansToGenerate.Size = new System.Drawing.Size(454, 23);
            this.labelLoansToGenerate.TabIndex = 3;
            this.labelLoansToGenerate.Text = "Loans To Generate Label";
            // 
            // textNumLoansToGenerate
            // 
            this.textNumLoansToGenerate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNumLoansToGenerate.Location = new System.Drawing.Point(1017, 64);
            this.textNumLoansToGenerate.Name = "textNumLoansToGenerate";
            this.textNumLoansToGenerate.Size = new System.Drawing.Size(47, 27);
            this.textNumLoansToGenerate.TabIndex = 4;
            this.textNumLoansToGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // generateLoansButton
            // 
            this.generateLoansButton.BackColor = System.Drawing.Color.LawnGreen;
            this.generateLoansButton.FlatAppearance.BorderSize = 3;
            this.generateLoansButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateLoansButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generateLoansButton.Location = new System.Drawing.Point(813, 111);
            this.generateLoansButton.Name = "generateLoansButton";
            this.generateLoansButton.Size = new System.Drawing.Size(251, 47);
            this.generateLoansButton.TabIndex = 6;
            this.generateLoansButton.Text = "Generate Loan(s)";
            this.generateLoansButton.UseVisualStyleBackColor = false;
            this.generateLoansButton.Click += new System.EventHandler(this.generateLoansButton_Click);
            // 
            // textBoxProcessing
            // 
            this.textBoxProcessing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxProcessing.Location = new System.Drawing.Point(12, 178);
            this.textBoxProcessing.Name = "textBoxProcessing";
            this.textBoxProcessing.ReadOnly = true;
            this.textBoxProcessing.Size = new System.Drawing.Size(1052, 308);
            this.textBoxProcessing.TabIndex = 7;
            this.textBoxProcessing.Text = "";
            // 
            // comboBoxLoanType
            // 
            this.comboBoxLoanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoanType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLoanType.FormattingEnabled = true;
            this.comboBoxLoanType.ItemHeight = 19;
            this.comboBoxLoanType.Location = new System.Drawing.Point(12, 17);
            this.comboBoxLoanType.MaxDropDownItems = 20;
            this.comboBoxLoanType.Name = "comboBoxLoanType";
            this.comboBoxLoanType.Size = new System.Drawing.Size(1052, 27);
            this.comboBoxLoanType.TabIndex = 8;
            this.comboBoxLoanType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoanType_SelectedIndexChanged);
            // 
            // buttonSaveOutput
            // 
            this.buttonSaveOutput.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveOutput.Location = new System.Drawing.Point(813, 506);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(251, 47);
            this.buttonSaveOutput.TabIndex = 9;
            this.buttonSaveOutput.Text = "Save Output...";
            this.buttonSaveOutput.UseVisualStyleBackColor = true;
            this.buttonSaveOutput.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // MyLoanEmpowerLoanGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 571);
            this.Controls.Add(this.buttonSaveOutput);
            this.Controls.Add(this.comboBoxLoanType);
            this.Controls.Add(this.textBoxProcessing);
            this.Controls.Add(this.generateLoansButton);
            this.Controls.Add(this.textNumLoansToGenerate);
            this.Controls.Add(this.labelLoansToGenerate);
            this.Name = "MyLoanEmpowerLoanGeneratorForm";
            this.Text = "MyLoan to Empower Loan Generator";
            this.Load += new System.EventHandler(this.MyLoanEmpowerLoanGeneratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLoansToGenerate;
        private System.Windows.Forms.TextBox textNumLoansToGenerate;
        private System.Windows.Forms.Button generateLoansButton;
        private System.Windows.Forms.RichTextBox textBoxProcessing;
        private System.Windows.Forms.ComboBox comboBoxLoanType;
        private System.Windows.Forms.Button buttonSaveOutput;
    }
}

