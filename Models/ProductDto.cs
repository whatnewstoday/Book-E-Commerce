using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ITSS.Models
{
    public class ProductDto
    {
        [Required,MaxLength(100)]
        public string Title { get; set; } = "";
        [Required,MaxLength(100)]
        public string Category { get; set; } = "";
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = "";

        public IFormFile? ImageFile { get; set; } 
    }
}
