using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Common.UI

{
    public class SelectSubMenu
    {
        private IWebDriver _driver;
        private string v;
        private string loadingIconXPath = "//div[@class='spinner primary']";

        public SelectSubMenu(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }
        public void _ClickButton(string xPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            var isLoadingGone = _waitUntilLoadingDissapear();
            do
            {
                isLoadingGone = _waitUntilLoadingDissapear();
            } while (isLoadingGone == false);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"{xPath}"))).Click();
        }
        public void _ClickButtonbyCSS(string Css)
        {
            var option = _driver.FindElement(By.CssSelector($"{Css}"));//[@class='btn btn-outline-secondary reset']

            if (option != null)
            {
                option.Click();
                Thread.Sleep(1000);
            }
            else
            {
                throw new Exception("not found Element");
            }

        }

        public bool _waitUntilLoadingDissapear()
        {
            try
            {
                var option = _driver.FindElement(By.XPath($"{loadingIconXPath}"));
                Console.WriteLine("1.false");
                return false;
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("1.true--------------------------------");
                return true;
            }
        }

    }
}