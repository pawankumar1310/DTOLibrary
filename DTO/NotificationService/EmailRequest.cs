namespace DTO.NotificationService
{
    public class EmailRequest
    {
        public required List<string> To { get; set; }
        public List<string>? Cc { get; set; }
        public List<string>? Bcc { get; set; }
        public string? Subject { get; set; }
        public object? Body { get; set; }
        public required bool IsBodyHtml { get; set; }
        public List<Attachment>? Attachments { get; set; }

        public EmailRequest()
        {
            To = new List<string>();
            Cc = new List<string>();
            Bcc = new List<string>();
            Attachments = new List<Attachment>();
        }
    }
}