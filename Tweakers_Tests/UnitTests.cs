using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tweakers_Tests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://tweakers.net/nieuws");

            driver.FindElement(By.Id("cookieAcceptForm")).FindElement(By.ClassName("ctaButton")).Click();

            driver.FindElement(By.ClassName("newsContentBlock")).FindElement(By.TagName("h1")).Click();
        }

        [Test]
        public void Artikel_HeeftAuteur()
        {
            //ARRANGE
            var Auteur = driver.FindElement(By.ClassName("name"));
            //ACT
            //ASSERT
            Assert.IsNotNull(Auteur);
        }

        [Test]
        public void Artikel_HeeftDatum()
        {
            //ARRANGE
            var Datum = driver.FindElement(By.ClassName("meta")).FindElement(By.TagName("p"));
            //ACT
            //ASSERT
            Assert.IsNotNull(Datum);
        }
    }
}