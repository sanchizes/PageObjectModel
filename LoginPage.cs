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

        /*Знаходження елемента через лямбда-вираз властивості 
        private IWebElement btnGoogle => driver.FindElement(By.ClassName("button"));
        */

        private IWebElement btnGoogle
        {
            get { return driver.FindElement(By.XPath("//button[@class=\"button button--medium button--gray button--with-icon\"]")); }
        }

        //Знаходження елемента окремим методом InitElement(), але через це, цей метод також потрібно викликати в класі Authorization, перед методом Click()
        //private IWebElement btnGoogle;

        //public void InitElement()
        //{
        //    btnGoogle = driver.FindElement(By.XPath("//button[@class=\"button button--medium button--gray button--with-icon\"]"));
        //}

        public void ClickGoogle() => btnGoogle.Click();
    }
}
