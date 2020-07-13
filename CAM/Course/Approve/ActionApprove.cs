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

            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");

            // Login Page
            LoginPage.Login(driver);

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


                //for (int i = 0; i < 5; i++)
                //{
                    
                //    // Check create course successful
                //    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-management-page/div/div/div[2]/div");
                //}

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