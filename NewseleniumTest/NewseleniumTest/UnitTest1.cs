using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NewseleniumTest
{
    [TestClass]
    public class TestUnvalidName
    {
        public IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
        [TestMethod]
        public void unvalidName()
        {
            driver.Navigate().GoToUrl("https://pochivka.bg/login");
            driver.Manage().Window.Size = new System.Drawing.Size(1534, 822);
            driver.FindElement(By.Id("username")).Click();
            driver.FindElement(By.Id("username")).SendKeys("autotest");
            driver.FindElement(By.Id("password")).SendKeys("aksjdhfg");
            driver.FindElement(By.CssSelector(".orange:nth-child(4)")).Click();
            Assert.AreEqual(driver.FindElement(By.CssSelector(".error")).Text, "Въвели сте грешен потребител или парола!");
        }
    }
}
