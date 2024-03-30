namespace DTO.UserService
{
    public class LoginInitiationRequest
    {
        public required string UserInput { get; set; }
        public string? countryID {get; set; }
        
    }
}