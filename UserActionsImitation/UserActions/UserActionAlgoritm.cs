using OpenQA.Selenium;
using System;
using UserActionsImitation.ActionParams;

namespace UserActionsImitation.UserActions
{
    public abstract class UserActionAlgoritm
    {

        internal IWebElement element;

        internal Params actionParams;

        public virtual void AddUserActionParams(Params actionParams)
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
