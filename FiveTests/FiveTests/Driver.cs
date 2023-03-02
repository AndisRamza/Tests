using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FiveTests
{
    public class Driver
    {
        public IWebDriver WebDriver { get; set; }
        public WebDriverWait WebDriverWait { get; set; }

        public IJavaScriptExecutor JSExecutor { get; set; }

    }
}
