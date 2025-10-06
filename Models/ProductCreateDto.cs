using System.ComponentModel.DataAnnotations;

namespace ProductManagementProject.Models
{
        public class ProductCreateDto
        {
            [Required]
            public string Name { get; set; }

            public string Description { get; set; }
        [Range(0, int.MaxValue)]
            public decimal Price { get; set; }

            [Range(0, int.MaxValue)]
            public int StockAvailable { get; set; }
        }
    }
