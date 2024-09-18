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
        public HeaderPage header = new HeaderPage(driver);
        public LoginPage login = new LoginPage(driver);

        public InitPage(IWebDriver driver) : base(driver) 
        {

        }
    }
}
