using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium_Test
{
    class SelenimumSetMethods
    {
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }

        // click button , checkbox , option, etc
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }

        //Select a drop down Menu
        public static void selectingDropDownMenu(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            }

        }
    }
}
