using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Objects
{
    public class textBoxPageObjects
    {
        protected readonly IWebDriver driver;
        public textBoxPageObjects(IWebDriver driver)
        {
            this.driver = driver;  
        }
        public IWebElement inputFullName => driver.FindElement(By.Id("userName"));
        
    }

    public class checkBoxPageObjects
    {
        protected readonly IWebDriver driver;
        public checkBoxPageObjects(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement inputFullName => driver.FindElement(By.Id("userName"));

    }
}
