namespace pageFactoryNetCoreIssue
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;


    public class GoogleMainElements
    {
        public const string searchTextBox_Id = "lst-ib";

        [FindsBy(How = How.Id, Using = searchTextBox_Id)]
        public IWebElement SearchBox;
    }
}
