using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitProject.Driver
{
    public class Firefox
    {
        public static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver();
        }
    }

}
