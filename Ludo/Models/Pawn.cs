namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;
    using Ludo.Models;
    using Ludo.Models.Game;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Contracts;
    public delegate void PawnChangedPos(object sender, EventArgs e);

    public class Pawn : IPawn
    {
        public event PawnChangedPos OnPawnChange;
        private Field currentField;
        public ColorType Color { get; private set; }
        public bool IsAtHome { get; set; }
        public string PawnName { get; private set; }
        public int PawnPos { get; set; }

        public Pawn(ColorType color, int number)
        {
            this.Color = color;
            this.PawnName = $"{PawnConstants.PawnNames[(int)color]}{number}";
            this.IsAtHome = true;
            this.PawnPos = PlaygroundConstants.PlayerStartPos[(int)color];
        }

        public Field CurrentField
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
                this.TriggerChange();
            }
        }

        private void TriggerChange()
        {
            if (this.OnPawnChange != null)
            {
                this.OnPawnChange(this, EventArgs.Empty);
            }
        }

        public void Move(IList<Field> playground, int steps)
        {
            if (this.IsAtHome)
            {
                this.IsAtHome = false;
                this.CurrentField = playground[this.PawnPos];

                return;
            }

            this.PawnPos += steps;

            if (this.PawnPos >= PlaygroundConstants.PlaygroundSize)
            {
                this.PawnPos = 0;
            }

            this.CurrentField = playground[this.PawnPos];
        }
    }
}
