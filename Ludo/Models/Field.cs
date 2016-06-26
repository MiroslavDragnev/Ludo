namespace Ludo.Models
{
    using Ludo.Enumerations;

    public class Field
    {
        public FieldType Type { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        public bool HasPawn { get; set; }

        public Field(FieldType type, int x, int y)
        {
            Type = type;
            XPos = x;
            YPos = y;
            HasPawn = false;
        }
    }
}
