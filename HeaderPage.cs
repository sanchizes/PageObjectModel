using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class HeaderPage : BasePage
    {
        public HeaderPage(IWebDriver driver) : base(driver) {}

        private IWebElement btnLogin => driver.FindElement(By.XPath("(//button[@class=\"header__button\"])[2]"));
        
        public void ClickLogin() => btnLogin.Click();
    }
}
