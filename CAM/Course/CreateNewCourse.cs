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
        [Test]
        public void createNewCourse()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();

            // Navigate URL
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/cam");

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");

            // Login Page
            LoginPage.Login(driver);

            AddCourse addingCourse = new AddCourse(driver);

            // Check Security Log-in
            addingCourse.ClickButton._ClickByFindElement("//button[contains(text(),'Proceed')]");

            // Tab Menu
            addingCourse.ClickMenu.ClickTabMenu("//span[contains(text(),'Course Administration')]");
            Thread.Sleep(1000);

            // Create Course btn
            addingCourse.ClickButton._ClickButton("//button[@class='k-button-icontext k-button k-primary']");

            // New Course btn
            addingCourse.ClickButton._ClickButton("//li[@class='k-item ng-star-inserted k-state-focused']");
            Thread.Sleep(2000);

            ////--Overview--

            // Title
            autoIt.Send("Basketball 01");

            // Type
            autoIt.Send("{TAB}, {ENTER}, Course/ Workshop");

            // Duration (Hours)
            autoIt.Send("{ENTER}, {TAB}, 10");

            // Duration (Minutes)
            autoIt.Send("{TAB}, 10");
            autoIt.Send("{TAB},{ENTER}");

            // Categories
            autoIt.Send("MOE Mandatory");
            autoIt.Send("{TAB}, {TAB}, {ENTER}");

            // Mode of Learner
            autoIt.Send("E-Learning");
            autoIt.Send("{ENTER}, {TAB}");

            // Traisi Course Code (Where applicable)
            autoIt.Send("0F001");
            addingCourse.ClickButton._CheckSpinner();

            // Objective/ Outcome of PD Activity 
            addingCourse.ClickButton._ClickButton("//div[10]//editable[1]//textarea[1]");
            autoIt.Send("Testing1");

            //  Course Synopsis/ Description 
            addingCourse.EnterTextBox.EnterTexts("//div[11]//editable[1]//textarea[1]", "Testing2");

            ////--Provider--

            //  Training Agency 
            autoIt.Send("{TAB}");
            autoIt.Send("{SPACE}");// MOE

            // Owner Division/ Academy
            addingCourse.ClickButton._ClickButton("//provider-info-tab//div//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");

            //Image
            //addingCourse.ClickButton._ClickByFindElement("//div[@class='opal-file-uploader__drop-file-area column align-center-center -show']");
            //autoIt.Send("C:\\Users\\tuan.trinh\\Downloads\\i.jpg");
            //autoIt.Send("{ENTER}");
            //addingCourse.ClickButton._ClickButton("//button[@class='k-button ng-star-inserted']");


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