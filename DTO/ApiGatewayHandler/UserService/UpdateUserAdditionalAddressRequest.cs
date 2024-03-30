namespace Api.UserService
{
    public class UpdateUserAdditionalAddressRequest
    {
        public string? UserID { get; set; }
        public string? AdditionalAddress { get; set; }
    }
}