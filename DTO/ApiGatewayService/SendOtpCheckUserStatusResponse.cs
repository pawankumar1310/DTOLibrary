

namespace DTO.ApiGatewayService
{
    public class SendOtpCheckUserStatusResponse
    {
        public required bool IsSuccess { get; set; }

        public bool UserNAmeStatus { get; set; }
        public bool IsOtp { get; set; }
        public bool IsOtpAvailable { get; set; }
        public bool IsPasswordAvailable { get; set; }
    }
}
