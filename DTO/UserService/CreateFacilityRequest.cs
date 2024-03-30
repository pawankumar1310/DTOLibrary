namespace DTO.UserService
{
    public class CreateFacilityRequest
    {
        public required string Name { get; set; }
        public string? CreatedBy{get; set; }
    }
}   