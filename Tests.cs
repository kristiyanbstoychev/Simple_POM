using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using AutomationPractice.Objects;

namespace AutomationPractice
{
        public class textBoxTests
    {
        IWebDriver driver;   

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
        }

        [Test]
        public void SendMessage()
        {   //setup driver for the test
            var textBoxPageDriver = new textBoxPageObjects(driver);
            textBoxPageDriver.inputFullName.SendKeys("dasdsa");

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
