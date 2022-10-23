using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionFillTextBox : UserActionBase
    {
       
        public override void MakeUserAction()
        {
            element.SendKeys(actionParams.TextValue);   
        }
    }
}
