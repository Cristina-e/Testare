using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitProject.Driver
{
    public class Chrome
    {
        public static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver();
        }
    }

}
