namespace api_learn.DTOs
{
    public class ProductDTO
    {
        public string ProName { get; set; } = string.Empty;
        public string ProCategory { get; set; } = string.Empty;
        public decimal ProPrice { get; set; }
        public string? CmpName { get; set; }

    }
}
