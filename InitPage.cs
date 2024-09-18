using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    public class InitPage : BasePage
    {
        public HeaderPage header { get; private set; }
        public LoginPage login { get; private set; }

        public InitPage(IWebDriver driver) : base(driver) 
        {
            header = new HeaderPage(driver);
            login = new LoginPage(driver);
        }
    }
}
