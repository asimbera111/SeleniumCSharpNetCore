using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {        
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver("C:\\Asim\\Automation\\SeleniumCSharpNetCore");
        }

        [Test]
        public void Test1()
        {            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage homePage = new HomePage();
            homePage.ClickLogin();           

            LoginPage loginPage = new LoginPage();
            loginPage.Login();
            Assert.IsTrue(homePage.IsLogOffDisplayed(), "Log off button is not displayed");
        }
    }
}