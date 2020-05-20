using UI.Common.UI;
using OpenQA.Selenium;

namespace CAM
{
    public class AddCourse
    {
        public SelectTabMenu ClickMenu { get; set; }
        public SelectButton ClickButton { get; set; }
        public EnterText EnterTextBox { get; set; }
        public AddCourse(IWebDriver driver)
        {
            ClickMenu = new SelectTabMenu(driver, "");
            ClickButton = new SelectButton(driver, "");
            EnterTextBox = new EnterText(driver, "");
        }
    }
}
