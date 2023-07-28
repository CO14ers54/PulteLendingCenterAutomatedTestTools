using Microsoft.Extensions.Configuration;
using PlcScheduledTestRunner.Dtos.SettingsDtos;
using PlcScheduledTestRunner.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PlcScheduledTestRunner
{
    public class EmailNotification
    {

        public void SendEmail(string message)
        {
            foreach (EmailDto emailDto in Settings.Instance.SettingsDto.EmailDtos)
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

      /*
        private void Send(NotificationView view)
        {
            try
            {
                var notificationsMgtGateway = CreateNotificationsMgtGateway();
                var command = CreateNotificationCommand(view);
                notificationsMgtGateway.ProcessBroadcastNotification(command);
            }
            catch (Exception ex)
            {
                //DBLogger.Instance.WriteLogMessage("AutomationTestRunner", "Email Functionality", null, $"An exception occurred in trying to send email to '{view.RecipientFullName}'.  The error was '{ex.Message}'.", LogMessageTypes.ERROR.ToString());
                //throw;
            }
        }

        private INotificationsMgtGateway CreateNotificationsMgtGateway()
        {
            // Mike - Here are the configurations available.  I'll refactor this code to the preferred way (which I guess will be the IConfuration way instead of
            // the way I origionally implmented.  Anyway, are we perhaps missing a particular configuration setting?  Are we invoking the right method in the
            // gateway?  Just some thoughts...

            var configuration = PlcScheduledTestRunner.Configuration;
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
        public string GetMessageContent(string testsRun, string reportName)
        {
            string message = $"Scheduled automated test execution of '{testsRun}' Tests has completed in the '{Settings.Instance.SettingsDto.AppSettingsDto.Environment.ToUpper()}' environmeent.\r\n\r\n";
            message += Environment.NewLine;
            message += Environment.NewLine;
            message += $"The report is: {reportName}";


            return message;
        }
    }
}
