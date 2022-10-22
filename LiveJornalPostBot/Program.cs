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
        private const string CLASSNAME_NEW_POST = "s-header-item-post--long";//"s-header-sub-list-item__link--post";
        
        static void Main(string[] args)
        {
            //open browser
            IWebDriver driver = new ChromeDriver();

            //load page
            driver.Url= "https://www.livejournal.com/";

            var paramsBuilder = new ActionParamsBuilder();

            var actionOpenLoginForm = new UserActionClick();
            var actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_LOGIN)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionOpenLoginForm.AddUserActionParams(actionParams);
            actionOpenLoginForm.Execute();


            var actionFillPassword = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_PASSWORD_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_PASSWORD);
            actionFillPassword.AddUserActionParams(actionParams);
            actionFillPassword.Execute();

            var actionFillLogin = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_LOGIN_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_LOGIN);
            actionFillLogin.AddUserActionParams(actionParams);
            actionFillLogin.Execute();

            var actionLoginFormSubmit = new UserActionSubmit();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_SUBMIT)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionLoginFormSubmit.AddUserActionParams(actionParams);
            actionLoginFormSubmit.Execute();

            var actionNewPostClick = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_NEW_POST)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionNewPostClick.AddUserActionParams(actionParams);
            actionNewPostClick.Execute();

            driver.Navigate().Refresh();

            Console.ReadLine();
        }
    }
}
