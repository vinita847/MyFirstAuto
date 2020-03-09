using ConsoleApp1selenium.Pages;
using ConsoleApp1selenium.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp1selenium.StepDefinition
{
    [Binding]
    class CustomerSteps : CommonDriver
    {
        [Given(@"I have logged in TUrnUp Portal")]
        public void GivenIHaveLoggedInTUrnUpPortal()
        {
            //Define driver
            driver = new ChromeDriver(@"C:\Users\saman\Downloads\chromedriver_win32");

            //Create page object for login page and using this object to call the Loginsteps function
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        
        [Given(@"I have selected Customer page")]
        public void GivenIHaveSelectedCustomerPage()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //create new Customer
            custObj.AddCustomer(driver);
        }
        
        [Then(@"I shoud be able to Add new customer with valid data")]
        public void ThenIShoudBeAbleToAddNewCustomerWithValidData()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //create new Customer
            custObj.AddCustomer(driver);
        }
        
        [Then(@"I should be able to Edit customer with valid data")]
        public void ThenIShouldBeAbleToEditCustomerWithValidData()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //Edit Customer
            custObj.EditCustomer(driver);
        }
        
        [Then(@"I should be able to Delete Customer")]
        public void ThenIShouldBeAbleToDeleteCustomer()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //Delete Customer
            custObj.DeleteCustomer(driver);
        }
    }
}
