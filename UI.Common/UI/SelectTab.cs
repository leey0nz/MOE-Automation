using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.CommonUI

{
    public class SelectTab
    {
        private IWebDriver _driver;
        private string v;

        public SelectTab(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }
        public void ClickTab(string text)
        {
            var option = _driver.FindElement(By.XPath($"//span[contains(text(),'{text}')]"));

            if (option != null)
            {
                option.Click();
                Thread.Sleep(1000);

            }
            else
            {
                throw new Exception($"not found ${text}");
            }

        }
    }
}