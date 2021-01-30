using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement txtUsername => Driver.FindElement(By.Name("UserName"));
        IWebElement txtPassword => Driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => Driver.FindElement(By.CssSelector(".btn-default"));

        public void Login()
        {
            txtUsername.SendKeys("admin");
            txtPassword.SendKeys("password");
            btnLogin.Click();
        }
    }
}
