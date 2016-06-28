namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;
    using Ludo.Models;
    using Ludo.Models.Game;
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public delegate void PawnChangedPos(object sender, EventArgs e);

    public class Pawn
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

        //public static void Move(this Pawn p, List<Field> playground)
        //{
        //    if(p.IsAtHome)
        //    {
        //        p.IsAtHome = false;
        //        p.CurrentField = playground[p.PawnPos];

        //        return;
        //    }

        //    p.PawnPos += 1;
            
        //    if(p.PawnPos >= PlaygroundConstants.PlaygroundSize)
        //    {
        //        p.PawnPos = 0;
        //    }

        //    p.CurrentField = playground[p.PawnPos];
        //}
    }
}
