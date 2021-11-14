
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TurnUpPortalFirstAutomation.Utilities;

namespace TurnUpPortalFirstAutomation.Pages
{
    public class homePage 
    {
        public void navigateTotmPortal(IWebDriver driver)
        {
            
                IWebElement adminTab = driver.FindElement(By.XPath("//a[@class='dropdown-toggle']"));
                adminTab.Click();

                //Wait.waitTobeClickable(driver, "XPath", "//a[contains(@href,'Material')]", 3);

                //Select time&material option from dropdown
                IWebElement timeMaterialOption = driver.FindElement(By.XPath("//a[contains(@href,'Material')]"));
                timeMaterialOption.Click();
            }
        public void goToEmployees(IWebDriver driver)
        {
            //click on Administration tab
            IWebElement adminTab = driver.FindElement(By.XPath("//a[@class='dropdown-toggle']"));
            adminTab.Click();

            //navigate to employees page
            IWebElement EmployeesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EmployeesOption.Click();


        }

    }

    
}
