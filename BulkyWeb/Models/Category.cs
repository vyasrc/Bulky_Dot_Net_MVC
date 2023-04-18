using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
    }
}
