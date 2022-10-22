using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
{
    public class UserActionFillTextBox : UserActionAlgoritm
    {
       
        public override void MakeUserAction()
        {
            try { 
                element.SendKeys(actionParams.TextValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
}
    }
}
