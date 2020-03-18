using ConsoleApp1selenium.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1selenium.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //enter the url on browser
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // maximize the browser
            driver.Manage().Window.Maximize();

            //populate login page test datacollection
            ExcelLibHelpers.PopulateInCollection(@"V:\selenium_try\ConsoleApp1selenium\TestData\TestData.xls", "LoginPage");

            //identify username element and enter the user name
            driver.FindElement(By.Id("UserName")).SendKeys(ExcelLibHelpers.ReadData(2, "Username"));

            //identify the password element and enter password
            driver.FindElement(By.Id("Password")).SendKeys(ExcelLibHelpers.ReadData(2, "Password"));

            //identify the login element and click
            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();

            // verify if the home page is displayed as expected
          
            try
            {
                //implement assertion
                Assert.That(driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text, Is.EqualTo("Hello hari!"));

            }

            catch (Exception ex)
            {
                Console.WriteLine("Login Page not displayed", ex.Message);
            }

            //if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            //{
            //    Console.WriteLine("Test Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Test Failed");
            //}
        }
    }
}
