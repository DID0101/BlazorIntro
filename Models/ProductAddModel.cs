using System.ComponentModel.DataAnnotations;

namespace BlazorIntro.Models
{
    public class ProductAddModel
    {
        [Required(ErrorMessage ="Product Name Required")]
        [StringLength(20)]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product Description Required")]
        [StringLength(40)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Product Category Required")]
        public string CategoryId { get; set; }
    }
}
