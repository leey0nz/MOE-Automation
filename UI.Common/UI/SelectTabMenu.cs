using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Common.UI

{
    public class SelectTabMenu
    {
        private IWebDriver _driver;
        private string v;
        private string loadingIconXPath = "//div[@class='spinner primary']";

        public SelectTabMenu(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }
        public void ClickTabMenu(string XPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            var isLoadingGone = _waitUntilLoadingDissapear();
            do
            {
                isLoadingGone = _waitUntilLoadingDissapear();
            } while (isLoadingGone == false);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"{XPath}"))).Click();
        }

        public bool _waitUntilLoadingDissapear()
        {
            try
            {
                var option = _driver.FindElement(By.XPath($"{loadingIconXPath}"));
                return false;
            }
            catch (NoSuchElementException e)
            {
                return true;
            }
        }
    }
}