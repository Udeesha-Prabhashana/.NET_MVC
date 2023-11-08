using System.ComponentModel.DataAnnotations;

namespace NetPro.Web.Models
{
    public class Category
    {
        [Key]        //use to define primary key
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
