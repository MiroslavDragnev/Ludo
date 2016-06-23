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
            this.fields = new List<Field>();
            this.originX = HomeConstants.HomeOriginX[(int)color];
            this.originY = HomeConstants.HomeOriginY[(int)color];
            this.InitializeHome();
        }

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
