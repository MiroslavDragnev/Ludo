using Ludo.Constants;
using Ludo.Enumerations;
using Ludo.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo.Models.Game
{
    public partial class Game : Form
    {
        public void DisplayNewPawnPos(object sender, EventArgs e)
        {
            Pawn p = sender as Pawn;

            foreach (Control C in this.Controls)
            {
                if (C is Button && C.Name == p.PawnName)
                {
                    C.Location = new Point(p.CurrentField.XPos, p.CurrentField.YPos);
                }
            }
        }

        private void HandlePawnClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b != null)
            {
                if(this.GameState == GameStateType.WheelSwitchPawns)
                {
                    Pawn enemyPawn = FindPawnFromControl(b);
                    Pawn myPawn = this.currentPlayer.Pawns[this.currentPlayer.SelectedPawn];

                    if(enemyPawn.Equals(myPawn) || enemyPawn.Color == myPawn.Color)
                    {
                        this.GameState = GameStateType.ChangePlayerTurn;
                        return;
                    }

                    if (enemyPawn.Color == this.currentPlayer.Color || enemyPawn.IsAtHome || enemyPawn.PawnIsInFinish)
                    {
                        return;
                    }

                    Field f = myPawn.CurrentField;
                    myPawn.CurrentField = enemyPawn.CurrentField;
                    enemyPawn.CurrentField = f;

                    var pos = myPawn.PawnPos;
                    myPawn.PawnPos = enemyPawn.PawnPos;
                    enemyPawn.PawnPos = pos;

                    this.GameState = GameStateType.ChangePlayerTurn;
                    return;
                }

                this.currentPlayer.SelectedPawn = this.currentPlayer.Pawns.IndexOf(FindPawnFromControl(b));
                //this.currentPlayer.Pawns.IndexOf(
                //(from pawn in this.currentPlayer.Pawns
                // where pawn.PawnName == b.Name
                // select pawn).First());

                //this.currentPlayer.PawnsAtHome =
                //    this.currentPlayer.Pawns.Where(x => x.IsAtHome)
                //    .Select(x => x).ToList().Count;

                //for debugging purposes
                //this.lblStandart.Text = $"{this.currentPlayer.PawnsAtHome}";
                //this.lblMama.Text = $"{this.currentPlayer.PawnsEscaped}";


                this.GameState = GameStateType.MovePawn;

                //if (this.currentPlayer.Pawns[this.currentPlayer.SelectedPawn].IsAtHome
                //    && this.currentPlayer.StepsLeft < DiceConstants.MaxStandart
                //    && this.currentPlayer.PawnsAtHome < PlayerConstants.PawnsPerPlayer)
                //{
                //    this.GameState = GameStateType.SelectPawn;
                //}
                //else
                //{
                //    //this.players[turn].PawnsAtHome--;
                //    this.GameState = GameStateType.MovePawn;

                //}

            }
        }

        private void HandleDiceClick(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == null)
                return;

            switch (b.Name)
            {
                case "btnDiceStandart":
                    {
                        int val = this.diceStandart.Throw(rnd);

                        this.lblStandart.Text = $"{val}";

                        if (val < DiceConstants.MaxStandart && currentPlayer.PawnsAtHome + currentPlayer.PawnsEscaped == PlayerConstants.PawnsPerPlayer)
                        {

                            if (this.curPlayerInitialThrows > 1)
                            {
                                this.curPlayerInitialThrows--;
                                this.GameState = GameStateType.ThrowNormal;

                            }
                            else
                            {
                                this.curPlayerInitialThrows--;
                                this.GameState = GameStateType.ChangePlayerTurn;
                            }

                            break;
                        }

                        this.players[turn].StepsLeft = val;

                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
                case "btnDiceNine":
                    {
                        int val = this.diceNine.Throw(rnd);

                        this.players[turn].StepsLeft = -1 * val;
                        this.lblNine.Text = $"{val}";

                        this.GameState = GameStateType.MovePawn;
                        break;
                    }
                case "btnDiceMama":
                    {
                        int val = this.diceMama.Throw(rnd);

                        this.players[turn].StepsLeft = val;
                        this.lblMama.Text = $"{val}";

                        this.GameState = GameStateType.SelectPawn;
                        break;
                    }
                case "btnDiceCatapult":
                    {
                        int val = this.diceCatapult.Throw(rnd);
                        this.players[turn].StepsLeft = -1 * val;
                        this.lblCatapult.Text = $"{val}";
                        this.GameState = GameStateType.MovePawn;
                        break;
                    }
                case "btnWheel":
                    {
                        // TODO: sled kato koleloto se zavyrti
                        // rezultatyt trqbwa da se pazi w pole
                        // i ottam natatyk da se sluchwat nqkvi neshta :D

                        Wheel.Spin(b, this.rnd);
                        // TODO: TO BE FIXED
                        //await Task.Delay(10000);
                        //this.spinResult = (WheelType)int.Parse(b.Name[b.Name.Length - 1].ToString());
                        //b.Name = "btnWheel";
                        //GetResultFromWheel();
                        //this.GameState = GameStateType.RotateWheel;
                        // this.UpdateControls(false, false, false, false, false);
                        //this.GameState = GameStateType.ChangePlayerTurn;
                        break;
                    }
            }
        }

        private void DiceEnabledChanged(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == null)
                return;

            switch (b.Name)
            {
                case "btnDiceMama":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.BigMama :
                            global::Ludo.Properties.Resources.BigMamaDis;

                        break;
                    }
                case "btnDiceNine":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Nine :
                            global::Ludo.Properties.Resources.NineDis;
                        break;
                    }
                case "btnDiceStandart":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Standart :
                            global::Ludo.Properties.Resources.StandartDis;
                        break;
                    }
                case "btnDiceCatapult":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Catapult :
                            global::Ludo.Properties.Resources.CatapultDis;
                        break;
                    }
                case "btnWheel":
                    {
                        b.BackgroundImage =
                            b.Enabled == true ?
                            global::Ludo.Properties.Resources.Wheel :
                            global::Ludo.Properties.Resources.WheelDis;
                        break;
                    }
            }
        }

        public void UpdateControls(bool standart, bool mama, bool nine, bool catapult, bool wheel)
        {
            this.btnDiceNine.Enabled = nine;
            this.btnDiceCatapult.Enabled = catapult;
            this.btnDiceMama.Enabled = mama;
            this.btnDiceStandart.Enabled = standart;
            this.btnWheel.Enabled = wheel;
        }

        public void UpdatePawns(bool curPlayerPawns, bool enemyPawns)
        {
            bool enable = false;

            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    foreach (var plr in this.players)
                    {
                        enable = (plr == this.currentPlayer && curPlayerPawns)
                            || (plr != this.currentPlayer && enemyPawns);

                        //enable = (plr == currentPlayer && curPlayerPawnsEnabled);

                        foreach (var p in plr.Pawns)
                        {
                            if (C.Name == p.PawnName)
                            {
                                C.Enabled = enable;
                            }
                        }
                    }
                }
            }
        }

        public void HideUnusedPawns(ColorType color)
        {
            foreach (Control C in this.Controls)
            {
                if (C is Button)
                {
                    for (int i = 0; i < PlayerConstants.PawnsPerPlayer; i++)
                    {
                        if (C.Name == $"{PawnConstants.PawnNames[(int)color]}{i}")
                        {
                            C.Hide();
                        }
                    }
                }
            }
        }

        public IList<Field> GetFinishFromColor(ColorType col)
        {
            return col == ColorType.Red ? redFinish :
                   col == ColorType.Green ? greenFinish :
                   col == ColorType.Yellow ? yellowFinish :
                   col == ColorType.Blue ? blueFinish : redFinish;
        }

        private void pbPlayground_Click(object sender, EventArgs e)
        {
            if (this.GameState == GameStateType.WheelPlaceBomb)
            {
                var cursorPos = GetCursorPosition(); 
                var tokenIndex = FindClosestEmptyFieldIndex(cursorPos);
                AudioPlayer.PlaceBombSound();

                this.playground[tokenIndex].Type = FieldType.Bomb;
                this.tokens[tokenIndex].BackgroundImage = global::Ludo.Properties.Resources.TokenBomb;
                this.tokens[tokenIndex].BringToFront();

                this.GameState = GameStateType.ChangePlayerTurn;
            }
            else if (this.GameState == GameStateType.WheelPlaceCatapult)
            {
                var cursorPos = GetCursorPosition();
                var tokenIndex = FindClosestEmptyFieldIndex(cursorPos);
                AudioPlayer.PlaceCatapultSound();

                this.playground[tokenIndex].Type = FieldType.Catapult;
                this.tokens[tokenIndex].BackgroundImage = global::Ludo.Properties.Resources.TokenCatapult;
                this.tokens[tokenIndex].BringToFront();

                this.GameState = GameStateType.ChangePlayerTurn;
            }
            else if (this.GameState == GameStateType.WheelPlaceSleep)
            {
                var cursorPos = GetCursorPosition();
                var tokenIndex = FindClosestEmptyFieldIndex(cursorPos);
                AudioPlayer.PlacePillowSound();

                this.playground[tokenIndex].Type = FieldType.Sleep;
                this.tokens[tokenIndex].BackgroundImage = global::Ludo.Properties.Resources.TokenSleep;
                this.tokens[tokenIndex].BringToFront();

                this.GameState = GameStateType.ChangePlayerTurn;
            }
        }

        private Point GetCursorPosition()
        {
            var cursorX = Cursor.Position.X;
            var cursorY = Cursor.Position.Y;

            //amount for the form location on the screen
            cursorX -= this.Location.X;
            cursorY -= this.Location.Y;

            //amount for the form 'bezels'
            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int topBezel = screenRectangle.Top - this.Top;
            int leftBezel = screenRectangle.Left - this.Left;

            cursorX -= leftBezel;
            cursorY -= topBezel;

            //amount for the offset of the field location to the center of the playground field image
            cursorX -= HomeConstants.OffsetFromOrigin / 2 - TokenConstants.TokenOffsetFromPawn;
            cursorY -= HomeConstants.OffsetFromOrigin / 2 - TokenConstants.TokenOffsetFromPawn;

            return new Point(cursorX, cursorY);
        }

        private int FindClosestEmptyFieldIndex(Point cursorPos)
        {
            var minDistance = 999999D;
            var minDistanceIndex = 0;

            for (int i = 0; i < PlaygroundConstants.PlaygroundSize; i++)
            {
                if (this.playground[i].Type != FieldType.Normal || IsFieldStartPosition(i)
                    || this.playground[i].HasPawn)
                    continue;

                var cX = cursorPos.X;
                var cY = cursorPos.Y;
                var fX = this.playground[i].XPos;
                var fY = this.playground[i].YPos;

                var d = (cX - fX) * (cX - fX) + (cY - fY) * (cY - fY);

                if (d < minDistance)
                {
                    minDistance = d;
                    minDistanceIndex = i;
                }
            }

            return minDistanceIndex;
        }
        
        private bool IsFieldStartPosition(int index)
        {
            for (int i = 0; i < PlaygroundConstants.PlayerStartPos.Length; i++)
            {
                if (PlaygroundConstants.PlayerStartPos[i] == index)
                {
                    return true;
                }
            }

            return false;
        }
        
        private Pawn FindPawnFromControl(Button b)
        {
            for(int i = 0; i < this.playerCount; i++)
            {
                for(int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    if(this.players[i].Pawns[j].PawnName == b.Name)
                    {
                        return this.players[i].Pawns[j];
                    }
                }
            }

            return null;
        }

        private Button FindControlFromPawn(Pawn p)
        {
            foreach (Control C in this.Controls)
            {
                Button b = C as Button;

                if(b != null && b.Name == p.PawnName)
                {
                    return b;
                }
            }

            return null;
        }

        private void BringPawnsToFront()
        {
            foreach (Control C in this.Controls)
            {
                if (C is Button && C.Name.Contains("Pawn"))
                {
                    C.BringToFront();
                }
            }
        }

        private void RemovePawnsFromField(Field f, Pawn exceptPawn)
        {
            var indexOfField = this.playground.IndexOf(f);

            for(int i = 0; i < this.playerCount; i++)
            {
                for(int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    var pawn = this.players[i].Pawns[j];

                    if(exceptPawn == null ||
                        (pawn.PawnPos == indexOfField && !pawn.PawnIsInFinish
                        && pawn.Color != exceptPawn.Color))
                    {
                        this.BringPawnToHome(pawn);
                        AudioPlayer.PlayLaughSound();
                    }
                }
            }
        }

        private void BringPawnToHome(Pawn p)
        {
            var pOwner = this.GetPawnOwner(p);

            p.CurrentField = pOwner.Home.FindEmptyHomeField();
            p.IsAtHome = true;
            pOwner.PawnsAtHome++;
            
        }

        private bool IsFieldStillPopulated(Field f)
        {
            var fieldIndex = this.playground.IndexOf(f);

            var count = 0;

            for(int i = 0; i < this.playerCount; i++)
            {
                for(int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    Pawn p = this.players[i].Pawns[j];

                    if (p.PawnPos == fieldIndex
                        && !p.PawnIsInFinish && !p.IsAtHome)
                    {
                        count++;
                    }
                }
            }

            return count > 1;
        }

        private void HandleNewPawnPosition(Pawn p)
        {
            Field curField = p.CurrentField;
            FieldType fType = curField.Type;

            if(p.PawnFinished)
            {
                var plr = GetPawnOwner(p);
                plr.PawnsEscaped++;
                var btn = FindControlFromPawn(p);
                btn.Hide();

                if(plr.PawnsEscaped == PlayerConstants.PawnsPerPlayer)
                {
                    foreach(Control C in this.Controls)
                    {
                        C.Hide();
                    }

                    this.lblWinner.Text = $"{plr.Name} wins!";
                    this.lblWinner.ForeColor = ColorConstants.Colors[(int)plr.Color];
                    this.lblWinner.Show();
                    return;
                }

                this.GameState = GameStateType.ChangePlayerTurn;
                return;
            }

            if(curField.HasPawn)
            {
                this.RemovePawnsFromField(curField, p);
            }

            curField.HasPawn = true;

            if(fType == FieldType.Nine)
            {
                this.GameState = GameStateType.ThrowNine;
                return;
            }
            else if(fType == FieldType.Special)
            {
                this.GameState = GameStateType.RotateWheel;
                return;
            }
            else if(fType == FieldType.Bomb)
            {
                curField.Type = FieldType.Normal;
                this.DestroyToken(curField);
                //this.BringPawnToHome(p);
                this.RemovePawnsFromField(curField, null);
            }
            else if(fType == FieldType.Catapult)
            {
                curField.Type = FieldType.Normal;
                this.DestroyToken(curField);
                this.GameState = GameStateType.ThrowCatapult;
                return;
            }
            else if(fType == FieldType.Sleep)
            {
                this.currentPlayer.IsSleeping = true;
                curField.Type = FieldType.Normal;
                this.DestroyToken(curField);
            }

            this.GameState = GameStateType.ChangePlayerTurn;
        }

        private void DestroyToken(Field f)
        {
            var tokenIndex = this.playground.IndexOf(f);
            this.tokens[tokenIndex].SendToBack();
        }

        private Player GetPawnOwner(Pawn p)
        {
            for(int i = 0; i < this.playerCount; i++)
            {
                for(int j = 0; j < PlayerConstants.PawnsPerPlayer; j++)
                {
                    if (this.players[i].Pawns[j].Equals(p))
                        return this.players[i];
                }
            }

            return null;
        }
    }
}
