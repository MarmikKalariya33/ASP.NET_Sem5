using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace api_learn.Models
{
    [Table("ProductMaster")]
    public class ProductMaster
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pro_Id { get; set; }
        public string Pro_Name { get; set; } = string.Empty;
        public string Pro_Category { get; set; } = string.Empty;
        public int Pro_Qty { get; set; }
        public decimal Pro_Price { get; set; }

    }
}
