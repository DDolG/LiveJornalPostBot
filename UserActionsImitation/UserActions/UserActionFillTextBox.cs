using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionFillTextBox : UserActionTemplate
    {
       
        public override void MakeUserAction()
        {
            element.SendKeys(actionParams.TextValue);   
        }
    }
}
