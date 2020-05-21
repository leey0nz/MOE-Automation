using OpenQA.Selenium;
using System;
using System.Threading;

namespace Login.Common.Login
{
    public class LoginPage
    {
        public static void Login(IWebDriver driver)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.Id("txt-email")).Click();
            driver.FindElement(By.Id("txt-email")).Clear();
            driver.FindElement(By.Id("txt-email")).SendKeys("tuan.trinh@yopmail.com");
            driver.FindElement(By.Id("txt-password")).Click();
            driver.FindElement(By.Id("txt-password")).Clear();
            driver.FindElement(By.Id("txt-password")).SendKeys("tuantrinh1234567890.");
            driver.FindElement(By.Id("btnSubmit")).Click();
        }
    }
}
