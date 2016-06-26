namespace Ludo.Models
{
    using Ludo.Constants;
    using Ludo.Enumerations;
    using System.Collections.Generic;

    public class Home
    {
        private List<Field> fields;
        private int originX;
        private int originY;

        public Home(ColorType color)
        {
            fields = new List<Field>();
            originX = HomeConstants.HomeOriginX[(int)color];
            originY = HomeConstants.HomeOriginY[(int)color];
            InitializeHome();
        }

        //PROPERTY ColorType to assosiate with pawn
        public ColorType Color { get; private set; }

        private void InitializeHome()
        {
            fields.Add(new Field(FieldType.HomeField, this.originX - HomeConstants.OffsetFromOrigin, this.originY));
            fields.Add(new Field(FieldType.HomeField, this.originX + HomeConstants.OffsetFromOrigin, this.originY));
            fields.Add(new Field(FieldType.HomeField, this.originX, this.originY - HomeConstants.OffsetFromOrigin));
            fields.Add(new Field(FieldType.HomeField, this.originX, this.originY + HomeConstants.OffsetFromOrigin));
        }

        public Field FindEmptyHomeField()
        {
            foreach(var field in fields)
            {
                if (field.HasPawn)
                    continue;

                field.HasPawn = true;
                return field;
            }

            return fields[0];
        }
    }
}
