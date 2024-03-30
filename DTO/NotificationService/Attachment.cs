namespace DTO.NotificationService
{
    public class Attachment
    {
        public required string FileName { get; set; }
        public required byte[] FileContent { get; set; }
        public required string MediaType { get; set; }
    }
}