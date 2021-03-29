namespace RB_Soft.Data.Entities
{
    public class DetailProperty
    {
        public int DetailId { get; set; }
        public Detail Detail { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }
    }
}
