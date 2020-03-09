using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1selenium.Pages
{
    class CustomerPage
    {
        public void AddCustomer(IWebDriver driver)
        {
            //lines of code for Adding customer
           
            //click on create new
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //Enter Name
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("samanv");

            //Edit contact
            driver.FindElement(By.XPath("//*[@id='EditContactButton']")).Click();

            //Switching to Alert
            driver.SwitchTo().Alert();
            //..........

            //enter First Name
            driver.FindElement(By.XPath("//*[@id='FirstName']")).SendKeys("Vinita");
            //last name
            driver.FindElement(By.XPath("//*[@id='LastName']")).SendKeys("san");
            //phone no
            driver.FindElement(By.XPath("//*[@id='phone']")).SendKeys("0215654565");
            //click on email
            driver.FindElement(By.XPath("//*[@id='email']")).SendKeys("samanv@yahoo.com");
            
           
            //save contact
            driver.FindElement(By.XPath("//*[@id='ContactEditForm']/div[1]/div[4]/div[1]/input]")).Click();

            //exit alert 
            
            //click on check box
            driver.FindElement(By.XPath("//*[@id='IsSameContact']")).Click();

            //save contact
            driver.FindElement(By.XPath("//*[@id='ClientEditForm']/div[1]/div[6]/div[1]/input")).Click();
           
            //go on administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();
           
            //click on customer
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

            //go on last page
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[4]/a[4]/span")).Click();

            //check the enterd entry is there or not
            //using assertion
            Assert.That(driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[10]/td[2]")).Text, Is.EqualTo("samanv"));
            


            //if (driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[10]/td[2]")).Text == "samanv")
            //{
            //    Console.WriteLine("New Customer created successfuly, test passes");
            //}
            //else
            //{
            //    Console.WriteLine("Test failed");
            //}
        }

        public void EditCustomer(IWebDriver driver)
        {
            //lines for Edit customer
            
            //click on edit
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[1]/td[4]/a[1]")).Click();

            //handel alert
            driver.SwitchTo().Alert();

            //wait
            Thread.Sleep(5000);

            //clear existing name
            driver.FindElement(By.XPath("//*[@id='Name']")).Clear();

            //enter name
            driver.FindElement(By.XPath("//*[@id='Name']")).SendKeys("RomaJ");

            //save
            driver.FindElement(By.XPath("//*[@id='submitButton']")).Click();

            //verify the result
            if (driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[1]/td[2]")).Text == "RomaJ")
            {
                Console.WriteLine("Customer updated successfuly, Test passes");
            }
            else
            {
                Console.WriteLine("Test failed");
            }


        }
        public void DeleteCustomer(IWebDriver driver)
        {
            //lines for delete customer
          
            //click on delete
            driver.FindElement(By.XPath("//*[@id='clientsGrid']/div[2]/table/tbody/tr[10]/td[4]/a[2]")).Click();

            //handel alert and accept
            driver.SwitchTo().Alert().Accept();

            //verify the result
            //
        }

    }
}
