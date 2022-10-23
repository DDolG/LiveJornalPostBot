using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionSubmit : UserActionTemplate
    {
        public override void MakeUserAction()
        {
            element.Submit();
        }
    }
}
