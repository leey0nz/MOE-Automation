using AutoItX3Lib;
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
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/cam");

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open"); 
            LoginPage.Login(driver);
            //Thread.Sleep(3000);

            AddCourse addingCourse = new AddCourse(driver);
            //Thread.Sleep(5000);
            addingCourse.ClickButton._ClickByFindElement("//button[contains(text(),'Proceed')]");
            //addingCourse.ClickMenu.ClickTabMenu("//img[@class='icons switch-module']");
            //addingCourse.ClickSubMenu._ClickButton("//li[@aria-label='Course Administration']");
            addingCourse.ClickMenu.ClickTabMenu("//span[contains(text(),'Course Administration')]");
            addingCourse.ClickButton._ClickButton("//button[@class='k-button-icontext k-button k-primary']");
            addingCourse.ClickButton._ClickButton("//li[@class='k-item ng-star-inserted k-state-focused']");
            addingCourse.ClickButton._ClickByFindElement("//div[@class='opal-file-uploader__drop-file-area column align-center-center -show']");
            autoIt.Send("C:\\Users\\tuan.trinh\\Downloads\\i.jpg");
            autoIt.Send("{ENTER}");
            addingCourse.ClickButton._ClickButton("//button[@class='k-button ng-star-inserted']");
            addingCourse.EnterTextBox.EnterTexts("//input[@class='form-control ng-pristine ng-invalid ng-star-inserted ng-touched']", "Basketball 01");
            addingCourse.ClickButton._ClickButton("//basic-info-tab//div[3]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            addingCourse.ClickButton._ClickButton("//span[@class='ng-option-label ng-star-inserted'][contains(text(),'Course')]");
            addingCourse.EnterTextBox.EnterTexts("//input[@id='k-109288d3-717a-4cc6-b9f2-67d75db0ad6b']","10");

            //addingCategoriesPageObject.ClickButton._ClickButton("//div[@class='group-button on-top']//button[@class='btn btn-outline-secondary reset'][contains(text(),'Add')]");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='Name']", "Testing 1");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='Description']", "Testing 1");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='IdentifiedId']", "TT01");
            //addingCategoriesPageObject.EnterTextBox.EnterTexts("//input[@placeholder='Code']", "TT1");
            //addingCategoriesPageObject.ClickButton._ClickButton("//button[contains(text(),'Save')]");
            //driver.Quit();
            //try
            //{
            //    addingCourse.ClickMenu.ClickTabMenu("//img[@class='icons switch-module']");
            //    addingCourse.ClickSubMenu._ClickButton("//li[@aria-label='Course Administration']");
            //    Thread.Sleep(1000);
            //    addingCourse.ClickButton._ClickButton("//button[@class='k-button-icontext k-button k-primary']");
            //    addingCourse.ClickButton._ClickButton("//li[@class='k-item ng-star-inserted k-state-focused']");

            //    driver.FindElement(By.XPath("//p[@class='toolbar__left-group__title-group__title']"));
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Can not open create course site !!!\n Reason: " + e);
            //    return;
            //}
            //Console.WriteLine("Open create course site success!!!!");
        }
    }
}