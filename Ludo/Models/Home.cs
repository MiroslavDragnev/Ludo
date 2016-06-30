namespace Ludo.Models
{
    using Ludo.Constants;
    using Ludo.Enumerations;
    using System.Collections.Generic;

    public class Home
    {
        public IList<Field> Fields { get; private set; }
        private int originX;
        private int originY;

        public Home(ColorType color)
        {
            this.originX = HomeConstants.HomeOriginX[(int)color];
            this.originY = HomeConstants.HomeOriginY[(int)color];

            this.Fields = new List<Field>()
            {
                new Field(FieldType.HomeField, this.originX - HomeConstants.OffsetFromOrigin, this.originY),
                new Field(FieldType.HomeField, this.originX + HomeConstants.OffsetFromOrigin, this.originY),
                new Field(FieldType.HomeField, this.originX, this.originY - HomeConstants.OffsetFromOrigin),
                new Field(FieldType.HomeField, this.originX, this.originY + HomeConstants.OffsetFromOrigin)
            };
        }
    }
}
