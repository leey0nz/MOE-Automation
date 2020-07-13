using UI.Common.UI;
using OpenQA.Selenium;

namespace CAM
{
    public class ApproveCourse
    {
        public SelectTabMenu ClickMenu { get; set; }
        public SelectButton ClickButton { get; set; }
        public SelectSubMenu ClickSubMenu { get; set; }
        public EnterText EnterTextBox { get; set; }
        public EnterText EnterTextBoxByElement { get; set; }
        public ApproveCourse(IWebDriver driver)
        {
            ClickMenu = new SelectTabMenu(driver, "");
            ClickButton = new SelectButton(driver, "");
            ClickSubMenu = new SelectSubMenu(driver, "");
            EnterTextBox = new EnterText(driver, "");
            EnterTextBoxByElement = new EnterText(driver, "");
        }
    }
}
