using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace UI.Common.UI

{
    public class EnterText
    {
        private IWebDriver driver;
        private string v;

        public EnterText(IWebDriver driver, string v)
        {
            this.driver = driver;
            this.v = v;
        }

        public void EnterTexts(string XPath, string text)
        { 
            var option = driver.FindElement(By.XPath($"{XPath}"));
            if (option != null)
            {
                option.SendKeys(text);
                //Thread.Sleep(1000);
            }
            else
            {                
                throw new Exception("not found Textbox Element");
            }
        }
    }
}