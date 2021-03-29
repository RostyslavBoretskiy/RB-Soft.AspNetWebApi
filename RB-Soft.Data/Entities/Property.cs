using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RB_Soft.Data.Entities
{
    public class Property
    {
        public int PropertyId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<PropertyValue> Values { get; set; }
        public ICollection<DetailProperty> Details { get; set; }
    }
}
