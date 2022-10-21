using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LiveJornalPostBot
{
    class Program
    {
        private const string XPATH_LOGIN_BUTTON = "/html[@id='no-js']/body[@class='"
        + "s-schemius logged-out"
        +  "body--header-v5"
        + "']/div[@class='"
        + "s-layout"
        + "body-content"
        + "s-logged-out"
        + "']/header[@class='"
        + "s-header"
        + "s-header--notown-journal"
        + "s-header--nocyr"
        + "s-header--logged-out"
        + "']/div[@class='s-header-in clearfix']/nav[@class='s-nav-actions']/ul[@class='s-do']/li[@class='"
        + "s-nav-item"
        + "s-nav-item-login"
        + "s-header-item"
        + "s-header-item--right"
        + "']/a[@class='s-header-item__link s-header-item__link--login']";

        private const string CLASSNAME_BUTTON_LOGIN = "s-header-item__link--login";

        static void Main(string[] args)
        {
            //open browser
            IWebDriver driver = new ChromeDriver();

            //load page
            driver.Url= "https://www.livejournal.com/";

            IWebElement element = null;

            //search element
            try
            {
                element = driver.FindElement(By.ClassName(CLASSNAME_BUTTON_LOGIN));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //click element
            try
            {
                element.Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

           
            Console.ReadLine();
        }
    }
}
