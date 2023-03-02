using OpenQA.Selenium;

namespace FiveTests
{
    public class Tests : TestBase
    {
        [Test]
        public void VideoTrainingTicketAnnouncment()
        {
            WebDriver.Navigate().GoToUrl("https://www.visma.lv/");
            WebDriver.Manage().Window.Size = new System.Drawing.Size(1516, 816);
            WebDriver.FindElement(By.LinkText("Apmācības")).Click();
            WebDriver.FindElement(By.LinkText("Video apmācības")).Click();
            Assert.That(WebDriver.FindElement(By.CssSelector("#\\39 00435 h2")).Text, Is.EqualTo("Aizpildiet anketu, ja vēlaties iegādāties pieeju video apmācību zonai"));
        }

        [Test]
        public void VismaContactsEnterprise()
        {
            WebDriver.Navigate().GoToUrl("https://www.visma.lv/");
            WebDriver.Manage().Window.Size = new System.Drawing.Size(1516, 816);
            WebDriver.FindElement(By.LinkText("Kontakti")).Click();
            Assert.That(WebDriver.FindElement(By.CssSelector("#\\31 560579 h3")).Text, Is.EqualTo("Visma Enterprise"));
        }

        [Test]
        public void VismaTalantSolution()
        {
            WebDriver.Navigate().GoToUrl("https://www.visma.lv/");
            WebDriver.Manage().Window.Size = new System.Drawing.Size(1512, 816);
            WebDriver.FindElement(By.CssSelector(".menu-item:nth-child(2) > .navigation__submenu-link")).Click();
            WebDriver.FindElement(By.LinkText("Visma Talent Solutions (HRM)")).Click();
            Assert.That(WebDriver.FindElement(By.CssSelector(".banner__heading")).Text, Is.EqualTo("Visma Talent Solutions"));
        }

        [Test]
        public void VismaTrainingDocs()
        {
            WebDriver.Navigate().GoToUrl("https://www.visma.lv/");
            WebDriver.Manage().Window.Size = new System.Drawing.Size(1516, 816);
            WebDriver.FindElement(By.CssSelector(".menu-item:nth-child(2) > .navigation__submenu-link")).Click();
            WebDriver.FindElement(By.LinkText("- Apmācības")).Click();
            WebDriver.FindElement(By.LinkText("Sīkāks apraksts")).Click();
            var elements = WebDriver.FindElements(By.CssSelector("path:nth-child(15)"));
            Assert.True(elements.Count > 0);
        }

        [Test]
        public void VismaVakanciesNetMarupe8Elem()
        {
            WebDriver.Navigate().GoToUrl("https://www.visma.lv/");
            WebDriver.Manage().Window.Size = new System.Drawing.Size(1514, 816);
            WebDriver.FindElement(By.CssSelector(".menu-item:nth-child(3) .menu-icon")).Click();
            WebDriver.FindElement(By.LinkText("Vakances")).Click();
            Assert.That(WebDriver.FindElement(By.CssSelector("li:nth-child(9) > .vacancy-list--item")).GetAttribute("aria-label"), Is.EqualTo(".NET Developer"));
        }
    }
}
