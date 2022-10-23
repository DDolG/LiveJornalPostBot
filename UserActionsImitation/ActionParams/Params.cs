using Newtonsoft.Json;
using OpenQA.Selenium;
using System;

namespace UserActionsImitation.ActionParams
{
    public class Params
    {
        internal string ElementId { get; set; }

        [JsonIgnore]
        internal IWebDriver WebDriver { get; set; }
        
        public delegate By SearchMethod(string elementId);

        internal SearchMethod SearchType { get; set; }

        internal string TextValue { get; set; }

        internal Params(string id, IWebDriver webDriver, SearchMethod searchType, string text)
        {
            ElementId = id;
            WebDriver = webDriver;
            SearchType = searchType;
            TextValue = text;
        }
        
    }
}
