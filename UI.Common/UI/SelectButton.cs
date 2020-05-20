using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Common.UI

{
    public class SelectButton
    {
        private IWebDriver _driver;
        private string v;

        public SelectButton(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }
        public void _ClickButton(string XPath)
        {
            var option = _driver.FindElement(By.XPath($"{XPath}"));//[@class='btn btn-outline-secondary reset']

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

    }
}