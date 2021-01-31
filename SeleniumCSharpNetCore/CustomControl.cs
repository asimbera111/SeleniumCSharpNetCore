using OpenQA.Selenium;
namespace SeleniumCSharpNetCore
{
    public class CustomControl
    {
        private DriverHelper _driverHelper;
        public CustomControl(DriverHelper driverHelper) => _driverHelper = driverHelper;
        public void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = _driverHelper.Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            _driverHelper.Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}
