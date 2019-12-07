using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject4
{
    [TestClass]

        public class Loginform
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
            public void testLoginUnvalid()
            {
                driver.Navigate().GoToUrl("https://sportensklad.bg/index.php?route=account/login");
                driver.Manage().Window.Size = new System.Drawing.Size(1534, 822);
                driver.FindElement(By.Id("input-email")).Click();
                driver.FindElement(By.Id("input-email")).SendKeys("start123");
                driver.FindElement(By.Id("input-password")).SendKeys("adjfjdkld");
                driver.FindElement(By.CssSelector(".btn:nth-child(3)")).Click();
                System.Threading.Thread.Sleep(3000);
                Assert.AreEqual(driver.FindElement(By.CssSelector(".alert")).Text,"Грешка: Несъответствие на въведената електронна поща и/или парола.");
            }
        }
 }
