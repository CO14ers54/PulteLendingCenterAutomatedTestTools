using Microsoft.Extensions.Configuration;
using PulteLendingCenterAutomatedTestRunner.Dtos.SettingsDtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PulteLendingCenterAutomatedTestRunner
{
    public partial class EmailMessageForm : Form
    {
        IConfiguration _configuration;
        public EmailMessageForm()
        {
            InitializeComponent();

            _configuration = Program.Configuration;
        }

        private void EmailMessageForm_Load(object sender, EventArgs e)
        {
            var primary = _configuration.GetSection("EmailDtos:0").Get<EmailDto>();
            var secondary = _configuration.GetSection("EmailDtos:1").Get<EmailDto>();

            checkBoxPrimary.Text = primary.RecipientFullName;
            checkBoxSecondary.Text = secondary.RecipientFullName;

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (checkBoxPrimary.Checked == false && checkBoxSecondary.Checked == false)
            {
                MessageBox.Show("You must select at least email recipient.", "Automated Test Runner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
