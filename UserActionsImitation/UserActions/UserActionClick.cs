using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionClick : UserActionAlgoritm
    {
        public override void MakeUserAction()
        {
            try
            {
                element.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
