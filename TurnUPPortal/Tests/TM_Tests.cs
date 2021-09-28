using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnUPPortal.Pages;

namespace TurnUPPortal
{
    class TM_Tests
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            //LoginPage object Initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //HomePage 
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTM(driver);

            //TMPage
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);

            //Edit time
            tMPageObj.EditTM(driver);

            //Delete time
            tMPageObj.DeleteTM(driver);
        }
    }
}
