

namespace DTO.NotificationService
{
    public class InsertOrUpdateOTPRequest
    {
        public int Otp {  get; set; }
        public string? CommunicationMethod { get; set;}
        public string? CountryID  { get; set;}
    }
}
