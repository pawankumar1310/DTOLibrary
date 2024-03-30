namespace Api.UserService
{
    public class UserWithUrlResponse
    {
        public string? UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public string? AdditionalAddress { get; set; }
        public string? UTLzipcodeID { get; set; }
        public long? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }

        public string? UTLcountryID { get; set; }

        public List<UrlResponse>? UserUrls { get; set; }
    }


}