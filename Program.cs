using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            //open the chrome browser//
            IWebDriver driver = new ChromeDriver(@"C:\Users\saman\Downloads\chromedriver_win32\");

            //enter the url on browser//
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // maximize the browser
            driver.Manage().Window.Maximize();

            //identify username element and enter the user name//
            driver.FindElement(By.Id("UserName")).SendKeys("hari");

            //identify the password element and enter password//
            driver.FindElement(By.Id("Password")).SendKeys("123123");

            //identify the login element and click on//

            driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]")).Click();
                      

            // verify if the home page is displayed as expected
            if (driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a")).Text == "Hello hari!")
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            //identify Admininstrator element and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //identify Time & Material element and click on Time & Material//
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();


            //identify Create New element and click on Create New//
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();



            //identify code entity and enter value for code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("111");


            //identify decription element and enter description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Three times One");

            //identify price per unit element and enter Price per unit
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).SendKeys("11.1");

            //identify save element and click on save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();


            //wait
            Thread.Sleep(1000);
            //identify last page or previous pages no and go on last page previous pages
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[4]/span")).Click();

            
            //check the enterd entry is there or not
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[6]/td[1]")).Text == "111")
            {
                Console.WriteLine("TM created successfuly, test passes");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            // FOR EDIT
            //click on admin
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //select and click on Time & Material
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

            //wait
            Thread.Sleep(1000);
                       
            // click on Edit
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[5]/a[1]")).Click();


            // Edit Code
            driver.FindElement(By.XPath("//*[@id='Code']")).SendKeys("11.9");


            // Edit Description
            driver.FindElement(By.XPath("//*[@id='Description']")).SendKeys("Eleven pont nine");


            // click on Save
            driver.FindElement(By.XPath("//*[@id='SaveButton']")).Click();

            //go to selected page and line
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/ul/li[4]/span")).Click();

            
            //check if edited entry is there or not
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[7]/td[1]")).Text == "11.9")
            {
                Console.WriteLine("TM updated successfuly, Test passes");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

            // FOR DELETE

            //click on Administration
            driver.FindElement(By.XPath("")).Click();


            //click on time & Material
            driver.FindElement(By.XPath("")).Click();

            //select Delete and click
            driver.FindElement(By.XPath("")).Click();

            //click on ok and confirm
            driver.FindElement(By.XPath("")).Click();

            //verify the line is removed from list
            if (driver.FindElement(By.XPath("")).Text == "")
            {
                Console.WriteLine("Line deleted, Test Passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }

        }

    }



}


