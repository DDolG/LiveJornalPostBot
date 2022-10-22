using OpenQA.Selenium;

namespace UserActionsImitation.ActionParams
{
    public class ActionParamsBuilder
    {
        private string ElementId { get; set; }

        private IWebDriver WebDriver { get; set; }

        private Params.SearchMethod SearchType { get; set; }

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

        public ActionParamsBuilder AddSearchMethod(Params.SearchMethod searchMethod)
        {
            this.SearchType = searchMethod;
            return this;
        }

        public ActionParamsBuilder AddTextValue(string text)
        {
            this.TextValue = text;
            return this;
        }

        public static implicit operator Params(ActionParamsBuilder actionParamsBuilder)
        {
            return new Params(actionParamsBuilder.ElementId, 
                              actionParamsBuilder.WebDriver, 
                              actionParamsBuilder.SearchType, 
                              actionParamsBuilder.TextValue);
        }
    }
}
