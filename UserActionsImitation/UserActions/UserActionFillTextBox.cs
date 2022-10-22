using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionFillTextBox : UserActionAlgoritm
    {
       
        public override void MakeUserAction()
        {
            try { 
                element.SendKeys(actionParams.TextValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
}
    }
}
