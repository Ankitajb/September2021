using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TurnUPPortal.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement materialCode = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            materialCode.Click();

            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Test123");

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Test123");

            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            IWebElement pricePerUnitTextbox = driver.FindElement(By.XPath("//*[@id='Price']"));
            pricePerUnitTextbox.SendKeys("50");

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();


            Thread.Sleep(2000);

            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            IWebElement lastRecordText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastRecordText.Text == "Test123")
            {
                Console.WriteLine("Record Created Successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }

        //Edit time
        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(5000);
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            //identify Administration Dropdown list
            IWebElement tCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            tCodeDropdown.Click();

            //Identity Time and material from dropdown list
            IWebElement timeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            tCodeDropdown.Click();

            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("Test1234");

            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("Test1234");

            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(2000);

            IWebElement editLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            editLastPageButton.Click();

            IWebElement lastRecordText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (lastRecordText.Text == "Test1234")
            {
                Console.WriteLine("Record Edited Successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }

        //Delete time
        public void DeleteTM(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();

            driver.SwitchTo().Alert().Accept();
            IWebElement nextLastRecordText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            if (nextLastRecordText.Text != "Test1234")
            {
                Console.WriteLine("Record Deleted Successfully, Test Paased");
            }
            else
            {
                Console.WriteLine("Test Failed");

            }
        }
    }
}

