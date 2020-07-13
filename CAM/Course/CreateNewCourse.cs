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
                    // Create Course btn
                    addingCourse.ClickButton._ClickButton("//button[@class='k-button-icontext k-button k-primary']");

                    // New Course btn
                    addingCourse.ClickButton._ClickButton("//li[@class='k-item ng-star-inserted k-state-focused']");
                    Thread.Sleep(2000);

                    ////--Overview--

                    // Title
                    //addingCourse.ClickButton._ClickButton("//input[@class='form-control ng-pristine ng-invalid ng-star-inserted ng-touched']");
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[2]/editable/input", "Basketball " + addingCourse.EnterTextBox.GenerateName());

                    // Type
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[3]/editable/opal-select/ng-select/div/div/div[2]/input", "Course/ Workshop");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[3]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div/span");
                    Thread.Sleep(1000);

                    // Duration (Hours)
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[4]/div[1]/editable/kendo-numerictextbox/span/input", "10");

                    // Duration (Minutes)
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[4]/div[2]/editable/kendo-numerictextbox/span/input", "10");

                    // Categories
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[5]/editable/opal-select/ng-select/div/div/div[2]/input", "MOE Mandatory");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[5]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Mode of Learner
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[6]/editable/opal-select/ng-select/div/div/div[2]/input", "E-Learning");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[6]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");


                    // Objective/ Outcome of PD Activity 
                    addingCourse.EnterTextBox.PasteTexts("//div[10]//editable[1]//textarea[1]", addingCourse.EnterTextBox.GenerateName());
                    Thread.Sleep(1000);

                    //  Course Synopsis/ Description 
                    addingCourse.EnterTextBox.PasteTexts("//div[11]//editable[1]//textarea[1]", addingCourse.EnterTextBox.GenerateName());

                    ////--Provider--

                    //  Training Agency 
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[1]/editable/div[1]/div/input"); // MOE

                    // Owner Division/ Academy
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "Division 39");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");
                    Thread.Sleep(1000);

                    // Owner Branch/ Unit
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[2]/editable/opal-select/ng-select/div/div/div[2]/input", "Branch 39");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[2]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Phone MOE Officer (Owner Division)
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[5]/editable/input", "0123456789");

                    //Email of MOE officer (Owner division)
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[6]/editable/input", "abc@yopmail.com");

                    // Notional Cost
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[7]/editable/kendo-numerictextbox/span/input", "1000");

                    // Course Fee
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[2]/provider-info-tab/form/div/div[3]/div[8]/editable/kendo-numerictextbox/span/input", "10");

                    //// --Metadata--
                    // Service Scheme
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "Executive and Administrative Staff");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Subject
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[2]/editable/opal-select/ng-select/div/div/div[2]/input", "Corporate Services");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[2]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // PD Area/ Theme
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[3]/editable/opal-select/ng-select/div/div/div[2]/input", "Corporate Services");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[3]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");


                    // Learning Framework
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[4]/editable/opal-select/ng-select/div/div/div[2]/input", "HQ EAS Core (MX14 and above)");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[4]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");


                    // Learning Dimension
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[5]/editable/opal-select/ng-select/div/div/div[2]/input", "Collaboration and Engagement");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[5]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Learning Area
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[6]/editable/opal-select/ng-select/div/div/div[2]/input", "Collaboration and Engagement");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[6]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Course Level
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[8]/editable/opal-select/ng-select/div/div/div[2]/input", "Leading");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[3]/metadata-tab/form/div/div[8]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    //// --Copyright--
                    // Copyright Owner
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[4]/copyright-tab/form/div/div[2]/div/editable/input", addingCourse.EnterTextBox.GenerateName());

                    //// --Target Audience--
                    // Place of Work
                    addingCourse.ClickButton._ClickButton("//body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div/detail-content-right/div/div/target-audience-tab/form/div/div/editable/div/div[2]/input[1]");//Organisation

                    // Division
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[4]/editable/opal-select/ng-select/div/div/div[2]/input", "Division 39");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[4]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Branch
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[5]/editable/opal-select/ng-select/div/div/div[2]/input", "Branch 39");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[5]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    //// --User Profile--
                    // Track
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "MOE HQ");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Developmental Role
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[2]/editable/opal-select/ng-select/div/div/div[2]/input", "Director");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[2]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div[5]/div");

                    // Job Family
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[5]/editable/opal-select/ng-select/div/div/div[2]/input", "Citizen Engagement");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[5]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // EAS Substantive Grade Banding
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[8]/editable/opal-select/ng-select/div/div/div[2]/input", "HQ EAS Core (MX14 and above)");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[5]/target-audience-tab/form/div/div[9]/div[8]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    //// --Course Planning--
                    // Nature of Course
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "Full-time");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div[1]/div");

                    // Number of Classes Planned
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[3]/editable/kendo-numerictextbox/span/input", "20");

                    // Number of Sessions Per Class
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[4]/editable/kendo-numerictextbox/span/input", "20");

                    // Number of Hours Per Session
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[5]/editable/kendo-numerictextbox/span/input", "40");

                    // Date & Time Publish Course
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[7]/editable/kendo-datepicker/span/span/span");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[7]/editable/kendo-datepicker/span/span/span");
                    addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[7]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "13072020");
                    //addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[7]/editable/kendo-datepicker/span/kendo-dateinput/span/input");
                    //addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[7]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "13072020");


                    // Start Date (Publish Course)
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[8]/editable/kendo-datepicker/span/span/span");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[8]/editable/kendo-datepicker/span/span/span");
                    addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[8]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "15072020");


                    // End Date (Publish Course)
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[9]/editable/kendo-datepicker/span/span/span");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[9]/editable/kendo-datepicker/span/span/span");
                    addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[9]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "30082020");


                    // Date & Time to Archive Course
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[10]/editable/kendo-datepicker/span/span/span");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[10]/editable/kendo-datepicker/span/span/span");
                    addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[10]/editable/kendo-datepicker/span/kendo-dateinput/span/input", "31082020");

                    // Period of PD Activity
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[11]/editable/opal-select/ng-select/div/div/div[2]/input", "Term 1");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[11]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Minimum Participants Per Class
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[12]/editable/kendo-numerictextbox/span/input", "50");

                    // Maximum Participants Per Class
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[6]/course-planning-tab/form/div/div[13]/editable/kendo-numerictextbox/span/input", "100");

                    //// --Evaluation & E-Certificate
                    // Post Course Evaluation Form
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[7]/evaluation-ecertificate-tab/form/div/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "Basketball - Post Survey by Urek");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[7]/evaluation-ecertificate-tab/form/div/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div/div");

                    // E-Certificate Template
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[7]/evaluation-ecertificate-tab/form/div/div[2]/editable/opal-select/ng-select/div/div/div[2]/input", "E-certificate template 1");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[7]/evaluation-ecertificate-tab/form/div/div[2]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div/div/span[1]");

                    //// --Course Administration--
                    // Course Administrator(1st)
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[8]/course-administration-tab/form/div/div[1]/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "urek-sa-01");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[8]/course-administration-tab/form/div/div[1]/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Primary Approving Officer
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[8]/course-administration-tab/form/div/div[2]/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "urek-sa-01");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[8]/course-administration-tab/form/div/div[2]/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

                    // Course Facilitator
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[8]/course-administration-tab/form/div/div[3]/div[1]/editable/opal-select/ng-select/div/div/div[2]/input", "urek-cf-01");
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[8]/course-administration-tab/form/div/div[3]/div[1]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");


                    // Traisi Course Code (Where applicable)
                    addingCourse.EnterTextBox.PasteTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[8]/editable/input", addingCourse.EnterTextBox.GenerateTraisiCode());


                    // Thumbnail
                    //addingCourse.ClickButton._ClickByFindElement("//div[@class='opal-file-uploader__drop-file-area column align-center-center -show']");
                    //autoIt.Send("C:\\Users\\tuan.trinh\\Downloads\\i.jpg");
                    //autoIt.Send("{ENTER}");
                    //addingCourse.ClickButton._ClickButton("//button[@class='k-button ng-star-inserted']");

                    // Save button
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/app-toolbar-fragment/div/div[3]/toolbar-right/div/button[1]");

                    // Check create course successful
                    addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-management-page/div/div/div[2]/div");
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