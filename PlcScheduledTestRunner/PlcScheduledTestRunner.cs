using log4net.Repository.Hierarchy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using PlcScheduledTestRunner.Dtos.SettingsDtos;
using PlcScheduledTestRunner.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PlcScheduledTestRunner
{
    class PlcScheduledTestRunner
    {
        public static IConfiguration Configuration;

        static void Main(string[] args)
        {
            string testsToRun = string.Empty;
            string environment = string.Empty;
            bool runForRecord = false;

            if (args != null && args.Length == 3)
            {
                testsToRun = args[0];
                environment = args[1];
                runForRecord = Convert.ToBoolean(args[2]);
            }

            // Must set the current directory to the PLC Scheduled Test Runner project output directory to get our settings
            string plcScheduledTestRunnerOutputDir;
            if (environment.ToUpper().Equals("DEV"))
                plcScheduledTestRunnerOutputDir = "C:\\Develop\\PulteLendingCenterTestAutomationTools\\PlcScheduledTestRunner\\bin\\Debug\\netcoreapp3.1";
            else
                plcScheduledTestRunnerOutputDir = "C:\\Program Files\\Pulte\\Pulte.LendingCenter.PlcScheduledTestRunner";
            Directory.SetCurrentDirectory(plcScheduledTestRunnerOutputDir);

            Configuration = new ConfigurationBuilder()
              .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
              .Build();

            var mySettings = Settings.Instance.SettingsDto;


            string executableRootPath;
            if (environment.ToUpper().Equals("DEV"))
                executableRootPath = "C:\\Develop\\PulteLendingCenterIntegrationTests\\Ranorex\\PulteLendingCenterIntegrationTests\\bin\\Debug";
            else
                executableRootPath = "C:\\Program Files\\Pulte\\Pulte.LendingCenter.IntegrationTests";

            // Must set the current directory to the PLC Intergration Tests project output directory!!!!!
            Directory.SetCurrentDirectory(executableRootPath);

            string runForRecordText;
            if (runForRecord)
                runForRecordText = "RUN_FOR_RECORD_";
            else
                runForRecordText = string.Empty;

            string processName = "PulteLendingCenterIntegrationTests.exe";
            string ranorexArgs = string.Empty;
            string reportName = string.Empty;
            switch (testsToRun.ToUpper())
            {
                case "VALIDATION":
                    reportName = $"{ runForRecordText}PLC_TA_RunAllValidationTests{ DateTime.Now.ToString("_yyyyMMdd_HHmmss")}";
                    //ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunAllValidationTests /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=OnlySectionsWarningsErrorsFailuresCriticalInfo";
                    ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunAllValidationTests /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=AllMessages";
                    break;
                case "CRUD":
                    reportName = $"{ runForRecordText}PLC_TA_RunAllCrudTests{ DateTime.Now.ToString("_yyyyMMdd_HHmmss")}";
                    //ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunAllCrudTests /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=OnlySectionsWarningsErrorsFailuresCriticalInfo";
                    ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunAllCrudTests /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=AllMessages";
                    break;
                case "ALL":
                    reportName = $"{ runForRecordText}PLC_TA_RunAllTests{ DateTime.Now.ToString("_yyyyMMdd_HHmmss")}";
                    //ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunAllTests /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=OnlySectionsWarningsErrorsFailuresCriticalInfo";
                    ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunAllTests /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=AllMessages";
                    break;
                case "NAVTEST":
                    reportName = $"{ runForRecordText}PLC_TA_RunNavigationTest{ DateTime.Now.ToString("_yyyyMMdd_HHmmss")}";
                    //ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunNavigationTest /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=OnlySectionsWarningsErrorsFailuresCriticalInfo";
                    ranorexArgs = $"/ts:PulteLendingCenterScreenTestSuite.rxtst /rc:RunNavigationTest /reportlevel:Debug /rf:Reports\\{reportName} /pa:LogVerbosity=AllMessages";
                    break;
            }

            ProcessStartInfo processInfo = new ProcessStartInfo(executableRootPath + "\\" + processName, ranorexArgs)
            {
                RedirectStandardError = true
            };
            Process process = Process.Start(processInfo);
            process.WaitForExit();
            int exitCode = process.ExitCode;

            process.Close();

            // Must set the current directory to the PLC Scheduled Test Runner project output directory to get our settings
            if (environment.ToUpper().Equals("DEV"))
                plcScheduledTestRunnerOutputDir = "C:\\Develop\\PulteLendingCenterTestAutomationTools\\PlcScheduledTestRunner\\bin\\Debug\\netcoreapp3.1";
            else
                plcScheduledTestRunnerOutputDir = "C:\\Program Files\\Pulte\\Pulte.LendingCenter.PlcScheduledTestRunner";
            Directory.SetCurrentDirectory(plcScheduledTestRunnerOutputDir);

            try {
				EmailNotification email = new EmailNotification();
				string message = email.GetMessageContent(testsToRun, reportName);
				email.SendEmail(message);
			}
            catch(Exception ex) {
				
			}

		}

        private void SendEmail(string message)
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
        private string GetMessageContent(string testsRun, string reportName)
        {
            string message = $"Scheduled automated test execution of '{testsRun}' Tests has completed in the '{Settings.Instance.SettingsDto.AppSettingsDto.Environment.ToUpper()}' environmeent.\r\n\r\n";
            message += Environment.NewLine;
            message += Environment.NewLine;
            message += $"The report is: {reportName}";


            return message;
        }
    }
}
