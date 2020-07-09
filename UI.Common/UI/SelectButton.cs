using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Common.UI

{
    public class SelectButton
    {
        private IWebDriver _driver;
        private string v;
        private string loadingIconXPath = "//div[@class='spinner primary']";

        public SelectButton(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }

        public void _ClickButton(string XPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            //var isLoadingGone = _waitUntilLoadingDissapear();
            //do
            //{
            //    isLoadingGone = _waitUntilLoadingDissapear();
            //} while (isLoadingGone == false);
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($"{XPath}"))).Click();
        }

        public void _CheckSpinner()
        {
            var isLoadingGone = _waitUntilLoadingDissapear();
            do
            {
                isLoadingGone = _waitUntilLoadingDissapear();
            } while (isLoadingGone == false);
        }

        public void _ClickByFindElement(string XPath)
        {
            var option = _driver.FindElement(By.XPath($"{XPath}"));
            if (option != null)
            {
                option.Click();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("not found Element");
                return;
            }
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
                Console.WriteLine("not found Element");
            }

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

        public bool _checkElementExistedByXPath(string XPath)
        {
            try
            {
                var option = _driver.FindElement(By.XPath($"{XPath}"));
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}