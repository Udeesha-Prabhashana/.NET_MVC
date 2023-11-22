using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NetPro_Razor.Models
{
    public class Category
    {
        [Key]        //use to define primary key
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "Please enter valid Order Name")]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        [DisplayName("Display Order")]                // use to display it in the html page 
        [Range(1, 100, ErrorMessage = "Please enter valid Order Number")]                                 //validation
        public int DisplayOrder { get; set; }
    }
}
