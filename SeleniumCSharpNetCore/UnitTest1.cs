using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {        
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver("C:\\Asim\\Automation\\SeleniumCSharpCore");
        }

        [Test]
        public void Test1()
        {            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            Assert.Pass();
        }
    }
}