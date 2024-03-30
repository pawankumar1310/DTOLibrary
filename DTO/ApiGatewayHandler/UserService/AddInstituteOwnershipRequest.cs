namespace Api.UserService
{
    public class AddInstituteOwnershipRequest
    {
        public string institutionID { get; set; }
        public string ownerShipID { get; set; }
        public string createdBy { get; set; }
    }
}