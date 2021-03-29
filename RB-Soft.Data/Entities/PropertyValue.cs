namespace RB_Soft.Data.Entities
{
    public class PropertyValue
    {
        public int PropertyId { get; set; }
        public Property Property { get; set; }

        public int ValueId { get; set; }
        public Value Value { get; set; }
    }
}
