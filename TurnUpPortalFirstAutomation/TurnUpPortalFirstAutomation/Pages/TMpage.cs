using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TurnUpPortalFirstAutomation.Utilities;

namespace TurnUpPortalFirstAutomation.Pages
{
    class TMpage
    {
        public void createNew(IWebDriver driver)
        { //Click on CreateNew button
            IWebElement createNewButton = driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
            createNewButton.Click();

            Wait.waitTobeVisible(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/label", 2);

            // Click on typeCode 
            IWebElement typeCode = driver.FindElement(By.XPath("(//span[@class='k-icon k-i-arrow-s'])[1]"));
            typeCode.Click();
            

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
            //Wait.waitTobeVisible(driver, "XPath", "//span[@class='k-icon k-i-seek-w']", 2);

            //Click on lastPage of the table
            IWebElement lastPageButton = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
            lastPageButton.Click();

            //Wait.waitTobeVisible(driver, "XPath", "(//*[text()='TurnUpPortal 2021'])[1]", 2);
            // Validate if the record has been created and has the expected values.
            Thread.Sleep(2000);
            IWebElement newRecord = driver.FindElement(By.XPath("(//*[text()='TurnUpPortal 2021'])[1]"));
           

            if (newRecord.Text == "TurnUpPortal 2021")
            {
                Console.WriteLine("New Record has been created successfully, hence test case is passed");
            }
            else
            {
                Console.WriteLine("New record did not find hence test case is failed");
            }



        }
        public void editRecord(IWebDriver driver)
        {   // Click on last page of the table again
            IWebElement lastPageButton = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));

            lastPageButton.Click();

            //Click on editButton
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[last()]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            //Wait.waitTobeClickable(driver, "Id", "Code", 2);
            //clear the previous input from codeTextBox (Code repeated here)
            IWebElement coTextBox = driver.FindElement(By.Id("Code"));
            coTextBox.Clear();

            // Change the codeTextBox input to ShaAutomation22 (Code repeated here)
            coTextBox.SendKeys("ShaAutomation22");


            //Click on saveButton (Code repeated here)
            IWebElement saveButtons = driver.FindElement(By.Id("SaveButton"));
            saveButtons.Click();

            //Wait.waitTobeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);



        }
        public void deleteRecord(IWebDriver driver)
        {
            //Wait.waitTobeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);
            Thread.Sleep(2000);

            // Click on last page of the table again (Code repated here
            IWebElement lastPaButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPaButton.Click();

            //Thread.Sleep(2000);
            //Click on Delete Button
           // Wait.waitTobeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]", 2);

            IWebElement deletButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deletButton.Click();


            driver.SwitchTo().Alert().Accept();

            //Click on last page of the table again
            // Wait.waitTobeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]", 2);
            Thread.Sleep(2000);

            IWebElement tableText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (tableText.Text == "ShaAutomation22")
            {
                Console.WriteLine("New record is still not deleted hence test case is failed");
            }
            else
            {
                Console.WriteLine("New record has been successfully deleted, hence test case is passed");
            }
            //driver.Close();
        }

    }
}
