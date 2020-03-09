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
    class TMPage
    {
        public void AddTM(IWebDriver driver)
        {
            //identify Create New element and click on Create New//
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();

            //identify code entity and enter value for code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("987");

            //identify decription element and enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("nine eight seven");

            //identify price per unit element and enter Price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("9.87");


            //identify save element and click on save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //wait
            Thread.Sleep(1000);
            //identify last page go on last page
            driver.FindElement(By.XPath("//*[@title='Go to the last page']")).Click();
            try
            {
                //check the enterd entry is there or not
                //using assertion
                Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[3]")).Text, Is.EqualTo("ning eight seven"));


            }
            catch (Exception ex)
            {
                Console.WriteLine("TM page not displayed", ex.Message);
            }

            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr/td[3]")).Text == "nine eight seven")
            //{
            //    Console.WriteLine("TM created successfuly, test passes");
            //}
            //else
            //{
            //    Console.WriteLine("Test failed");
            //}
        }

        public void EditTM(IWebDriver driver)
        {
            // lines of the code which performs and validates edit test cases

            //wait
            Thread.Sleep(1000);
            // click on Edit
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]")).Click();
            //wait
            Thread.Sleep(3000);
            //clear the existing item for code
            driver.FindElement(By.XPath("//*[@id='Code']")).Clear();

            
            // Edit Code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("Connect");

            //wait
            Thread.Sleep(3000);
            //clear the existing item for description
            driver.FindElement(By.XPath("//*[@id='Description']")).Clear();
            
            // Edit Description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Industry");
            //wait
            Thread.Sleep(3000);

            // click on Save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();
            //wait
            Thread.Sleep(5000);

            //go to selected page and line
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[1]/span")).Click();


            //check if edited entry is there or not
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]")).Text == "Connect")
            {
                Console.WriteLine("TM updated successfuly, Test passes");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

        }
        public void DeleteTM(IWebDriver driver)
        {
            // lines for Delete test cases
            Thread.Sleep(5000);
            //click on Delete
            //wait

            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[10]/td[5]/a[2]")).Click();


            //wait
            Thread.Sleep(3000);
            //Switch to alert and select ok button/accepting alert
            IAlert alert = driver.SwitchTo().Alert();

            alert.Accept();

            //select total no of items
            //wait
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/span[2]"));

            // verify the total no of enteries decreased by 1

        }

    }

}
