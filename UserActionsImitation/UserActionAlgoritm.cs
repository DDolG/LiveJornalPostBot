using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserActionsImitation
{
    public abstract class UserActionAlgoritm
    {
        public IWebDriver WebDriver { get; set; }

        internal IWebElement element;

        public string ElementId { get; set; }

        public delegate By SearchMethod(string elementId);
        
        public SearchMethod SearchType { get; set; }
        
        
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
                element = WebDriver.FindElement(SearchType(ElementId));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public abstract void MakeUserAction();
    }
}
