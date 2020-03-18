using ConsoleApp1selenium.Pages;
using ConsoleApp1selenium.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp1selenium.StepDefinition
{
    [Binding]
    class TimeandMaterialSteps : CommonDriver
    {
       
        [Given(@"I have logged in TurnUp Portal")]
        public void GivenIHaveLoggedInTurnUpPortal()
        {
            //Define driver
            driver = new ChromeDriver(@"C:\Users\saman\Downloads\chromedriver_win32");

            //Create page object for login page and using this object to call the Loginsteps function
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        
        [Given(@"I have selected Time and Material page")]
        public void GivenIHaveSelectedTimeAndMaterialPage()
        {
            //Create page object for HOME PAGE
            HomePage homeObj = new HomePage();
            homeObj.NavigatetoTM(driver);
        }
        
        //[Given(@"I have mac system")]
        //public void GivenIHaveMacSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to Time and Material page on mac system")]
        //public void GivenINavigateToTimeAndMaterialPageOnMacSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I have UNIX system")]
        //public void GivenIHaveUNIXSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to Time and Material page on UNIX system")]
        //public void GivenINavigateToTimeAndMaterialPageOnUNIXSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I have windows system")]
        //public void GivenIHaveWindowsSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to Time and Material page on windows system")]
        //public void GivenINavigateToTimeAndMaterialPageOnWindowsSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to Time and Material page on Android moblie")]
        //public void GivenINavigateToTimeAndMaterialPageOnAndroidMoblie()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I have an Android mobile device")]
        //public void GivenIHaveAnAndroidMobileDevice()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Given(@"I navigate to Time and Material page on IOS mobile")]
        //public void GivenINavigateToTimeAndMaterialPageOnIOSMobile()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        [Then(@"I should be able to add new Time and Material entry with valid data")]
        public void ThenIShouldBeAbleToAddNewTimeAndMaterialEntryWithValidData()
        {
            //create page object for TM page
            TMPage tmObj = new TMPage();

            //create new TM test case
            tmObj.AddTM(driver);
        }
        
        [Then(@"I should be able to Edit Time and Material entry with valid data")]
        public void ThenIShouldBeAbleToEditTimeAndMaterialEntryWithValidData()
        {
            //create page object for TM page
            TMPage tmObj = new TMPage();

            //Edit TM test cases
            tmObj.EditTM(driver);
        }
        
        [Then(@"I should be able to Delete Time and Material entry with valid data")]
        public void ThenIShouldBeAbleToDeleteTimeAndMaterialEntryWithValidData()
        {
            //create page object for TM page
            TMPage tmObj = new TMPage();

            //Delete TM test case
            tmObj.DeleteTM(driver);
        }
        
        //[Then(@"I should not be able to add new Time and Material entry with invalid data")]
        //public void ThenIShouldNotBeAbleToAddNewTimeAndMaterialEntryWithInvalidData()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"I should not be able to Edit Time and Material entry with invalid data")]
        //public void ThenIShouldNotBeAbleToEditTimeAndMaterialEntryWithInvalidData()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"The layout of the page should be expected for all Add, Edit and Delete functionalities")]
        //public void ThenTheLayoutOfThePageShouldBeExpectedForAllAddEditAndDeleteFunctionalities()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"I should be able to perform pagination function for pages as expected")]
        //public void ThenIShouldBeAbleToPerformPaginationFunctionForPagesAsExpected()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"I should be able to click on refresh and perform the action")]
        //public void ThenIShouldBeAbleToClickOnRefreshAndPerformTheAction()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"I should be able to perfoem Table headers icon for ascending and descending")]
        //public void ThenIShouldBeAbleToPerfoemTableHeadersIconForAscendingAndDescending()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"Time and Material page should work perfectly on mac system")]
        //public void ThenTimeAndMaterialPageShouldWorkPerfectlyOnMacSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"Time and Material page should work perfectly on UNIX system")]
        //public void ThenTimeAndMaterialPageShouldWorkPerfectlyOnUNIXSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"Time and Material page should work perfectly on windows system")]
        //public void ThenTimeAndMaterialPageShouldWorkPerfectlyOnWindowsSystem()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"Time and Material page should work perfectly on Anroid mobile")]
        //public void ThenTimeAndMaterialPageShouldWorkPerfectlyOnAnroidMobile()
        //{
        //    ScenarioContext.Current.Pending();
        //}
        
        //[Then(@"The responce of TIme and Material page should be expected")]
        //public void ThenTheResponceOfTImeAndMaterialPageShouldBeExpected()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
