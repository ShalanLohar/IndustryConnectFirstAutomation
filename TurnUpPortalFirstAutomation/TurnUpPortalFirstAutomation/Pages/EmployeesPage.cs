using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TurnUpPortalFirstAutomation.Utilities;

namespace TurnUpPortalFirstAutomation.Pages
{
    class EmployeesPage : CommonDriver
    {          
        public void CreateEmployee(IWebDriver driver)
        { //Click on createEmployee button
            IWebElement createEmployeeButton = driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));
            createEmployeeButton.Click();

            //enter employee name
            IWebElement createEmployeeName = driver.FindElement(By.XPath("//input[@name='Name']"));
            createEmployeeName.SendKeys("Hinduja Global");

            //enter employee username
            IWebElement createEmployeeUsername = driver.FindElement(By.XPath("//input[@id='Username']"));
            createEmployeeUsername.SendKeys("Global123");

            //enter employee Contact number
            IWebElement createEmployeeContact = driver.FindElement(By.XPath("//input[@id='ContactDisplay']"));
            createEmployeeContact.SendKeys("04041234");

            //enter employee password
            IWebElement createEmployeePassword = driver.FindElement(By.XPath("//input[@id='Password']"));
            createEmployeePassword.SendKeys("NewZealand1230@");

            //enter Employee ReType Password
            IWebElement createEmployeeReTypePassword = driver.FindElement(By.XPath("//input[@id='RetypePassword']"));
            createEmployeeReTypePassword.SendKeys("NewZealand1230@");

            //Click on checkbox
            IWebElement clickOnIsAdminCheckbox = driver.FindElement(By.XPath("//input[@class='check-box']"));
            clickOnIsAdminCheckbox.Click();

            //Click on vehicleDropDown
            IWebElement employeeVehicle = driver.FindElement(By.XPath("//input[@name='VehicleId_input']"));
            employeeVehicle.SendKeys("Audi");
            Thread.Sleep(1000);

            //Click on employeeGroup 
           //IWebElement employeeGroup = driver.FindElement(By.XPath("//div[@class='k-widget k-multiselect k-header']"));
            //employeeGroup.Click();
            //Thread.Sleep(1000);
            //employeeGroup.SendKeys(Keys.Enter);                  
            

            //Click on save button
            IWebElement saveButton = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
            saveButton.Click();

            Thread.Sleep(1000);
            //Click on back to List
            IWebElement backToList = driver.FindElement(By.XPath("//*[text()='Back to List']"));
            backToList.Click();
            Thread.Sleep(1000);

            IWebElement goToLastTableButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            goToLastTableButton.Click();

            //Add assertion now
            IWebElement createdEmployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement createdEmployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

            Assert.That(createdEmployeeName.Text == "Hinduja Global", "Created employee name doesn't match. Hence test case is failed");
            Assert.That(createdEmployeeUserName.Text == "Global123", "Created employee username doesn't match. Hence test case is failed");
            Thread.Sleep(2000);
        }

        public void EditEmployee(IWebDriver driver)
        {
            IWebElement recordTobeEdited = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (recordTobeEdited.Text == "Hinduja Global")
            {
                //Click on edit button
                Thread.Sleep(2000);
                IWebElement employeeEdiButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                employeeEdiButton.Click();
                Thread.Sleep(1000);
                //edit employee Name
                IWebElement editEmployeeName = driver.FindElement(By.XPath("//input[@name='Name']"));
                editEmployeeName.Clear();
                editEmployeeName.SendKeys("Global Hinduja");

                Thread.Sleep(1000);
                //edit employee userName
                IWebElement editEmployeeUserName = driver.FindElement(By.XPath("//input[@id='Username']"));
                editEmployeeUserName.Clear();
                editEmployeeUserName.SendKeys("NewWorld@123");

                //edit employee Contact number
                IWebElement editEmployeeContactNum = driver.FindElement(By.XPath("//input[@id='ContactDisplay']"));
                editEmployeeContactNum.Clear();
                editEmployeeContactNum.SendKeys("00900800");

                //edit employee password
                IWebElement editEmployeePassword = driver.FindElement(By.XPath("//input[@id='Password']"));
                editEmployeePassword.Clear();
                editEmployeePassword.SendKeys("NewWorld@1233");

                //edit retype password field
                IWebElement EditreTypePassword = driver.FindElement(By.XPath("//input[@id='RetypePassword']"));
                EditreTypePassword.Clear();
                EditreTypePassword.SendKeys("NewWorld@1233");

                Thread.Sleep(1000);
                //click on Check box
                IWebElement clickOnIsAdminCheckbox = driver.FindElement(By.XPath("//input[@class='check-box']"));
                clickOnIsAdminCheckbox.Click();

                //edit vehicle type
                IWebElement editEmployeeVehicle = driver.FindElement(By.XPath("//input[@name='VehicleId_input']"));
                editEmployeeVehicle.SendKeys("Tesla");

                //Click on save button
                IWebElement saveButton = driver.FindElement(By.XPath("//input[@id='SaveButton']"));
                saveButton.Click();

                Thread.Sleep(1000);
                //Click on back to List
                IWebElement backToList = driver.FindElement(By.XPath("//*[text()='Back to List']"));
                backToList.Click();
                Thread.Sleep(1000);

                //navigate to last page of the table
                IWebElement goToLastTableButton1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
                goToLastTableButton1.Click();

                //now add the assertions.
                IWebElement editedEmployeeName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement editedEmployeeUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

                Assert.That(editedEmployeeName.Text == "Global Hinduja", "Edited employee name hasn't been found. Hence test case is failed");
                Assert.That(editedEmployeeUserName.Text == "NewWorld@123", "Employee username not edited successfully. Hence test case if failed");
            
             
            }
            else
            {
              Assert.Fail("Record to be edited hasn't found. Hence test case create employee failed.");
            }


        }

        public void DeleteEmployee(IWebDriver driver)
        {
            //Add the code for delete employee
            //Go to Last page of the table
            //IWebElement goToLastTableButton1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            //goToLastTableButton1.Click();
            Thread.Sleep(1000);

            IWebElement editedRecordToBeDeleted = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if(editedRecordToBeDeleted.Text == "Global Hinduja")
            {
                //Click on Delete button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                deleteButton.Click();

                driver.SwitchTo().Alert().Accept();

                Thread.Sleep(2000);
                //Now add the assertions
                IWebElement employeeNameDelete = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
                IWebElement employeeUsernameDelete = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));

                Assert.That(employeeNameDelete.Text != "Global Hinduja", "The employee name record hasn't been deleted, hence test case is failed");
                Assert.That(employeeUsernameDelete.Text != "NewWorld@123", "The employee username record hasn't been deleted, hence test case is failed");
            }
            else
            {
                Assert.Fail("Employee record to be deleted hasn't been found, hence skipped to execute the test case");

            }


        }


    }
}
