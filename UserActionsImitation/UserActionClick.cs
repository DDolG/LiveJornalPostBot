using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
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
