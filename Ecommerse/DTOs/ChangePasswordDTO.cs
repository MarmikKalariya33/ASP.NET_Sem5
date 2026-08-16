namespace Ecommerse.DTOs
{
    public class ChangePasswordDTO
    {
        public int userId { get; set; }
        public string? CurrentPassword { get; set; }
        public string? NewPassword { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
