
namespace PulteLendingCenterAutomatedTestRunner
{
    partial class EmailMessageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSecondary = new System.Windows.Forms.CheckBox();
            this.checkBoxPrimary = new System.Windows.Forms.CheckBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(403, 272);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox1.Controls.Add(this.checkBoxSecondary);
            this.groupBox1.Controls.Add(this.checkBoxPrimary);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipients";
            // 
            // checkBoxSecondary
            // 
            this.checkBoxSecondary.AutoSize = true;
            this.checkBoxSecondary.Location = new System.Drawing.Point(140, 23);
            this.checkBoxSecondary.Name = "checkBoxSecondary";
            this.checkBoxSecondary.Size = new System.Drawing.Size(83, 19);
            this.checkBoxSecondary.TabIndex = 1;
            this.checkBoxSecondary.Text = "checkBox1";
            this.checkBoxSecondary.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrimary
            // 
            this.checkBoxPrimary.AutoSize = true;
            this.checkBoxPrimary.Checked = true;
            this.checkBoxPrimary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPrimary.Location = new System.Drawing.Point(16, 23);
            this.checkBoxPrimary.Name = "checkBoxPrimary";
            this.checkBoxPrimary.Size = new System.Drawing.Size(83, 19);
            this.checkBoxPrimary.TabIndex = 0;
            this.checkBoxPrimary.Text = "checkBox1";
            this.checkBoxPrimary.UseVisualStyleBackColor = true;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 79);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(53, 15);
            this.labelMessage.TabIndex = 3;
            this.labelMessage.Text = "Message";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(12, 97);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(955, 169);
            this.richTextBoxMessage.TabIndex = 4;
            this.richTextBoxMessage.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(500, 272);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // EmailMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 307);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOk);
            this.Name = "EmailMessageForm";
            this.Text = "Enter Email Message...";
            this.Load += new System.EventHandler(this.EmailMessageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox checkBoxSecondary;
        public System.Windows.Forms.CheckBox checkBoxPrimary;
        private System.Windows.Forms.Label labelMessage;
        public System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Button buttonCancel;
    }
}