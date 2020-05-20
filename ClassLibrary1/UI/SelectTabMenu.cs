using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Common.UI

{
    public class SelectTabMenu
    {
        private IWebDriver _driver;
        private string v;

        public SelectTabMenu(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }
        public void ClickTabMenu(string XPath)
        {
            var option = _driver.FindElement(By.XPath($"{XPath}"));
            if (option != null)
            {
                option.Click();
                Thread.Sleep(2000);

            }
            else
            {
                throw new Exception("not found TabMenu Element");
            }

        }
    }
}