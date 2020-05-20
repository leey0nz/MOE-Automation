using OpenQA.Selenium;
using System;
using System.Threading;

namespace UI.Common.UI
{
    public class Dropdown
    {
        private string _xpath;
        private IWebElement webElement;
        IWebDriver _driver;
        public Dropdown(IWebDriver driver, string xpath)
        {
            _driver = driver;
            if (string.IsNullOrEmpty(xpath)) throw new Exception("null input");

            webElement = driver.FindElement(By.XPath(xpath));
            if (webElement == null) throw new Exception($"not found ${xpath}");
        }

        public void ClickDropDown()
        {
            webElement.Click();
            Thread.Sleep(1000);
        }

        public void SelectOptionByText(string text)
        {
            var option = _driver.FindElement(By.XPath($"//span[@class='ng-option-label'][contains(text(),'{text}')]"));

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
