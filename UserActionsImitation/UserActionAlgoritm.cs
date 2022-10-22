using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
{
    public abstract class UserActionAlgoritm
    {

        internal IWebElement element;

        internal ActionParams actionParams;

        public virtual void AddUserActionParams(ActionParams actionParams)
        {
            this.actionParams = actionParams;
        }

        public virtual void Execute()
        {
            SearchElement();
            MakeUserAction();
            Console.WriteLine("Finish " + this.GetType());
        }

        public virtual void SearchElement()
        {
            try
            {
                element = actionParams.WebDriver.FindElement(actionParams.SearchType(actionParams.ElementId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public abstract void MakeUserAction();
    }
}
