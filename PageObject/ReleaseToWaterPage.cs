using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ReleaseToWater.Hooks;
using System;

namespace ReleaseToWater.PageObject
{
    class ReleaseToWaterPage
    {
        public IWebDriver driver;
        public ReleaseToWaterPage()
        {
            driver = WebHook.driver;
        }



        private By Modules = By.CssSelector("#main-content > div.headercontainer.she-userrole-Users > div.headercolumn-center > div:nth-child(2) > div > ul > li.she-has-submenu > a");
        private By Username = By.Id("username");
        private By Password = By.Id("password");
        private By LoginButton = By.Id("login");
        private By releaseWater = By.XPath("//*[contains(text(),'Release To Water')]");
        private By newRecordButton = By.XPath("//*[@id='site-wrapper']/section/a");
        private By Description = By.Id("SheReleaseToWater_Description");
        private By saveAndCloseButton = By.XPath("//*[@id='site-wrapper']/section/form/div[4]/div/div/ul/li[3]/button");
        private By recordCreated = By.XPath("//*[@id='site-wrapper']/section/div[4]/div[1]/div[2]");
        private By coqDropDown = By.Id("manageRecord5509555");
        private By coqDelete = By.Id("cogDelete5509555");
        private By confirmButton = By.XPath("//*[@id='full_width']/div[17]/div[3]/div/button[1]");
        private By logoutDropdown = By.XPath("//*[@id='uservoice-activation']/a/div/div");
        private By logoutButton = By.XPath("//*[@id='uservoice-activation']/ul/li[4]/a");

        public void EnterUserName()
        {
            driver.FindElement(Username).SendKeys("JoyB");
        }

        public void EnterPassword()
        {
            driver.FindElement(Password).SendKeys("67*GG");
        }

        public void ClickLoginButton()
        {
            driver.FindElement(LoginButton).Click();
        }

        public void clickModules()
        {
            driver.FindElement(Modules).Click();
        }

        public void EnvironmentMouseHover()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(),'Environment')]")));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            //Waiting for the menu to be displayed    
            System.Threading.Thread.Sleep(4000);
        }

        public void ReleaseWater()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.FindElement(releaseWater).Click();





        }

        public void ClickNewRecord()
        {
            driver.FindElement(newRecordButton).Click();
        }

        public void EnterDescription()
        {
            driver.FindElement(Description).SendKeys("testing release to water");
        }

        public void Date()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebHook.driver;
            js.ExecuteScript("document.getElementById('SheReleaseToWater_SampleDate').value='30/07/2021'");
        }

        public void ClickSaveAndClose()
        {
            driver.FindElement(saveAndCloseButton).Click();
        }

        public bool AssertRecordisCreated()
        {
            return driver.FindElement(recordCreated).Displayed;
        }

        public void EnterDescriptions()
        {
            driver.FindElement(Description).SendKeys("testing release2");
        }

        public void EnterDate()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)WebHook.driver;
            js.ExecuteScript("document.getElementById('SheReleaseToWater_SampleDate').value='30/08/2021'");
        }

        public void ClickCoqDropDown()
        {
            driver.FindElement(coqDropDown).Click();
        }

        public void ClickDelete()
        {
            driver.FindElement(coqDelete).Click();
        }


        public void ConfirmDelete()
        {
            driver.FindElement(confirmButton).Click();
        }


        public void clicklogoutDropdown()
        {
            driver.FindElement(logoutDropdown).Click();
        }

        public void clicklogoutButton()
        {
            driver.FindElement(logoutButton).Click();
        }

    }


}