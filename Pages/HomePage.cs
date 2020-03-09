using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1selenium.Pages
{
    class HomePage
    {
        public void NavigatetoTM(IWebDriver driver)
        {
            //identify Admininstrator element and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //identify Time & Material element and click on Time & Material//
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();
        }

        public void NavigatetoCustomer(IWebDriver driver)
        {
            //identify Admininstrator element and click
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            //wait
            Thread.Sleep(5000);
            //click on customer
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[1]/a")).Click();

        }
    }
}
