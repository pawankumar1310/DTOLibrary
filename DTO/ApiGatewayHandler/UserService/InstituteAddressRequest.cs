namespace Api.UserService
{
    public class InstituteAddressRequest
    {
        public string AdditionalAddress { get; set; }
        public string Landmark { get; set; }
        public string ZipCodeID { get; set; }
        public string StatusReferenceID { get; set; }
        public string UserID{get;set;}
    }
}