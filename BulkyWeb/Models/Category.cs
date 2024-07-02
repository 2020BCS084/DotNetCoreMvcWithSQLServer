using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]    //using this annotation Entity Framework will know that Id is our primary key, even if any variable named as
                 //Id or with suffix Id is considered as Primary key.

        public int Id { get; set; }

        [Required]                         //this required tells this is the required field.
        [DisplayName("Category Name")]     //DisplayName means , name shown on frontend.
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage ="range should be between 1-100")]     //this is how we can create custom error msg, else system error will be shown.
        public int DisplayOrder { get; set; }
    }
}