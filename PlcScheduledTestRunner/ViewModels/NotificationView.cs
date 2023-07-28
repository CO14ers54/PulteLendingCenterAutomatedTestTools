namespace PlcScheduledTestRunner.ViewModels
{
    public class NotificationView
    {
        public string SenderFullName { get; set; }
        public string SenderFirstName { get; set; }
        public string SenderEmail { get; set; }
        public string RecipientFullName { get; set; }
        public string RecipientFirstName { get; set; }
        public string RecipientEmail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public override string ToString()
        {
            return ($"SenderFullName: {SenderFullName}, SenderFirstName: {SenderFirstName}, " +
                $"SenderEmail: {SenderEmail}, RecipientFullName: {RecipientFullName}, RecipientFirstName: {RecipientFirstName}" +
                $"Subject: {Subject}");
        }
    }
}
