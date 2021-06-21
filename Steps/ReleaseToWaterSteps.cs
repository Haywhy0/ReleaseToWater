using FluentAssertions;
using OpenQA.Selenium;
using ReleaseToWater.Hooks;
using ReleaseToWater.PageObject;
using System;
using TechTalk.SpecFlow;

namespace ReleaseToWater.Steps
{

    
    [Binding]
    public class ReleaseToWaterSteps
    {

        public IWebDriver driver = WebHook.driver;
        ReleaseToWaterPage _releaseToWaterPage = new ReleaseToWaterPage();

        [Given(@"I navigate to https://stirling\.she-development\.net/automation")]
        public void GivenINavigateToHttpsStirling_She_Development_NetAutomation()
        {
            driver.Navigate().GoToUrl("https://stirling.she-development.net/automation");
        }

        [Given(@"I logged in to application")]
        public void GivenILoggedInToApplication()
        {
            _releaseToWaterPage.EnterUserName();
            _releaseToWaterPage.EnterPassword();
            _releaseToWaterPage.ClickLoginButton();

        }

        [When(@"I click on modules dropdown")]
        public void WhenIClickOnModulesDropdown()
        {
            _releaseToWaterPage.clickModules();
        }
        
        [When(@"Select Environment")]
        public void WhenSelectEnvironment()
        {
            _releaseToWaterPage.EnvironmentMouseHover();
        }
        
        [When(@"select Release to water")]
        public void WhenSelectReleaseToWater()
        {
            _releaseToWaterPage.ReleaseWater();
        }
        
        [When(@"I click on new record button")]
        public void WhenIClickOnNewRecordButton()
        {
            _releaseToWaterPage.ClickNewRecord();
        }

        [When(@"I fill the description fields")]
        public void WhenIFillTheDescriptionFields()
        {
            _releaseToWaterPage.EnterDescription();
        }


        [When(@"I fill the sample date")]
        public void WhenIFillTheSampleDate()
        {
            _releaseToWaterPage.Date();
        }
        
        [When(@"I click save and close button")]
        public void WhenIClickSaveAndCloseButton()
        {
            _releaseToWaterPage.ClickSaveAndClose();
        }

        [Then(@"A new record is sucessfully created")]
        public void ThenANewRecordIsSucessfullyCreated()
        {
            _releaseToWaterPage.AssertRecordisCreated().Should().BeTrue();
        }

        [When(@"I fill the description field")]
        public void WhenIFillTheDescriptionField()
        {
            _releaseToWaterPage.EnterDescriptions();
        }

        [When(@"I enter the sample date")]
        public void WhenIEnterTheSampleDate()
        {
            _releaseToWaterPage.EnterDate();
        }



        [When(@"I click on coqdropdown record(.*)")]
        public void WhenIClickOnCoqdropdownRecord(int p0)
        {
           _releaseToWaterPage.ClickCoqDropDown();
        }


        [When(@"I click on delete")]
        public void WhenIClickOnDelete()
        {
            _releaseToWaterPage.ClickDelete();
        }



        [When(@"I click on confirm Button")]
        public void WhenIClickOnConfirmButton()
        {
            _releaseToWaterPage.ConfirmDelete();
        }

        [Then(@"I Logout")]
        public void ThenILogout()
        {
            _releaseToWaterPage.clicklogoutDropdown();
            _releaseToWaterPage.clicklogoutButton();


        }


    }
}
