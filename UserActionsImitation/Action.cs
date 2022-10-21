using OpenQA.Selenium;
using System;

namespace UserActionsImitation
{
    public class Action
    {
        private IWebElement element;
        public string  ElementId { get; set; }

        public delegate By SearchMethod(string elementId);

        public SearchMethod SearchType{ get; set; }
        public string ElementMethodName { get; set; }
        public string  Value { get; set; }
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


    }
}
