using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTestTool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sitenin açılıp açılmadığını testi
            IWebDriver driver = new FirefoxDriver(); 
            string link = @"https://www.n11.com/";
            driver.Navigate().GoToUrl(link);

            ////Login Test
            driver.FindElement(By.ClassName("btnSignIn")).Click();
            driver.FindElement(By.Id("email")).SendKeys("yagmurereli@hotmail.com");
            driver.FindElement(By.Id("password")).SendKeys("sadsasd");
            driver.FindElement(By.Id("loginButton")).Click();

        
            
      


    }
}

        }