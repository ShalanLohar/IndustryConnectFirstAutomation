using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TurnUpPortalFirstAutomation.Pages;
using TurnUpPortalFirstAutomation.Utilities;

namespace TurnUpPortalFirstAutomation
{
    [TestFixture]
    //[Parallelizable]
    class TM_Test : CommonDriver
    {    
        
        [Test, Order (1)]
        public void CreateTMTests()
        {
            //Homepage object initialization and definition
            homePage homePageobj = new homePage();
            homePageobj.navigateTotmPortal(driver);

            //TMpage object initialization and definition
            TMpage TMpageObj = new TMpage();
            TMpageObj.createNew(driver);

        }

        [Test, Order (2)]
        public void EditTMTest()
        {
            //Homepage object initialization and definition
            homePage homePageobj = new homePage();
            homePageobj.navigateTotmPortal(driver);

            TMpage TMpageObj = new TMpage();
            TMpageObj.editRecord(driver);

        }

        [Test, Order (3)]
        public void DeleteTMTest()
        {
            //Homepage object initialization and definition
            homePage homePageobj = new homePage();
            homePageobj.navigateTotmPortal(driver);

            TMpage TMpageObj = new TMpage();
            TMpageObj.deleteRecord(driver);
        }

        
        


            

        
    }
}
