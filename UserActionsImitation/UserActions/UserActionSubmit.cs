using System;

namespace UserActionsImitation.UserActions
{
    public class UserActionSubmit : UserActionAlgoritm
    {
        public override void MakeUserAction()
        {
            try
            {
               element.Submit();
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
