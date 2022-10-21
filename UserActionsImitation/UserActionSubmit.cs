using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
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
