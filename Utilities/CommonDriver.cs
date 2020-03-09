using ConsoleApp1selenium.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1selenium.Utilities
{
    class CommonDriver
    {
        // initialize webdriver globally
        public IWebDriver driver { set; get; }
        
        [OneTimeSetUp]
        public void StartUpTest()
        {
            //Define driver
            driver = new ChromeDriver(@"C:\Users\saman\Downloads\chromedriver_win32");

            //Create page object for login page and using this object to call the Loginsteps function
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);
        }
        [OneTimeTearDown]
        public void FinishTestRun()
        {
            //close the browser
            driver.Close();
        }
    }
}
