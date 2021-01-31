using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver) 
        {
            _driver = driver;
        }
        
        IWebElement txtUsername => _driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => _driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => _driver.FindElement(By.CssSelector(".btn-default"));

        public void EnterUsernameAndPassword(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);            
        }
        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
