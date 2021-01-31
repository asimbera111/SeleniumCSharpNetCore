using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        IWebElement lnkLogin => _driver.FindElement(By.LinkText("Login"));
        IWebElement lnkLogOff => _driver.FindElement(By.LinkText("Log off"));

        public void ClickLogin()
        {
            lnkLogin.Click();
        }

        public bool IsLogOffDisplayed() => lnkLogOff.Displayed;
        
    }
}
