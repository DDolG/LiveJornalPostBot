using OpenQA.Selenium;
using System;

namespace UserActionsImitation
{
    public class UserAction
    {
        private IWebElement element;
        public string  ElementId { get; set; }

        public delegate By SearchMethod(string elementId);
        public SearchMethod SearchType{ get; set; }

        private delegate void delegateAction();

        private delegateAction userAction;

        public EActions TypeAction { get; set; }

        public IWebDriver WebDriver { get; set; }

        public void SearchElement()
        {
            try
            {
                element = WebDriver.FindElement(SearchType(ElementId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void ChooseAction() {
            switch (TypeAction)
            {
                case EActions.CLICK:
                    userAction = element.Click;
                    break;
                default:
                    throw new ArgumentException("Set unknown action");
            }
        }

        public void Execute()
        {
            try
            {
                userAction();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
