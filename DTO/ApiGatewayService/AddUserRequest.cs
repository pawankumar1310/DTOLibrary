using Api.UserService;
namespace DTO.ApiGatewayService
{
    public class AddUserRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CountryID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? AdditionalAddress { get; set; }
        public string? ZipcodeID { get; set; }
        public List<UpdateUrlRequest>? Urls { get; set; }
        public List<GetUrlLabelsResponse>? getUrlLabels { get; set; }
        public string? ImageLabel { get; set; }
        public string? ImageName { get; set; }
        public byte[]? Content { get; set; }
        public string? GroupID { get; set; }
    }
}
