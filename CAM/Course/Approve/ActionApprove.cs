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
    public class ActionApprove
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        [Test]
        public void actionApprove()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            verificationErrors = new StringBuilder();

            // Navigate URL
            driver.Navigate().GoToUrl("https://www.development.opal2.conexus.net/app/cam");

            //AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("Open");

            // Login Page
            LoginRoleSA.Login(driver);

            AddCourse addingCourse = new AddCourse(driver);

            try
            {
                // Check Security Log-in
                var isProceedExisted = addingCourse.ClickButton._checkElementExistedByXPath("//button[contains(text(),'Proceed')]");
                if (isProceedExisted == true)
                {
                    addingCourse.ClickButton._ClickByFindElement("//button[contains(text(),'Proceed')]");
                }

                // Tab Menu
                addingCourse.ClickMenu.ClickTabMenu("//span[contains(text(),'Course Administration')]");
                Thread.Sleep(2000);

                for (int i = 0; i < 5; i++)
                {
                    // Pending Course Approval menu
                    addingCourse.ClickButton._ClickButton("//div[contains(text(),'Pending Course Approval')]");

                    // Search Course
                    addingCourse.EnterTextBox.PasteTexts("//input[@placeholder='Search in Course Administration']", "Basketball Testing ");

                    // Choose course
                    addingCourse.ClickButton._ClickButton("//p[@class='main-title ng-star-inserted']");
                    Thread.Sleep(2000);

                    // Approve button
                    addingCourse.ClickButton._ClickButton("//button[contains(text(),'Approve')]");

                    // Input Comment
                    addingCourse.EnterTextBox.PasteTexts("//textarea[@placeholder='Please add comment ...']", "Agree");

                    // Proceed button
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/kendo-dialog/div[2]/div/comment-dialog/div[3]/button[2]");

                }

                //driver.Quit();
            }
            catch (Exception e)
            {
                Console.WriteLine("Can not open create course site !!!\n Reason: " + e);
                return;
            }
            Console.WriteLine("Open create course site success!!!!");
        }
    }
}