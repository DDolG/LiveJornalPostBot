using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionSubmit : UserActionBase
    {
        public override void MakeUserAction()
        {
            element.Submit();
        }
    }
}
