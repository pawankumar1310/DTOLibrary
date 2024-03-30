namespace DTO.SolutionService
{
    public class AddProductSubscriptionRequest
    {
        public required string Name { get; set; }
        public required decimal AmountPerDay { get; set; }
        public required string Code { get; set; }
        public required List<string> SubscriptionModes { get; set; }
        public required string CreatedBy { get; set; }

    }
}