using System.ComponentModel.DataAnnotations;

namespace CRUDTask.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters long")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [MaxLength(100, ErrorMessage = "Description cannot exceed 100 characters")]
        [DataType(DataType.Text)]

        public string Description { get; set; }
        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Text)]

        public decimal Price { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Rate is required")]
        [Range(0, 5, ErrorMessage = "Rate must be between 0 and 5")]
        public double Rate { get; set; }
    }
}
