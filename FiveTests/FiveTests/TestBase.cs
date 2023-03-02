using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FiveTests
{
    public class TestBase : Driver
    {
        [SetUp]
        public void Setup()
        {


            var option = new ChromeOptions();
            option.AddArguments("--incognito");

            WebDriver = new ChromeDriver(option);
            WebDriverWait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(60));
            JSExecutor = (IJavaScriptExecutor)WebDriver;

            WebDriver.Navigate().GoToUrl("https://www.visma.lv/");
            WebDriver.Manage().Window.Maximize();


            Thread.Sleep(1000);
            WebDriver.FindElement(By.XPath("//*[@id=\"onetrust-accept-btn-handler\"]"))?.Click();

        }


        [TearDown]
        public void TearDown()
        {
            WebDriver.Quit();
        }
    }
}
