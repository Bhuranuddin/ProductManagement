using System.ComponentModel.DataAnnotations;

namespace ProductManagementProject.Models
{
        public class ProductCreateDto
        {
            [Required]
            public string Name { get; set; }
            public string Description1 { get; set; }

            public string Description { get; set; }
            public decimal Price { get; set; }
        public int StockAvailable1 { get; set; }

            [Range(0, int.MaxValue)]
            public int StockAvailable { get; set; }
        }
    }
