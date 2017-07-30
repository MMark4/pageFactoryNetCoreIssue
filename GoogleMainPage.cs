namespace pageFactoryNetCoreIssue
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class GoogleMainPage
    {
        private IWebDriver Driver;

        private GoogleMainElements googleMainElements;

        public GoogleMainPage(IWebDriver webDriver)
        {
            Driver = webDriver;

            googleMainElements = new GoogleMainElements();
            PageFactory.InitElements(Driver, googleMainElements);
        }

        public void Navigate()
        {
            Driver.Navigate().GoToUrl(@"https://www.google.com");
        }

        public void Search(string searchInput)
        {
            googleMainElements.SearchBox.SendKeys(searchInput + Keys.Enter);
        }
    }
}
