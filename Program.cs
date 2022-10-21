using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LiveJornalPostBot
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url="https://journaldev.com";
            Console.WriteLine("Hello World!");
        }
    }
}
