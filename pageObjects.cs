using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPractice.Objects
{
    public static class pageObjects
    {
        public static By inputFullName = By.Id("userName");
        public static By inputEmail = By.Id("userEmail");
        public static By inputCurrentAddress = By.Id("currentAddress");
        public static By inputPermanentAddress = By.Id("permanentAddress");
        public static By buttonSubmit = By.Id("submit");
    }
}
