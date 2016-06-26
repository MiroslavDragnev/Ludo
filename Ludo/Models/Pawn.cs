namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;

    public class Pawn
    {
        // In order to get the current position of any pawn by X and Y coordinates we need XPos and YPos Fields
        //TODO: currentXPos + property
        //TODO: currentYPos + property
        public Pawn(ColorType color)
        {
            Color = color;
            OnGameField = false;
            Escaped = false;
            SetStartAndEndPossitions();
        }

        public int StartPossition { get; private set; }
        public int EntryToFinish { get; private set; }
        public int Possition { get; private set; }
        public bool OnGameField { get; set; }
        public bool Escaped { get; set; }
        public ColorType Color { get; set; }
        
        //Move Pawn
        public void Move(int diceNumber)
        {
            this.Possition += diceNumber;
            if (this.Color != ColorType.Red && this.Possition >= PlaygroundConstants.PLAYGROUND_SIZE)
            {
                this.Possition %= PlaygroundConstants.PLAYGROUND_SIZE;
            }

            //TODO (escaping the playground)
            //TODO (reseting possition when send home)
        }

        //Generate initial possitions
        private void SetStartAndEndPossitions()
        {
            if (this.Color == ColorType.Red)
            {
                this.StartPossition = PlaygroundConstants.RED_START_INDEX;
                this.EntryToFinish = PlaygroundConstants.RED_ENTRY_TO_FINISH;
            }
            else if (this.Color == ColorType.Green)
            {
                this.StartPossition = PlaygroundConstants.GREEN_START_INDEX;
                this.EntryToFinish = PlaygroundConstants.GREEN_ENTRY_TO_FINISH;
            }
            else if (this.Color == ColorType.Yellow)
            {
                this.StartPossition = PlaygroundConstants.YELLOW_START_INDEX;
                this.EntryToFinish = PlaygroundConstants.YELLOW_ENTRY_TO_FINISH;
            }
            else if (this.Color == ColorType.Blue)
            {
                this.StartPossition = PlaygroundConstants.BLUE_START_INDEX;
                this.EntryToFinish = PlaygroundConstants.BLUE_ENTRY_TO_FINISH;
            }
        }
    }
}
