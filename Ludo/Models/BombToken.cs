namespace Ludo.Models
{
    using Ludo.Abstract;
    public class BombToken : Token
    {
        //CONSTRUCTOR
        public BombToken()
        {
            pathOfImage = "/Images/..";
        }
        public override void DoAction(Pawn pawn)
        {
            //TODO:
            //The pawn which is on the Bomb field must be returned to Home
            //1.Find the appropriate home by color which is the same as the pawn's color
            //2. Invoke FindEmptyHomeField() of the 
            //3. Set the pawn position to the EmptyField In Home
        }
    }
}
