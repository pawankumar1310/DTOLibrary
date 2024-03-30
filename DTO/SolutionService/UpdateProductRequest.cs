namespace Dto.SolutionService
{
    public class UpdateProductRequest
    {
        public required string ProductId { get; set; }
        public required string Name { get; set; }
        public decimal AmountPerDay { get; set; }
        public required string Code { get; set; }
        public List<string>? SubscriptionModes { get; set; }
        public string? UpdatedBy { get; set; }
    }
}