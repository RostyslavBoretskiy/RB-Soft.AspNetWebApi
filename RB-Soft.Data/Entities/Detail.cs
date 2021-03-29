using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RB_Soft.Data.Entities
{
    public class Detail
    {
        public int DetailId { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(Country))]
        public string CountryName { get; set; }
        public Country Country { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<ProductDetail> Products { get; set; }
        public ICollection<DetailProperty> Properties { get; set; }
    }
}
