using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace WebDriverTest
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup() 
        {            
            driver.Navigate().GoToUrl("https://www.telerik.com/");
        }
        [Test]
        public void TestAssertTitle()
        {
           
            string pageTitle = driver.Title;
            Assert.AreEqual("Telerik & Kendo UI - .NET Components Suites & JavaScript UI Libraries", pageTitle);
           
        }
        [Test]
        public void TestClickLoginButton()
        {

            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//*[@id=\"js-tlrk-nav-not-auth-container\"]/a")).Click();

        }
        [TearDown]
        public void Close() 
        {
            driver.Close();
        }
    }
}
