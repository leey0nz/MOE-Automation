using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.CommonUI

{
    public class SelectVariants
    {
        private IWebDriver _driver;
        private string v;

        public SelectVariants(IWebDriver driver, string v)
        {
            this._driver = driver;
            this.v = v;
        }
        public void ClickEditIcon()
        {
            var option = _driver.FindElement(By.XPath($"//i[@class='far fa-edit field__icon-edit']"));

            if (option != null)
            {
                option.Click();
                Thread.Sleep(1000);
            }
            else
            {
                throw new Exception("edit icon not found ");
            }

        }
        public void ClickPlaceHolder()
        {
            var option = _driver.FindElement(By.XPath($"//span[@class='dropdown-btn']"));

            if (option != null)
            {
                option.Click();
                Thread.Sleep(1000);
            }
            else
            {
                throw new Exception("placeholder not found ");
            }
        }
        public void ClickNameVariants(string text)
        {
            var option = _driver.FindElement(By.XPath($"//div[contains(text(),'{text}')]"));

            if (option != null)
            {
                option.Click();
                Thread.Sleep(1000);
            }
            else
            {
                throw new Exception("name variant not found ");
            }
        }

    }
}