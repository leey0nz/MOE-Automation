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

            Thread.Sleep(2000);
            autoIt.Send("Basketball 01");
            //addingCourse.EnterTextBox.EnterTexts("//input[@class='form-control ng-pristine ng-invalid ng-star-inserted ng-touched']", "Basketball 01");
            autoIt.Send("{TAB}, {ENTER}, Course/ Workshop");
            //autoIt.Send("Course/ Workshop"); //Type
            autoIt.Send("{ENTER}, {TAB}, 10");//Duration (Hours)
            //autoIt.Send("{TAB}");
            //autoIt.Send("10");
            autoIt.Send("{TAB}, 10");//Duration (Minutes)
            //autoIt.Send("10");
            autoIt.Send("{TAB},{ENTER}");
            autoIt.Send("MOE Mandatory");//Categories
            autoIt.Send("{TAB}, {TAB}, {ENTER}");
            autoIt.Send("E-Learning");// Mode of Learner
            autoIt.Send("{ENTER}, {TAB}");
            autoIt.Send("0F001");
            addingCourse.ClickButton._CheckSpinner();
            //addingCourse.EnterTextBox.EnterTexts("//basic-info-tab//div[8]//editable[1]//input[1]","Of001");
            addingCourse.ClickButton._ClickButton("//div[10]//editable[1]//textarea[1]");
            autoIt.Send("Testing1");
            addingCourse.EnterTextBox.EnterTexts("//div[11]//editable[1]//textarea[1]", "Testing2");


            //Image
            addingCourse.ClickButton._ClickByFindElement("//div[@class='opal-file-uploader__drop-file-area column align-center-center -show']");
            autoIt.Send("C:\\Users\\tuan.trinh\\Downloads\\i.jpg");
            autoIt.Send("{ENTER}");
            addingCourse.ClickButton._ClickButton("//button[@class='k-button ng-star-inserted']");


            //addingCourse.ClickButton._ClickButton("//body[@class='ng-tns-0-2']/app-root[@class='page-host']/app-shell[@class='app-shell column flex']/div[@class='page-wrapper row flex']/cam-outlet[@class='outlet-container']/div[@class='match-parent column']/div[@class='page-content']/div[@class='d-flex flex-grow-1 flex-shrink-0']/cam-app[@class='match-parent flex cam-module']/course-detail-page[@class='flex home-module ng-star-inserted']/div[@class='content-management-container']/div[@class='content-management detail-page']/kendo-tabstrip[@class='opal-tabstrip -no-marge ng-tns-c0-3 k-widget k-tabstrip k-floatwrap k-header k-tabstrip-top']/div[@class='ng-tns-c0-3 k-content k-state-active ng-trigger ng-trigger-state ng-star-inserted']/detail-content-fragment[@class='f-detail-content-container ng-star-inserted']/div[@class='detail-content']/div[contains(@class,'f-right-content-container')]/detail-content-right/div[@class='scrollable-menu-content']/div[@class='scrollable-menu-content__tab-content']/provider-info-tab/form[@class='ng-invalid ng-touched ng-dirty']/div[@class='form-container']/div[1]/editable[1]/div[1]/div[1]/input[1]");
            //addingCourse.ClickButton._ClickButton("//provider-info-tab//input[@class='form-control ng-untouched ng-pristine ng-invalid ng-star-inserted']");
            //addingCourse.ClickButton._ClickButton("//span[contains(text(),'Directorate')]");
            //addingCourse.ClickMenu.ClickTabMenu("//label[contains(text(),'Type of PD Activity')]");
            //addingCourse.ClickButton._ClickButton("//ng-select[@class='opal-select ng-select ng-select-single ng-select-searchable ng-pristine ng-valid ng-select-bottom ng-touched']//div[@class='ng-select-container']");
            //addingCourse.ClickButton._ClickButton("//span[@class='ng-option-label ng-star-inserted'][contains(text(),'Course')]");
            //addingCourse.EnterTextBox.EnterTexts("//kendo-numerictextbox[@class='form-control k-widget k-numerictextbox ng-pristine ng-invalid ng-star-inserted ng-touched']//input[@class='k-input k-formatted-value']", "10");

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