using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace TurnUpPortalFirstAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            //open the chrome Browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            //identify the user name textbox and enter vald username
            IWebElement userName = driver.FindElement(By.XPath("//input[@id='UserName']"));
            userName.SendKeys("hari");
            //identify password testbox and enter valid password
            IWebElement pwdTextbox = driver.FindElement(By.XPath("//input[@id='Password']"));
            pwdTextbox.SendKeys("123123");
            //identify the loginButton and click
            IWebElement loginButton = driver.FindElement(By.XPath("//input[@value='Log in']"));
            loginButton.Click();
            //Validate if user is logged in succesfully
            IWebElement helloHari = driver.FindElement(By.XPath("(//a[@class='dropdown-toggle'])[2]"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User is logged in successfully");
            }
            else
            {
                Console.WriteLine("Test case is failed");
            }

            //click on Administration tab
            IWebElement adminTab = driver.FindElement(By.XPath("//a[@class='dropdown-toggle']"));
            adminTab.Click();
            //Select time&material option from dropdown
            IWebElement timeMaterialOption = driver.FindElement(By.XPath("//a[contains(@href,'Material')]"));
            timeMaterialOption.Click();
            //Click on CreateNew button
            IWebElement createNewButton = driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
            createNewButton.Click();
            // Click on typeCode 
            IWebElement typeCode = driver.FindElement(By.XPath("(//span[@class='k-icon k-i-arrow-s'])[1]"));
            typeCode.Click();
            Thread.Sleep(2000);
            // select time option from typeCode dropdown
            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
                timeOption.Click();
            //Enter code in codeTextBox
            IWebElement codeTextBox = driver.FindElement(By.XPath("//input[@id='Code']"));
            codeTextBox.SendKeys("TurnUpPortal 2021");
            // enter description in descriptionTextBox
            IWebElement descriptionTextBox = driver.FindElement(By.XPath("//input[@id='Description']"));
            descriptionTextBox.SendKeys("TurnUpPortal 2021");
            //enter price in pricePerUnitTextBox
            
            IWebElement pricePerUnitTextBox = driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']"));
            //pricePerUnitTextBox.Click();
            pricePerUnitTextBox.SendKeys("25");
            // Click on SaveButton
            IWebElement saveButton = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            saveButton.Click();
            Thread.Sleep(2000);
            //Click on lastPage of the table
            IWebElement lastPageButton = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            lastPageButton.Click();
            // Validate if the record has been created and has the expected values.
            IWebElement newRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if(newRecord.Text == "TurnUpPortal 2021")
            {
                Console.WriteLine("New Record has been created successfully, hence test case is passed");
            }
            else
            {
                Console.WriteLine("New record did not find hence test case is failed");
            }

            // Click on last page of the table again
            lastPageButton.Click();

            //Click on editButton
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            //clear the previous input from codeTextBox
                IWebElement coTextBox = driver.FindElement(By.Id("Code"));
                 coTextBox.Clear();

            // Change the codeTextBox input to ShaAutomation22
            coTextBox.SendKeys("ShaAutomation22");


            //Click on saveButton
            IWebElement saveButtons = driver.FindElement(By.Id("SaveButton"));
            saveButtons.Click();
            Thread.Sleep(2000);

            // Click on last page of the table again
            IWebElement lastPaButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPaButton.Click();

            //Thread.Sleep(2000);
            //Click on Delete Button
            IWebElement deletButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[last()]/a[last()]"));
            deletButton.Click();


            driver.SwitchTo().Alert().Accept();





















        }
    }
}
