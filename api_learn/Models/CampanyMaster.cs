using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_learn.Models
{
    [Table("CampanyMaster")]
    public class CampanyMaster
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cmp_Id { get; set; }
        public int Pro_Id { get; set; }
        public string? Cmp_Name { get; set; }
    }
}
