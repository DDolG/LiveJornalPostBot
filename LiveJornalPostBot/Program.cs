using System;
using System.Linq;
using OpenQA.Selenium.Chrome;

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
