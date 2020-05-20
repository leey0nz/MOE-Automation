using Login.Common.Login;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;
using System.Threading;

namespace CAM
{
    public class CreateNewCourse
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        //private string baseURL;
        //private bool acceptNextAlert = true;

        [Test]
        public void createNewCourse()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/");
            LoginPage.Login(driver);
            Thread.Sleep(2000);

            AddCourse addingCourse = new AddCourse(driver);
            Thread.Sleep(1000);

            //addingCategoriesPageObject.ClickMenu.ClickTabMenu("//div[@class='subMenu-desktop']//a[@class='list-group-item'][contains(text(),'Categories')]");
            //addingCategoriesPageObject.ClickButton._ClickButton("//div[@class='group-button on-top']//button[@class='btn btn-outline-secondary reset'][contains(text(),'Add')]");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='Name']", "Testing 1");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='Description']", "Testing 1");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='IdentifiedId']", "TT01");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='Code']", "TT1");
            //addingCategoriesPageObject.ClickButton._ClickButton("//button[contains(text(),'Save')]");
            //driver.Quit();

        }
    }
}