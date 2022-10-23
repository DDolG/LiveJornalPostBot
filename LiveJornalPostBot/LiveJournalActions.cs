using OpenQA.Selenium;
using System.Collections.Generic;
using UserActionsImitation.ActionParams;
using UserActionsImitation.UserActions;

namespace SeleniumWebTest
{
    public class LiveJournalActions
    {
        private static LiveJournalActions instance;

        private LiveJournalActions()
        {
        }

        public static LiveJournalActions GetIntance()
        {
            if (instance is null)
            {
                instance = new LiveJournalActions();
            }

            return instance;
        }

        public IEnumerable<UserActionTemplate> GetLiveJournalActions(IWebDriver driver)
        {           
            driver.Url = URL;

            var actions = new List<UserActionTemplate>();
            var paramsBuilder = new ActionParamsBuilder();
            var actionOpenLoginForm = new UserActionClick();
            var actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_LOGIN)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionOpenLoginForm.AddUserActionParams(actionParams);
            actions.Add(actionOpenLoginForm);

            var actionFillPassword = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_PASSWORD_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_PASSWORD);
            actionFillPassword.AddUserActionParams(actionParams);
            actions.Add(actionFillPassword);

            var actionFillLogin = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_LOGIN_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_LOGIN);
            actionFillLogin.AddUserActionParams(actionParams);
            actions.Add(actionFillLogin);

            var actionLoginFormSubmit = new UserActionSubmit();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_SUBMIT)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionLoginFormSubmit.AddUserActionParams(actionParams);
            actions.Add(actionLoginFormSubmit);

            var actionNewPostClick = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_NEW_POST)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionNewPostClick.AddUserActionParams(actionParams);
            actions.Add(actionNewPostClick);

            return actions;
        }

        private const string URL = "https://www.livejournal.com/";
        private const string CLASSNAME_BUTTON_LOGIN = "s-header-item__link--login";
        private const string ELEMENTID_LOGIN_INPUT = "user";
        private const string USER_LOGIN = "syneltest";
        private const string ELEMENTID_PASSWORD_INPUT = "lj_loginwidget_password";
        private const string USER_PASSWORD = "123qweASD";
        private const string CLASSNAME_BUTTON_SUBMIT = "b-loginform-btn--center";
        private const string CLASSNAME_NEW_POST = "s-header-item-post--long";
    }
}
