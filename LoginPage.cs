using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) {}

        private IWebElement btnGoogle = driver.FindElement(By.XPath("//button[@type=\"button\" and @title=\"Google\"]"));

        public void ClickGoogle() => btnGoogle.Click();
    }
}
