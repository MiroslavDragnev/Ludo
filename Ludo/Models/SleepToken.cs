namespace Ludo.Models
{
    using Ludo.Abstract;
    public class SleepToken : Token
    {
        //CONSTRUCTOR
        public SleepToken()
        {
            pathOfImage = "/Images/..";
        }
        public void DoAction()
        {
            //TODO: current player skips his next turn;
        }
    }
}
