using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LoginPage
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);

            IWebElement Hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (Hellohari.Text=="Hello hari!")
            {
                Console.WriteLine("Login Successfull, Test Passed");
            }
            else
            {
                Console.WriteLine("Login Failed, Test Failed");
            }
            IWebElement admintrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            admintrationDropdown.Click();

            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
            Thread.Sleep(1000);

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
            

            IWebElement lastRowText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if(lastRowText.Text=="Test123")
            {
                Console.WriteLine("Time Record Created Successful, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
            //Edit Record
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[5]/a[1]"));
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
            if(lastRecordText.Text =="Test1234")
            {
                Console.WriteLine("Record Edited Successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]")).Click();
            
            driver.SwitchTo().Alert().Accept();
            IWebElement nextLastRecordText = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            if(nextLastRecordText.Text!= "Test1234")
            {
                Console.WriteLine("Record Deleted Successfully, Test Paased");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
            //Click on time and Material

            //Identify  Edit Button for 1st Record

            //Click on Edit button

            //Identify on Time Dropdown

            //Select Material

            //Identify Code Textbox
            //Edit And input Data
            //Identify Description TextBox
            //Edit and Input Data
            //Identify Save Button
            //Click on save button




        }
    }
}
