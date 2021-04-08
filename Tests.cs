using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
//Use the pageObjects class!
using AutomationPractice.Objects;

namespace AutomationPractice
{
        public class SendMessageTest
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
        {
            //call the pretty pageObjects
            driver.FindElement(pageObjects.inputFullName).SendKeys("test user");
            driver.FindElement(pageObjects.inputEmail).SendKeys("test@test.com");
            driver.FindElement(pageObjects.inputCurrentAddress).SendKeys("this is a test address!");
            driver.FindElement(pageObjects.inputPermanentAddress).SendKeys("this is also a test address!");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
