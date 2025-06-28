using Microsoft.EntityFrameworkCore;
using ProductManagementProject.Data;
using ProductManagementProject.Models;
using System;

namespace ProductManagementProject.Utils
{
    public class ProductIdGenerator
    {
        private readonly AppDbContext _context;

        public ProductIdGenerator(AppDbContext context)
        {
            _context = context;
        }
        public async Task<string> GenerateUniqueProductNumberAsync()
        {
            var sequence = await _context.ProductNumberSequences.FirstAsync();
            sequence.LastNumber++;
            await _context.SaveChangesAsync();
            return sequence.LastNumber.ToString("D6");
        }
    }
}