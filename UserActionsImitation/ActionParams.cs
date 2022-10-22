using OpenQA.Selenium;

namespace UserActionsImitation
{
    public class ActionParams
    {
        internal string ElementId { get; set; }

        internal IWebDriver WebDriver { get; set; }

        public delegate By SearchMethod(string elementId);

        internal SearchMethod SearchType { get; set; }

        internal string TextValue { get; set; }

        public ActionParams(string id, IWebDriver webDriver, SearchMethod searchType, string text)
        {
            ElementId = id;
            WebDriver = webDriver;
            SearchType = searchType;
            TextValue = text;
        }
        
    }
}
