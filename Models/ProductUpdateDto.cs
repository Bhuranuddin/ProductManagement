﻿namespace ProductManagementProject.Models
{
    public class ProductUpdateDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockAvailable { get; set; }
    }
}