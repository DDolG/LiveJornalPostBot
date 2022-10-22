using OpenQA.Selenium;

namespace UserActionsImitation
{
    public class ActionParamsBuilder
    {
        private string ElementId { get; set; }

        private IWebDriver WebDriver { get; set; }

        public delegate By SearchMethod(string elementId);

        private SearchMethod SearchType { get; set; }

        private string TextValue { get; set; }

        public ActionParamsBuilder CreateElement(string id)
        {
            this.ElementId = id;
            return this;
        }

        public ActionParamsBuilder AddWebDriver(IWebDriver driver)
        {
            this.WebDriver = driver;
            return this;
        }

        public ActionParamsBuilder SearchElementMethod(SearchMethod searchMethod)
        {
            this.SearchType = searchMethod;
            return this;
        }

        public ActionParamsBuilder AddTextValue(string text)
        {
            this.TextValue = text;
            return this;
        }
    }
}
