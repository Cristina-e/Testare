using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace SeleniumNunitProject.Driver
{
    public class Edge
    {
        public static IWebDriver GetEdgeDriver()
        {
            return new EdgeDriver();
        }
    }
}
