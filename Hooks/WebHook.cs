using DocumentFormat.OpenXml.Spreadsheet;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ReleaseToWater.Hooks
{
    [Binding]
    public static class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public static void AfterScenario()
        {
            driver.Quit();
        }
    }
}
