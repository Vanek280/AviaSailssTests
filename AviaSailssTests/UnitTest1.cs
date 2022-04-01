using NUnit.Framework;
using OpenQA.Selenium;
namespace AviaSailssTests
{
    public class Tests
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.aviasales.by");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}