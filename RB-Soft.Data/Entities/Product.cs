using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RB_Soft.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }

        [ForeignKey(nameof(Country))]
        public string CountryName { get; set; }
        public Country Country { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductDetail> Details { get; set; }
    }
}
