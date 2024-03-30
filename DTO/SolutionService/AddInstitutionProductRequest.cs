namespace DTO.SolutionService
{
    public class AddInstitutionProductRequest
    {
        public required string USRinstitutionID { get; set; }
        public required string ProductSubscriptionID { get; set; }
        public string? PYMpaymentID { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? CreatedBy { get; set; }   
    }
}