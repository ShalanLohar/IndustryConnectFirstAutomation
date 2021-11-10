using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TurnUpPortalFirstAutomation.Pages;

namespace TurnUpPortalFirstAutomation
{
    class TM_Test
    {
        static void Main(string[] args)
        {
            //open the chrome Browser
            IWebDriver driver = new ChromeDriver();

            //LoginPage object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.loginSteps(driver);

            //Homepage object initialization and definition
            homePage homePageobj = new homePage();
            homePageobj.navigateTotmPortal(driver);

            //TMpage object initialization and definition
            TMpage TMpageObj = new TMpage();
            TMpageObj.createNew(driver);

            TMpageObj.editRecord(driver);

            TMpageObj.deleteRecord(driver);





















        }
    }
}
