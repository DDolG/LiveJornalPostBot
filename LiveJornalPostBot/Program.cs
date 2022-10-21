using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UserActionsImitation;

namespace LiveJornalPostBot
{
    class Program
    {
        private const string CLASSNAME_BUTTON_LOGIN     = "s-header-item__link--login";
        private const string ELEMENTID_LOGIN_INPUT      = "user";
        private const string USER_LOGIN                 = "syneltest";
        private const string ELEMENTID_PASSWORD_INPUT   = "lj_loginwidget_password";
        private const string USER_PASSWORD              = "123qweASD";
        private const string CLASSNAME_BUTTON_SUBMIT    = "b-loginform-btn--center";
        
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

            var actionFillPassword = new UserActionFillTextBox()
            {
                ElementId = ELEMENTID_PASSWORD_INPUT,
                SearchType = By.Id,
                WebDriver = driver,
                TextValue = USER_PASSWORD
            };
            actionFillPassword.Execute();

            var actionFillLogin = new UserActionFillTextBox()
            {
                ElementId = ELEMENTID_LOGIN_INPUT,
                SearchType = By.Id,
                WebDriver = driver,
                TextValue = USER_LOGIN
            };
            actionFillLogin.Execute();

            var actionLoginFormSubmit = new UserActionSubmit()
            {
                ElementId = CLASSNAME_BUTTON_SUBMIT,
                SearchType = By.ClassName,
                WebDriver = driver
            };
            actionLoginFormSubmit.Execute();

            Console.ReadLine();
        }
    }
}
