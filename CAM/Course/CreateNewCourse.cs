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
            var isProceedExisted = addingCourse.ClickButton._checkElementExistedByXPath("//button[contains(text(),'Proceed')]");
            if (isProceedExisted == true)
            {
                addingCourse.ClickButton._ClickByFindElement("//button[contains(text(),'Proceed')]");
            }

            // Tab Menu
            addingCourse.ClickMenu.ClickTabMenu("//span[contains(text(),'Course Administration')]");
            Thread.Sleep(2000);

            // Create Course btn
            addingCourse.ClickButton._ClickButton("//button[@class='k-button-icontext k-button k-primary']");

            // New Course btn
            addingCourse.ClickButton._ClickButton("//li[@class='k-item ng-star-inserted k-state-focused']");
            Thread.Sleep(2000);

            ////--Overview--

            // Title
            //addingCourse.ClickButton._ClickButton("//input[@class='form-control ng-pristine ng-invalid ng-star-inserted ng-touched']");
            addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[2]/editable/input", "Basketball 01");
            //autoIt.Send("Basketball 01");

            // Type
            addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[3]/editable/opal-select/ng-select/div/div/div[2]/input", "Course/ Workshop");
            addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[3]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div/span");
            //autoIt.Send("{ENTER}");


            // Duration (Hours)
            addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[4]/div[1]/editable/kendo-numerictextbox/span/input", "10");
            //autoIt.Send("10");

            // Duration (Minutes)
            addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[4]/div[2]/editable/kendo-numerictextbox/span/input", "10");

            // Categories
            addingCourse.EnterTextBox.EnterTexts("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[5]/editable/opal-select/ng-select/div/div/div[2]/input", "MOE Mandatory");
            addingCourse.ClickButton._ClickButton("/html/body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div[2]/detail-content-right/div/div[1]/basic-info-tab/form/div/div[5]/editable/opal-select/ng-select/ng-dropdown-panel/div/div[2]/div/div");

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
            autoIt.Send("Division 37");
            autoIt.Send("{TAB}");

            // Owner Branch/ Unit
            Thread.Sleep(2000);
            addingCourse.ClickButton._ClickButton("//provider-info-tab//div[2]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Branch 37");
            autoIt.Send("{TAB}");

            // Phone MOE Officer (Owner Division)
            addingCourse.ClickButton._ClickButton("//provider-info-tab//div[5]//editable[1]//input[1]");
            autoIt.Send("0123456789");

            // Notional Cost
            addingCourse.ClickButton._ClickButton("//div[7]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("1000");

            // Course Fee
            addingCourse.ClickButton._ClickButton("//div[8]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("10");

            //// --Metadata--
            // Service Scheme
            addingCourse.ClickButton._ClickButton("//metadata-tab//div//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Executive and Administrative Staff");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);

            // Subject
            addingCourse.ClickButton._ClickButton("//body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div/detail-content-right/div/div/metadata-tab/form/div/div[2]/editable[1]/opal-select[1]/ng-select[1]/div[1]");
            autoIt.Send("Corporate Services");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);


            // PD Area/ Theme
            addingCourse.ClickButton._ClickButton("//body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div/detail-content-right/div/div/metadata-tab/form/div[1]");
            autoIt.Send("Corporate Services");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);


            // Learning Framework
            addingCourse.ClickButton._ClickButton("//metadata-tab//div[4]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("HQ EAS Core (MX14 and above)");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);


            // Learning Dimension
            addingCourse.ClickButton._ClickButton("//metadata-tab//div[5]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Collaboration and Engagement");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);


            // Learning Area
            addingCourse.ClickButton._ClickButton("//metadata-tab//div[6]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Collaboration and Engagement");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);


            // Course Level
            addingCourse.ClickButton._ClickButton("//metadata-tab//div[8]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Leading");
            autoIt.Send("{ENTER}");
            Thread.Sleep(1000);


            //// --Copyright--
            // Copyright Owner
            addingCourse.ClickButton._ClickButton("//copyright-tab//div[2]//div[1]//editable[1]//input[1]");
            autoIt.Send("Testing 3");

            //// --Target Audience--
            // Place of Work
            addingCourse.ClickButton._ClickButton("//body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div/detail-content-right/div/div/target-audience-tab/form/div/div/editable/div/div[2]/input[1]");//Organisation

            // Division
            addingCourse.ClickButton._ClickButton("//body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div/detail-content-right/div/div/target-audience-tab/form/div/div[4]/editable[1]/opal-select[1]/ng-select[1]/div[1]/div[1]/div[2]/input[1]");
            autoIt.Send("Division 37");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Branch
            addingCourse.ClickButton._ClickButton("//body/app-root/app-shell/div/cam-outlet/div/div/div/cam-app/course-detail-page/div/div/kendo-tabstrip/div/detail-content-fragment/div/div/detail-content-right/div/div/target-audience-tab/form/div/div[5]/editable[1]/opal-select[1]/ng-select[1]/div[1]/div[1]/div[2]/input[1]");
            autoIt.Send("Branch 37");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            //// --User Profile--
            // Track
            addingCourse.ClickButton._ClickButton("//target-audience-tab//div//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("MOE HQ");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Developmental Role
            addingCourse.ClickButton._ClickButton("//target-audience-tab//div//div//div[2]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Director");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Job Family
            addingCourse.ClickButton._ClickButton("//target-audience-tab//div[5]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Citizen Engagement");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // EAS Substantive Grade Banding
            addingCourse.ClickButton._ClickButton("//div//div//div//div//div//div//div//div//div//div//div//div//div//div[8]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("HQ EAS Core (MX14 and above)");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            //// --Course Planning--
            // Nature of Course
            addingCourse.ClickButton._ClickButton("//course-planning-tab//div//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Full-time");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Number of Classes Planned
            addingCourse.ClickButton._ClickButton("//course-planning-tab//div[3]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("10");

            // Number of Sessions Per Class
            addingCourse.ClickButton._ClickButton("//course-planning-tab//div[4]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("10");

            // Number of Hours Per Session
            addingCourse.ClickButton._ClickButton("//div//div//div//div//div//div//div//div//div//div//div//div[5]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("10");


            // Date & Time Publish Course
            //addingCourse.ClickButton._ClickButton("//div[7]//editable[1]//kendo-datepicker[1]//span[1]//kendo-dateinput[1]//span[1]//input[1]");
            autoIt.Send("{TAB}");
            autoIt.Send("260620");

            // Date & Time to Archive Course
            //addingCourse.ClickButton._ClickButton("//div[8]//editable[1]//kendo-datepicker[1]//span[1]//kendo-dateinput[1]//span[1]//input[1]");
            autoIt.Send("{TAB}");
            autoIt.Send("260720");

            // Period of PD Activity
            addingCourse.ClickButton._ClickButton("//course-planning-tab//div[2]//input[1]");
            autoIt.Send("Term 1");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Minimum Participants Per Class
            addingCourse.ClickButton._ClickButton("//div[10]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("10");

            // Maximum Participants Per Class
            addingCourse.ClickButton._ClickButton("//div[11]//editable[1]//kendo-numerictextbox[1]//span[1]//input[1]");
            autoIt.Send("30");

            //// --Evaluation & E-Certificate
            // Post Course Evaluation Form
            addingCourse.ClickButton._ClickButton("//evaluation-ecertificate-tab//div//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("Basketball - Post Survey by Urek");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            //// --Course Administration--
            // Course Administrator(1st)
            addingCourse.ClickButton._ClickButton("//body//div//div//div//div//div//div//div//div//div//div//div//div//div[1]//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("urek-sa-01");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Primary Approving Officer
            addingCourse.ClickButton._ClickButton("//div//div//div//div//div//div//div//div//div//div//div//div[2]//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[2]//input[1]");
            autoIt.Send("urek-sa-01");
            autoIt.Send("{TAB}");
            Thread.Sleep(1000);

            // Course Facilitator
            addingCourse.ClickButton._ClickButton("//course-administration-tab//div[3]//div[1]//editable[1]//opal-select[1]//ng-select[1]//div[1]//div[1]//div[1]");
            autoIt.Send("urek-cf-01");
            autoIt.Send("{TAB}");



            //Thumbnail
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