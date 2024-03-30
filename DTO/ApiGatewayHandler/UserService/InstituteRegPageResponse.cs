namespace Api.UserService
{
    public class InstituteRegPageResponse
    {
        public List<GetFacilityResponse> Facilities { get; set; }
        public List<GetGovernanceResponse> Governance { get; set; }
        public List<OwnershipResponse> Ownership { get; set; }
    }
    
}