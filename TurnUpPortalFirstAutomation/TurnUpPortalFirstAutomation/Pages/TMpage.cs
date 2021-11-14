using NUnit.Framework;
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


            // Validate if the record has been created and has the expected values.
            Thread.Sleep(2000);
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            //Add assertions now
            Assert.That(actualCode.Text == "TurnUpPortal 2021", "actual code and expected code do not match.");
            Assert.That(actualTypeCode.Text == "T", "actual Type Code and expected Type Code do not match.");
            Assert.That(actualDescription.Text == "TurnUpPortal 2021", "actual description and expected description do not match.");
            Assert.That(actualPrice.Text == "$25.00", "actual price and expected price do not match.");



            //IWebElement newRecordCreated = driver.FindElement(By.XPath("(//*[text()='TurnUpPortal 2021'])[1]"));
            // 2 option

            //if (newRecordCreated.Text == "TurnUpPortal 2021")
            //{
            //  Assert.Pass("New Record has been created successfully, hence test case is passed");
            //Console.WriteLine("New Record has been created successfully, hence test case is passed");
            //}
            //else
            //{
            //  Assert.Fail("New record did not find hence test case is failed");
            //Console.WriteLine("New record did not find hence test case is failed");
            //}
        }

        public void editRecord(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findRecordCreated.Text == "TurnUpPortal 2021")
            {
                //Click on editButton
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                Thread.Sleep(2000);


                //clear the previous input from codeTextBox (Code repeated here)
                IWebElement editedCodeTextBox = driver.FindElement(By.Id("Code"));
                editedCodeTextBox.Clear();

                // Change the codeTextBox input to ShaAutomation22 (Code repeated here)
                editedCodeTextBox.SendKeys("ShaAutomation22");

                //Edit the description field to ShaAutomation22
                IWebElement editDescriptionField = driver.FindElement(By.XPath("//input[@data-val-required='The Description field is required.']"));
                editDescriptionField.Clear();
                editDescriptionField.SendKeys("ShaAutomation22");


                // Edit pricePerUnitField
                IWebElement priceInputTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
                IWebElement editedPricePerUnit = driver.FindElement(By.Id("Price"));

                priceInputTag.Click();
                editedPricePerUnit.Clear();
                priceInputTag.Click();
                editedPricePerUnit.SendKeys("113");

                //Click on saveButton (Code repeated here)
                IWebElement saveButtons = driver.FindElement(By.Id("SaveButton"));
                saveButtons.Click();
                Thread.Sleep(2000);

                IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
                goToLastPageButton1.Click();
                Thread.Sleep(2000);

                // Find the elements
                IWebElement CreatedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement CreatedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
                IWebElement CreatedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement CreatedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
                //add assertions now

                Assert.That(CreatedCode.Text == "ShaAutomation22", "Code record hasn't been edited hence test case is failed");
                Assert.That(CreatedTypeCode.Text == "T", "Edited Type Code didnot match hence test case is failed");
                Assert.That(CreatedDescription.Text == "ShaAutomation22", "Edited description did not match hence test case is faile");
                Assert.That(CreatedPrice.Text == "$113.00", "Edited Price value did not match hence test case is failed");

                //Wait.waitTobeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 2);
                Thread.Sleep(2000);
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Hence record is not edited");
            }

        }
        public void deleteRecord(IWebDriver driver)
        {
            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (findEditedRecord.Text == "ShaAutomation22")
            {
                //Click on Delete Button
                IWebElement deletButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deletButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();

                //Click on last page of the table again
                IWebElement lastPageButton1 = driver.FindElement(By.XPath("//span[@class='k-icon k-i-seek-e']"));
                lastPageButton1.Click();

                Thread.Sleep(2000);

                IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
                IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

                //New Assertions

                Assert.That(editedCode.Text != "ShaAutomation22", "Edited code record hasn't been deleted");
                Assert.That(editedDescription.Text != "ShaAutomation22", "Edited Description record hasn't been deleted ");
                Assert.That(editedPrice.Text != "$113.00", "Edited price record hasn't been deleted ");

            }
            else
            {
                Assert.Fail("Record to be deleted has'nt been found. Hence record not deleted");
            }
        }


    }
}
