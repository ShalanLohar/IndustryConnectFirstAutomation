using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TurnUpPortalFirstAutomation.Pages;

namespace TurnUpPortalFirstAutomation.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        //open the chrome Browser

        [OneTimeSetUp]

        public void LoginActions()
        {
            
            driver = new ChromeDriver();
            //LoginPage object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginSteps(driver);

            
        }

        [OneTimeTearDown]

        [TearDown]
        public void closeTestRun()
        {
           // driver.Quit();
        }




    }
}
