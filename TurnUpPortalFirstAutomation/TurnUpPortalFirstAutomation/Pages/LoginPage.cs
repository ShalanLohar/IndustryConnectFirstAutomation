
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TurnUpPortalFirstAutomation.Utilities;

namespace TurnUpPortalFirstAutomation.Pages
{
    class LoginPage
    {
        public void loginSteps(IWebDriver driver)

        {
            //maximize the browser
            driver.Manage().Window.Maximize();
            //launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //identify the user name textbox and enter vald username
            IWebElement userName = driver.FindElement(By.XPath("//input[@id='UserName']"));
            userName.SendKeys("hari");

            Wait.waitTobeVisible(driver, "XPath", "//input[@id='Password']", 3);

            //identify password testbox and enter valid password
            IWebElement pwdTextbox = driver.FindElement(By.XPath("//input[@id='Password']"));
            pwdTextbox.SendKeys("123123");
            //identify the loginButton and click
            IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Log in']"));
            loginButton.Click();
        }
    }
}
