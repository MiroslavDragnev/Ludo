namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;

    public class Player
    {
        private string name;
        private ColorType color;

        //let's leave those as automatic properties for now
        //private int pawnsAtHome;
        //private int pawnsEscaped;
        //private int stepsLeft;

        public Player(string name, ColorType color)
        {
            this.name = name;
            this.color = color;
            this.PawnsAtHome = PlayerConstants.InitPawnsAtHome;
            this.PawnsEscaped = PlayerConstants.InitPawnsEscaped;
            this.StepsLeft = 0;
        }

        public int PawnsAtHome { get; set; }
        public int PawnsEscaped { get; set; }
        public int StepsLeft { get; set; }
    }
}
