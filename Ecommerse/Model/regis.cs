using System.ComponentModel.DataAnnotations;

namespace Ecommerse.Model
{
    public class regis
    {
        [Key]
        public int userId { get; set; }

        public string? userName { get; set; }

        public string? userPass { get; set; }
    }
}