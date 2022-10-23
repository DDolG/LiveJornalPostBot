using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UserActionsImitation.ActionParams;
using UserActionsImitation.UserActions;

namespace LiveJornalPostBot
{
    class Program
    {   
        static void Main(string[] args)
        {

            var driver = new ChromeDriver();
            var wikipediaActions = WiktionaryActions.GetIntance();
            var actions = wikipediaActions.GetLiveJournalActions(driver).ToList();
            actions.ForEach(x => x.Execute());

            Console.ReadLine();
            driver.Close();
        }
    }
}
