namespace pageFactoryNetCoreIssue
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using System.IO;
    using System.Reflection;

    [TestFixture]
    public class Test
    {
        [Test]
        public void MainSearchTest()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            var googleMainPage = new GoogleMainPage(driver);

            googleMainPage.Navigate();

            googleMainPage.Search("Selenium");
        }
    }
}
