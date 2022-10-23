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

        public IEnumerable<UserActionTemplate> GetLiveJournalActions(IWebDriver driver)
        {           
            driver.Url = URL;

            var actions = new List<UserActionTemplate>();
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

            var actionUserProfileClick = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(ID_USER_PROFILE)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver);
            actionUserProfileClick.AddUserActionParams(actionParams);
            actions.Add(actionUserProfileClick);

            var actionNewEmailClick = new UserActionClick();
            actionParams = paramsBuilder
                .AddElementId(CLASSNAME_NEW_LETTER)
                .AddSearchMethod(By.XPath)
                .AddWebDriver(driver);
            actionNewEmailClick.AddUserActionParams(actionParams);
            actions.Add(actionNewEmailClick);
            
            var actionClearLetterSubject = new UserActionClear();
            actionParams = paramsBuilder
                .AddElementId(ID_LETTER_SUBJECT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver);
            actionClearLetterSubject.AddUserActionParams(actionParams);
            actions.Add(actionClearLetterSubject);

            var actionFillLetterMessage = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ID_MESSAGE)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(VALUE_MESSGE);
            actionFillLetterMessage.AddUserActionParams(actionParams);
            actions.Add(actionFillLetterMessage);

            var actionFillLetterSubject = new UserActionFillTextBox();
            actionParams = paramsBuilder
                .AddElementId(ID_LETTER_SUBJECT)
                .AddSearchMethod(By.Id)
                .AddWebDriver(driver)
                .AddTextValue(VALUE_LETTER_SUBJECT);
            actionFillLetterSubject.AddUserActionParams(actionParams);
            actions.Add(actionFillLetterSubject);
            
            var actionSubmitSendMessage = new UserActionSubmit();
            actionParams = paramsBuilder
                .AddElementId(CLASS_SEND_MESSAGE_SUBMIT)
                .AddSearchMethod(By.ClassName)
                .AddWebDriver(driver)
                .AddTextValue(VALUE_MESSGE);
            actionSubmitSendMessage.AddUserActionParams(actionParams);
            actions.Add(actionSubmitSendMessage);
            
            return actions;
        }

        private const string URL                        = "https://ru.wiktionary.org/";
        private const string CLASSNAME_BUTTON_LOGIN     = "pt-login";
        private const string ELEMENTID_LOGIN_INPUT      = "wpName1";
        private const string USER_LOGIN                 = "Syneltest";
        private const string ELEMENTID_PASSWORD_INPUT   = "wpPassword1";
        private const string USER_PASSWORD              = "123qweASDsyneltest";
        private const string CLASSNAME_BUTTON_SUBMIT    = "wpLoginAttempt";
        private const string ID_USER_PROFILE            = "pt-userpage";
        private const string CLASSNAME_NEW_LETTER       = "/html[@class='client-js ve-not-available']/body[@class='skin-vector-legacy mediawiki ltr sitedir-ltr mw-hide-empty-elt ns-2 ns-subject mw-editable page-Участник_Syneltest rootpage-Участник_Syneltest skin-vector action-view vector-feature-language-in-header-enabled vector-feature-language-in-main-page-header-disabled vector-feature-language-alert-in-sidebar-enabled vector-feature-sticky-header-enabled vector-feature-sticky-header-edit-disabled vector-feature-table-of-contents-legacy-toc-disabled vector-feature-visual-enhancement-next-disabled vector-feature-article-tools-disabled']/div[@id='mw-navigation']/div[@id='mw-panel']/nav[@id='p-tb']/div[@class='vector-menu-content']/ul[@class='vector-menu-content-list']/li[@id='t-emailuser']/a/span";
        private const string ID_LETTER_SUBJECT          = "ooui-php-4";
        private const string VALUE_LETTER_SUBJECT       = "To Gosha";
        private const string ID_MESSAGE                 = "ooui-php-5";
        private const string VALUE_MESSGE               = "I see trees of green Red roses too I see them bloom For me and you";
        private const string CLASS_SEND_MESSAGE_SUBMIT  = "oo-ui-labelElement-label";
    }
}
