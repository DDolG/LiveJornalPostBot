﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
{
    public class UserActionFillTextBox : UserActionAlgoritm
    {
        public string  TextValue { get; set; }

        public override void MakeUserAction()
        {
            try { 
                element.SendKeys(TextValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
}
    }
}
