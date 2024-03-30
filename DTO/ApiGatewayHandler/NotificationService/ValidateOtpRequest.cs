

namespace Api.NotificationService
{
    public class ValidateOtpRequest
    {
        public int Otp {  get; set; }
        public string? CommunicationMethod { get; set;}
    }
}
