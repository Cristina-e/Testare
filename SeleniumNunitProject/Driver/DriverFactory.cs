using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BrowserType
{
    Chrome,
    Firefox,
    Edge,
    Safari
}
namespace SeleniumNunitProject.Driver
{
    public class DriverFactory
    {
        public static IWebDriver GetDriver(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    return Chrome.GetChromeDriver();
                case BrowserType.Firefox:
                    return Firefox.GetFirefoxDriver();
                case BrowserType.Edge:
                    return Edge.GetEdgeDriver();
                default:
                    throw new NotSupportedException("Browser type not supported.");
            }
        }
    }
}

