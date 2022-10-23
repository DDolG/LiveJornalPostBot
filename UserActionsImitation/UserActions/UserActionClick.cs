using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionClick : UserActionBase
    {
        public override void MakeUserAction()
        {
          element.Click();
        }
    }
}
