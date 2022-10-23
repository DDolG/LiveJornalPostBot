using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using UserActionsImitation.ActionParams;
using UserActionsImitation.UserActions;

namespace LiveJornalPostBot
{
    public class WiktionaryActions
    {
        private static WiktionaryActions instance;

        private WiktionaryActions()
        {
        }

        public static WiktionaryActions GetIntance()
        {
            if (instance is null)
            {
                instance = new WiktionaryActions();
            }

            return instance;
        }

        public IEnumerable<UserActionBase> GetLiveJournalActions(IWebDriver driver)
        {           
            driver.Url = URL;

            var actions = new List<UserActionBase>();
            var paramsBuilder = new ActionParamsBuilder();
            var actionOpenLoginForm = new UserActionClick();
            var actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_LOGIN)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver);
            actionOpenLoginForm.AddUserActionParams(actionParams);
            actions.Add(actionOpenLoginForm);

            var actionFillLogin = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_LOGIN_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_LOGIN);
            actionFillLogin.AddUserActionParams(actionParams);
            actions.Add(actionFillLogin);

            var actionFillPassword = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ELEMENTID_PASSWORD_INPUT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(USER_PASSWORD);
            actionFillPassword.AddUserActionParams(actionParams);
            actions.Add(actionFillPassword);

            var actionLoginFormSubmit = new UserActionSubmit();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_BUTTON_SUBMIT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver);
            actionLoginFormSubmit.AddUserActionParams(actionParams);
            actions.Add(actionLoginFormSubmit);

            var actionNewPostClick = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_NEW_LETTER)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionNewPostClick.AddUserActionParams(actionParams);
            actions.Add(actionNewPostClick);

            var actionClearLetterSubject = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_NEW_LETTER)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver);
            actionClearLetterSubject.AddUserActionParams(actionParams);
            actions.Add(actionNewPostClick);

            return actions;
        }

        private const string URL = "https://ru.wiktionary.org/";
        private const string CLASSNAME_BUTTON_LOGIN = "pt-login";
        private const string ELEMENTID_LOGIN_INPUT  = "wpName1";
        private const string USER_LOGIN             = "Syneltest";
        private const string ELEMENTID_PASSWORD_INPUT   = "wpPassword1";
        private const string USER_PASSWORD          = "123qweASDsyneltest";
        private const string CLASSNAME_BUTTON_SUBMIT    = "wpLoginAttempt";
        private const string CLASSNAME_NEW_LETTER   = "t-emailuser";
        private const string ID_LETTER_SUBJECT      = "ooui-php-4";
        private const string VALUE_LETTER_SUBJECT   = "To Gosha";
        private const string ID_MESSAGE             = "ooui-php-5";
        private const string VALUE_MESSGE           = "I see trees of green Red roses too I see them bloom For me and you";
        private const string CLASS_SEND_MESSAGE_SUBMIT = "oo-ui-labelElement-label";
        private const string ID_BUTTON_NEWMESSAGE   = "pt-talk-alert";
    }
}
