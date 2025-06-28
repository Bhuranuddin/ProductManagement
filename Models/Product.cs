using System.ComponentModel.DataAnnotations;

namespace ProductManagementProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(6)]
        public string ProductNumber { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int StockAvailable { get; set; }
    }

    public class ProductNumberSequence
    {
        public int Id { get; set; }
        public int LastNumber { get; set; }
    }

}