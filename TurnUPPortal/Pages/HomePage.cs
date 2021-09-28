using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace TurnUPPortal.Pages
{
    class HomePage
    {
        public void GoToTM(IWebDriver driver)
        {
            IWebElement admintrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            admintrationDropdown.Click();

            IWebElement timeAndMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeAndMaterial.Click();
            Thread.Sleep(1000);
        }
    }
}
