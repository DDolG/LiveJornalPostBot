using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UserActionsImitation;
using UserActionsImitation.ActionParams;
using UserActionsImitation.UserActions;

namespace LiveJornalPostBot
{
    class Program
    {
        private const string URL                        = "https://www.livejournal.com/";
        private const string DRIVER_NAME                = "ChromeDriver";
        private const string CLASSNAME_BUTTON_LOGIN     = "s-header-item__link--login";
        private const string ELEMENTID_LOGIN_INPUT      = "user";
        private const string USER_LOGIN                 = "syneltest";
        private const string ELEMENTID_PASSWORD_INPUT   = "lj_loginwidget_password";
        private const string USER_PASSWORD              = "123qweASD";
        private const string CLASSNAME_BUTTON_SUBMIT    = "b-loginform-btn--center";
        private const string CLASSNAME_NEW_POST         = "s-header-item-post--long";//"s-header-sub-list-item__link--post";
        
        static void Main(string[] args)
        {

            var settings = new WebDriverSettings() { Url = URL };
            
            string jsonSettings = JsonConvert.SerializeObject(settings);

            var newSettings = JsonConvert.DeserializeObject<WebDriverSettings>(jsonSettings);
            var driver = new ChromeDriver();
            //driver.Url = settings.Url;
                
            var actions = new LinkedList<UserActionAlgoritm>();

            var paramsBuilder = new ActionParamsBuilder();

            var actionOpenLoginForm = new UserActionClick();
            var actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_LOGIN)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionOpenLoginForm.AddUserActionParams(actionParams);
            //actionOpenLoginForm.Execute();
            actions.AddFirst(actionOpenLoginForm);
            /*
            var actionFillPassword = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_PASSWORD_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_PASSWORD);
            actionFillPassword.AddUserActionParams(actionParams);
            actions.AddLast(actionFillPassword);
            //actionFillPassword.Execute();

            var actionFillLogin = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_LOGIN_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_LOGIN);
            actionFillLogin.AddUserActionParams(actionParams);
            //actionFillLogin.Execute();

            var actionLoginFormSubmit = new UserActionSubmit();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_SUBMIT)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionLoginFormSubmit.AddUserActionParams(actionParams);
            //actionLoginFormSubmit.Execute();

            var actionNewPostClick = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_NEW_POST)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionNewPostClick.AddUserActionParams(actionParams);
            //actionNewPostClick.Execute();

            //driver.Navigate().Refresh();
            */
            string jsonActions = JsonConvert.SerializeObject(actions);

            Console.ReadLine();
        }
    }
}
