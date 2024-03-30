
using Api.UserService;

namespace DTO.ApiGatewayService
{
    public class GetUserDashboardResponse
    {
        public string? UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public string? AdditionalAddress { get; set; }
        public string? UTLzipcodeID { get; set; }
        public long? PhoneNumber { get; set; }
        public string? UTLcountryID { get; set; }
        public List<UrlResponse>? UserUrls { get; set; }
        public string? EmailAddress { get; set; }

        public List<GetUrlLabelsResponse>? getUrlLabels { get; set; }

        public byte[] ImageContent { get; set; }
        public string? GroupName{get;set;}


    }
}