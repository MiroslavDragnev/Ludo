namespace Ludo.Abstract
{
    using Ludo.Interfaces;
    using Ludo.Models;

    public abstract class Token : IActionable
    {
        //PATH OF THE IMAGE 
        protected string pathOfImage;

        public virtual void DoAction()
        {
            //THIS METHOD WILL BE OVERRIDDEN IN THE CHILD CLASSSES OF Token
        }
        public virtual void DoAction(Pawn pawn)
        {

        }

    }
}
