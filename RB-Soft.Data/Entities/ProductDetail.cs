using System.ComponentModel.DataAnnotations;

namespace RB_Soft.Data.Entities
{
    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int DetailId { get; set; }
        public Detail Detail { get; set; }
    }
}
