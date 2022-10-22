using OpenQA.Selenium;

namespace UserActionsImitation
{
    public class ActionParamsBuilder
    {
        private string ElementId { get; set; }

        private IWebDriver WebDriver { get; set; }

        private ActionParams.SearchMethod SearchType { get; set; }

        private string TextValue { get; set; }

        public ActionParamsBuilder AddElementId(string id)
        {
            this.ElementId = id;
            return this;
        }

        public ActionParamsBuilder AddWebDriver(IWebDriver driver)
        {
            this.WebDriver = driver;
            return this;
        }

        public ActionParamsBuilder AddSearchMethod(ActionParams.SearchMethod searchMethod)
        {
            this.SearchType = searchMethod;
            return this;
        }

        public ActionParamsBuilder AddTextValue(string text)
        {
            this.TextValue = text;
            return this;
        }

        public static implicit operator ActionParams(ActionParamsBuilder actionParamsBuilder)
        {
            return new ActionParams(actionParamsBuilder.ElementId, 
                                    actionParamsBuilder.WebDriver, 
                                    actionParamsBuilder.SearchType, 
                                    actionParamsBuilder.TextValue);
        }
    }
}
