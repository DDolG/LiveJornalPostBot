using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
{
    class UserActionFillTextBox : UserActionAlgoritm
    {
        public string  TextValue { get; set; }

        public override void MakeUserAction()
        {
            element.SendKeys(TextValue);
        }
    }
}
