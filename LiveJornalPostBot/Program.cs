using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UserActionsImitation;

namespace LiveJornalPostBot
{
    class Program
    {
        private const string CLASSNAME_BUTTON_LOGIN = "s-header-item__link--login";

        static void Main(string[] args)
        {
            //open browser
            IWebDriver driver = new ChromeDriver();

            //load page
            driver.Url= "https://www.livejournal.com/";

            var actionOpenLoginForm = new UserActionClick()
            {
                ElementId = CLASSNAME_BUTTON_LOGIN,
                SearchType = By.ClassName,
                WebDriver = driver
            };
            actionOpenLoginForm.Execute();


            Console.ReadLine();
        }
    }
}
