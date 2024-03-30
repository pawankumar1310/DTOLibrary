namespace Api.UserService
{
    public class UpdateUserWithUrlRequest
    {
        public string? UserID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CountryID { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? AdditionalAddress{ get; set; }

        public string? ZipCodeID { get; set; }

        public List<UpdateUrlRequest>? UserUrls { get; set; }
    }
}