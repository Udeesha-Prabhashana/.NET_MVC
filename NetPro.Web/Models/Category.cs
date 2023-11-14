using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NetPro.Web.Models
{
    public class Category
    {
        [Key]        //use to define primary key
        public int Id { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        [DisplayName("Display Order")]                // use to display it in the html page 
        public int DisplayOrder { get; set; }
    }
}
