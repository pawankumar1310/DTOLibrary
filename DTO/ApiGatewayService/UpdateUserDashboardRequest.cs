
using Api.UserService;

namespace DTO.ApiGatewayService
{
    public class UpdateUserDashboardRequest
    {
        public string? UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CountryID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? AdditionalAddress { get; set; }
        public string? ZipCodeID { get; set; }
        public string? ZipCode { get; set; }
        public List<UpdateUrlRequest>? UserUrls { get; set; }

        public List<GetUrlLabelsResponse>? getUrlLabels { get; set; }


        public string UserReferenceId { get; set; }
        public byte[] Content { get; set; }
    }


}