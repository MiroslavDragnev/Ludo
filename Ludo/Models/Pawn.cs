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
    using System.Threading.Tasks;
    public delegate void PawnChangedPos(object sender, EventArgs e);

    public class Pawn : IPawn
    {
        public event PawnChangedPos OnPawnChange;
        private Field currentField;
        public ColorType Color { get; private set; }
        public bool IsAtHome { get; set; }
        public string PawnName { get; private set; }
        public int PawnPos { get; set; }
        public bool PawnFinished { get; set; }
        public bool PawnIsInFinish { get; set; }

        public Pawn(ColorType color, int number)
        {
            this.Color = color;
            this.PawnName = $"{PawnConstants.PawnNames[(int)color]}{number}";
            this.IsAtHome = true;
            this.PawnFinished = false;
            this.PawnIsInFinish = false;
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

        public async void Move(IList<Field> playground, IList<Field> finish, int steps, bool moveBack)
        {
            if (this.IsAtHome)
            {
                if (steps == DiceConstants.MaxStandart)
                {
                    this.IsAtHome = false;
                    this.CurrentField = playground[this.PawnPos];
                }              

                return;
            }

            if (moveBack)
            {
                #region MoveBack
                for (int i = 0; i < steps; i++)
                {
                    if (this.PawnIsInFinish)
                    {
                        if (this.PawnPos == 0)
                        {
                            this.PawnIsInFinish = false;
                            this.PawnPos = PlaygroundConstants.PlayerEntryToFinish[(int)this.Color];
                            this.CurrentField = playground[this.PawnPos];

                            await Task.Delay(PawnConstants.DisplayDelay);
                            continue;
                        }

                        this.PawnPos--;
                        this.CurrentField = finish[this.PawnPos];

                        await Task.Delay(PawnConstants.DisplayDelay);
                        continue;
                    }

                    if (this.PawnPos == PlaygroundConstants.PlayerStartPos[(int)this.Color])
                    {
                        //this will need additional work
                        //since we don't want to have a delay before turn change
                        //when the total steps back > steps to start position
                        await Task.Delay(PawnConstants.DisplayDelay);
                        continue;
                    }

                    this.PawnPos--;
                    this.CurrentField = playground[this.PawnPos];
                    await Task.Delay(PawnConstants.DisplayDelay);
                }

                #endregion
            }
            else
            {
                #region MoveForward
                for (int i = 0; i < steps; i++)
                {
                    if (this.PawnPos == PlaygroundConstants.PlayerEntryToFinish[(int)this.Color])
                    {
                        this.PawnIsInFinish = true;
                        this.PawnPos = 0;
                        this.CurrentField = finish[this.PawnPos];

                        await Task.Delay(PawnConstants.DisplayDelay);
                        continue;
                    }

                    this.PawnPos++;

                    if (this.PawnIsInFinish)
                    {
                        this.CurrentField = finish[this.PawnPos];
                    }
                    else
                    {
                        if (this.PawnPos >= PlaygroundConstants.PlaygroundSize && this.Color != ColorType.Red)
                        {
                            this.PawnPos = 0;
                        }

                        this.CurrentField = playground[this.PawnPos];
                    }

                    await Task.Delay(PawnConstants.DisplayDelay);
                }
                #endregion
            }
        }
    }
}
