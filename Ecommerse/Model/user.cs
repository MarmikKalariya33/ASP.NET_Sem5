using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerse.Model
{
    [Table("ecomerce")]
    public class user
    {
        public int userId { get; set }
        public string? userName { get;set }
        public string? userPass { get;set }
    }
}
