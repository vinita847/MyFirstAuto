using ConsoleApp1selenium.Pages;
using ConsoleApp1selenium.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1selenium
//Test Condition (in Manual) = TestFixture (in Automation)
//Test Case (in Manual) = Test (in Automation)
{
    class Program
    {

        static void Main(string[] args)
        { }
    }
    [TestFixture, Description("Time and Material Test case")]
    class TimeandMaterialTestSuit : CommonDriver
    {
        [SetUp]
        public void StartUpTest()
        {
            //Define driver
            driver = new ChromeDriver();

            //Create page object for login page and using this object to call the Loginsteps function
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        [Test]
        public void AddNewTMTest()
        {
            //Create page object for HOME PAGE
            HomePage homeObj = new HomePage();
            homeObj.NavigatetoTM(driver);

            //create page object for TM page
            TMPage tmObj = new TMPage();

            //create new TM test case
            tmObj.AddTM(driver);

        }
        [Test]
        public void EditTMTest()
        {
            //Create page object for HOME PAGE
            HomePage homeObj = new HomePage();
            homeObj.NavigatetoTM(driver);

            //create page object for TM page
            TMPage tmObj = new TMPage();

            //Edit TM test cases
            tmObj.EditTM(driver);
        }
        [Test]
        public void DeleteTMTest()
        {
            //Create page object for HOME PAGE
            HomePage homeObj = new HomePage();
            homeObj.NavigatetoTM(driver);

            //create page object for TM page
            TMPage tmObj = new TMPage();

            //Delete TM test case
            tmObj.DeleteTM(driver);
        }
        [TearDown]
        public void FinishTestRun()
        {
            //close the browser
            CommonDriver.driver.Close();
        }
    }
    [TestFixture, Description("Customer Test case")]
    class CustomerTestSuit : CommonDriver
    {
        [SetUp]
        public void StartUpSteps()
        {
            //Define driver
            driver = new ChromeDriver();

            //Create page object for login page and using this object to call the Loginsteps function
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        [Test]
        public void AddNewCustomer()
        {
            //Create page object for HOME PAGE
            HomePage homeObj = new HomePage();
            homeObj.NavigatetoTM(driver);

            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //create new Customer
            custObj.AddCustomerTest();
        }
        [Test]
        public void EditCustomer()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //Edit Customer
            custObj.EditCustomerTest();
        }

        [Test]
        public void DeleteCustomer()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //Delete Customer
            custObj.DeleteCustomerTest();
        }
        [TearDown]
        public void FinishTestRun()
        {
            //close the driver
            CommonDriver.driver.Close();
        }

    }
}



