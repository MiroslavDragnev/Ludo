namespace Ludo.Models
{
    using Ludo.Enumerations;
    using Ludo.Constants;
    using System.Collections.Generic;
    public class Player
    {
        public string Name { get; set; }
        public int PawnsAtHome { get; set; }
        public int PawnsEscaped { get; set; }
        public int StepsLeft { get; set; }
        public List<Pawn> Pawns{ get; set; }
        public Home Home { get; set; }
        public ColorType Color { get; set; }
        public int SelectedPawn { get; set; }

        public Player(string name, ColorType color)
        {
            this.Name = name;
            this.Color = color;
            this.PawnsAtHome = PlayerConstants.InitPawnsAtHome;
            this.PawnsEscaped = PlayerConstants.InitPawnsEscaped;
            this.StepsLeft = 0;
            this.Home = new Home(color);
            this.Pawns = new List<Pawn>();

            for (int i = 0; i < PlayerConstants.PawnsPerPlayer; i++)
                Pawns.Add(new Pawn(Color, i));
        }
    }
}
