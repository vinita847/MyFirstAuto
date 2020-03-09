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
    [Parallelizable]
    class TimeandMaterialTestSuit : CommonDriver
    {
        
        [Test, Description("Check if user is able to add new TM Record with valid data")]
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
        [Test, Description("Check user is able to Edit Existing TM Record with valid data")]
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
        [Test, Description("Check user is able to Delete Existing TM Record")]
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
        
    }
    
    [TestFixture, Description("Customer Test case")]
    [Parallelizable]
    class CustomerTestSuit : CommonDriver
    {
      
        [Test]
        public void AddNewCustomer()
        {
            //Create page object for HOME PAGE
            HomePage homeObj = new HomePage();
            homeObj.NavigatetoCustomer(driver);

            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //create new Customer
            custObj.AddCustomer(driver);
        }
        [Test]
        public void EditCustomer()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //Edit Customer
            custObj.EditCustomer(driver);
        }

        [Test]
        public void DeleteCustomer()
        {
            //object for customer page
            CustomerPage custObj = new CustomerPage();

            //Delete Customer
            custObj.DeleteCustomer(driver);
        }
        

    }
}



