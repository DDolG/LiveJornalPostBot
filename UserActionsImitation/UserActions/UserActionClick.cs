using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionClick : UserActionTemplate
    {
        public override void MakeUserAction()
        {
          element.Click();
        }
    }
}
