﻿using AutoItX3Lib;
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
            //driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/");
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open"); 
            LoginPage.Login(driver);
            Thread.Sleep(3000);

            AddCourse addingCourse = new AddCourse(driver);
            Thread.Sleep(5000);

            addingCourse.ClickMenu.ClickTabMenu("//img[@class='icons switch-module']");
            addingCourse.ClickSubMenu._ClickButton("//li[@aria-label='Course Administration']");
            Thread.Sleep(4000);
            addingCourse.ClickButton._ClickButton("//button[@class='k-button-icontext k-button k-primary']");
            addingCourse.ClickButton._ClickButton("//li[@class='k-item ng-star-inserted k-state-focused']");
            Thread.Sleep(2000);
            addingCourse.ClickButton._ClickButton("//opal-file-uploader[@class='basic-info-tab__thumbnail-uploader ng-untouched ng-pristine ng-valid ng-star-inserted']");
            autoIt.Send("C:\\Users\\tuan.trinh\\Downloads\\i.jpg");
            Thread.Sleep(2000);
            autoIt.Send("{ENTER}");
            Thread.Sleep(2000);
            addingCourse.ClickButton._ClickButton("//button[@class='k-button ng-star-inserted']");

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