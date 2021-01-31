using NUnit.Framework;
using SeleniumCSharpNetCore.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumCSharpNetCore.Steps
{
    [Binding]
    public class LoginSteps
    {
        private DriverHelper _driverHelper;
        HomePage homePage;
        LoginPage loginpage;

        public LoginSteps(DriverHelper driverHelper) 
        {
            _driverHelper = driverHelper;
            homePage = new HomePage(_driverHelper.Driver);
            loginpage = new LoginPage(_driverHelper.Driver);
        }         

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
        }

        [Given(@"I click the login link")]
        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
        }

        [When(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginpage.EnterUsernameAndPassword((string)data.username, (string)data.password);
        }

        [When(@"I click login")]
        public void GivenIClickLogin()
        {
            loginpage.ClickLogin();
        } 

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.IsTrue(homePage.IsLogOffDisplayed(), "Log off button is not displayed");
        }

    }
}
