﻿using OpenQA.Selenium;
using System;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using System.Windows.Forms;

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
            Clipboard.SetText(text);
            if (option != null)
            {
                option.SendKeys(OpenQA.Selenium.Keys.LeftControl + 'v');
            }
            else
            {                
                throw new Exception("not found Textbox Element");
            }
        }

        public void EnterHotKeys(string tab)
        {
            throw new NotImplementedException();
        }
    }
}