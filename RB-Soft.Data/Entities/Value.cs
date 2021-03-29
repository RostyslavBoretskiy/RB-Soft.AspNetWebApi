using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RB_Soft.Data.Entities
{
    public class Value
    {
        public int ValueId { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<PropertyValue> Properties { get; set; }
    }
}