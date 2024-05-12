using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Threading;
using SeleniumNunitProject.Driver;
using System.Drawing;

namespace SeleniumNunitProject
{
    [TestFixture(600)]
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        private int width_;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        public Tests(int width)
        {
            width_ = width;
        }
        [SetUp]
        public void SetUp()
        {   
            BrowserType browserType = BrowserType.Chrome; 
            driver = DriverFactory.GetDriver(browserType);
            //testam tipuri diferite de browser
            driver.Manage().Window.Size = new System.Drawing.Size(width_, 600);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            
        }
        public IWebElement ScrollToElement(By locator)
        {
            IWebElement element = driver.FindElement(locator);

            Actions actions = new Actions(driver);

            actions.MoveToElement(element);
            actions.Perform();

            
            return element;
        }
        private void ClickNavItem_(By locator)
        {
            var menuButton = driver.FindElement(By.CssSelector(".navbar-toggler-icon"));
            if (menuButton.Displayed) 
            { 
                menuButton.Click();
            }
            driver.FindElement(locator).Click();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void TestCreator()
        {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            //driver.Manage().Window.Maximize();
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            //ClickNavItem_(By.LinkText("Login"));
            
            ClickNavItem_(By.LinkText("Registration"));
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("creator1");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("creator1");
            ScrollToElement(By.Id("PasswordConfirm")).Click();
            ScrollToElement(By.Id("PasswordConfirm")).SendKeys("creator1");
            SelectElement selectElement= new SelectElement(ScrollToElement(By.Id("Role")));
            selectElement.SelectByText("Quiz Creator");
            //Thread.Sleep(2000);
            ScrollToElement(By.XPath("//button[text()='Register']")).Click();
            
            Thread.Sleep(2000);
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("creator1");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("creator1");
            ScrollToElement(By.XPath("//button[text()='Login']")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            Thread.Sleep(2000);
            ClickNavItem_(By.LinkText("My quizzes"));
            Thread.Sleep(1000);
            ScrollToElement(By.CssSelector(".rounded-circle")).Click();
            ScrollToElement(By.Id("Name")).Click();
            ScrollToElement(By.Id("Name")).SendKeys("CreatorTest");
            ScrollToElement(By.Id("Description")).Click();
            ScrollToElement(By.Id("Description")).SendKeys("This is a test for my creator");
            //Thread.Sleep(2000);
            SelectElement selectElement2 = new SelectElement(ScrollToElement(By.Id("Category")));
            selectElement2.SelectByText("ComputerScience");
      
            //Thread.Sleep(2000);
            ScrollToElement(By.XPath("//button[text()='Create Quiz']")).Click();
            //Thread.Sleep(2000);
            ScrollToElement(By.LinkText("Update")).Click();
            //Thread.Sleep(2000);
            ScrollToElement(By.Id("Description")).Click();
            ScrollToElement(By.Id("Description")).SendKeys("update");
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            ScrollToElement(By.LinkText("Add question")).Click();
            ScrollToElement(By.Id("QuestionName")).Click();
            ScrollToElement(By.Id("QuestionName")).SendKeys("Is Nunit a testing framework for c#?");
            ScrollToElement(By.Id("txtFirstOption")).Click();
            ScrollToElement(By.CssSelector(".fa-square")).Click();
            ScrollToElement(By.Id("CorrectAnswer")).Click();
            ScrollToElement(By.Id("CorrectAnswer")).SendKeys("true");
            //Thread.Sleep(3000);
            ScrollToElement(By.Id("CorrectAnswerPoints")).Click();
            //Thread.Sleep(3000);
            ScrollToElement(By.Id("CorrectAnswerPoints")).SendKeys("200");
            //Thread.Sleep(3000);
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            //Thread.Sleep(3000);
            ScrollToElement(By.LinkText("Add question")).Click();
            ScrollToElement(By.Id("QuestionName")).Click();
            ScrollToElement(By.Id("QuestionName")).SendKeys("Choose a testing framework for c#?");
            ScrollToElement(By.Id("txtFirstOption")).Click();
            ScrollToElement(By.Id("txtFirstOption")).SendKeys("JUnit");
            ScrollToElement(By.Id("txtSecondOption")).Click();
            ScrollToElement(By.Id("txtSecondOption")).SendKeys("NUnit");
            ScrollToElement(By.Id("txtThirdOption")).Click();
            ScrollToElement(By.Id("txtThirdOption")).SendKeys("Cucumber");
            ScrollToElement(By.Id("txtFourthOption")).Click();
            ScrollToElement(By.Id("txtFourthOption")).SendKeys("Behave");
            ScrollToElement(By.Id("CorrectAnswer")).Click();
            ScrollToElement(By.Id("CorrectAnswer")).SendKeys("NUnit");
            //Thread.Sleep(3000);
            ScrollToElement(By.CssSelector("tr:nth-child(13) > .w-75")).Click();
            //Thread.Sleep(3000);
            ScrollToElement(By.Id("CorrectAnswerPoints")).Click();
            //Thread.Sleep(3000);
            ScrollToElement(By.Id("CorrectAnswerPoints")).SendKeys("600");
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            //Thread.Sleep(4000);
            ScrollToElement(By.CssSelector(".publish-btn")).Click();
            driver.FindElement(By.CssSelector("#publishForm > .btn-primary")).Click();
            //Thread.Sleep(4000);
            ScrollToElement(By.XPath("//div[h4[text()='CreatorTest']]//a[text()='Start quiz']")).Click();

            //Thread.Sleep(4000);
            ScrollToElement(By.CssSelector(".radio:nth-child(4) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(10) > .fa-circle")).Click();
            ScrollToElement(By.Id("btnFinish")).Click();
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            //Thread.Sleep(4000);
            ClickNavItem_(By.LinkText("All quizzes"));
            ScrollToElement(By.XPath("//div[h4[text()='CreatorTest']]//span[text()='Delete']")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.LinkText("Quiz results"));
            Thread.Sleep(2000);
            ScrollToElement(By.Id("statusFilter")).Click();
            {
                var dropdown = ScrollToElement(By.Id("statusFilter"));
                dropdown.FindElement(By.XPath("//option[. = 'Passed']")).Click();
            }
            Thread.Sleep(2000);
            {
                var element = ScrollToElement(By.Id("minimumScoreFilter"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = ScrollToElement(By.Id("minimumScoreFilter"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            Thread.Sleep(2000);
            {
                var element = ScrollToElement(By.Id("minimumScoreFilter"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            Thread.Sleep(1000);
            ScrollToElement(By.Id("minimumScoreFilter")).SendKeys("62");
            ScrollToElement(By.Id("minimumScoreFilter")).Click();
            Thread.Sleep(1000);
            ScrollToElement(By.Id("sortAscendingBtn")).Click();
            ScrollToElement(By.Id("filterBtn")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.LinkText("Logout"));

            Assert.Pass();
        }

        [Test]
        public void TestRegistrationGresit()
        {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            //driver.Manage().Window.Maximize();
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            //ClickNavItem_(By.LinkText("Login"));

            ClickNavItem_(By.LinkText("Registration"));
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("creator1");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("creator1");
            ScrollToElement(By.Id("PasswordConfirm")).Click();
            ScrollToElement(By.Id("PasswordConfirm")).SendKeys("creator");
            SelectElement selectElement = new SelectElement(ScrollToElement(By.Id("Role")));
            selectElement.SelectByText("Quiz Creator");
            //Thread.Sleep(2000);
            ScrollToElement(By.XPath("//button[text()='Register']")).Click();

            Thread.Sleep(2000);
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Passwords do not coincide!"));
            Assert.Pass();
        }
        [Test]
        public void TestLoginGresit()
        {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            //driver.Manage().Window.Maximize();
            //driver.FindElement(By.CssSelector(".navbar-toggler")).Click();
            ClickNavItem_(By.LinkText("Login"));
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("admin");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("adin");
            Thread.Sleep(2000);
            ScrollToElement(By.XPath("//button[text()='Login']")).Click();
            Thread.Sleep(2000);
            Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Invalid credentials!"));
            Assert.Pass();

        }

        [Test]
        public void TestAdmin() {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            //driver.Manage().Window.Maximize();
            //driver.FindElement(By.CssSelector(".navbar-toggler")).Click();
            ClickNavItem_(By.LinkText("Login"));
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("admin");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("admin");
            Thread.Sleep(2000);
            ScrollToElement(By.XPath("//button[text()='Login']")).Click();
            Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            /*
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("All quizzes")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".flex-even:nth-child(1) > .quiz-div:nth-child(6) > .delete-btn")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            */
            ClickNavItem_(By.LinkText("My quizzes"));
            ScrollToElement(By.CssSelector(".rounded-circle")).Click();
            ScrollToElement(By.Id("Name")).Click();
            ScrollToElement(By.Id("Name")).SendKeys("AdminTest");
            ScrollToElement(By.Id("Description")).Click();
            ScrollToElement(By.Id("Description")).SendKeys("This is just a test for my admin");
            ScrollToElement(By.Id("Category")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Category"));
                dropdown.FindElement(By.XPath("//option[. = 'Math']")).Click();
            }
            //Thread.Sleep(3000);
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            ScrollToElement(By.LinkText("Add question")).Click();
            ScrollToElement(By.Id("QuestionName")).Click();
            ScrollToElement(By.Id("QuestionName")).SendKeys("What is 5+5 equal to?");
            ScrollToElement(By.Id("txtFirstOption")).Click();
            ScrollToElement(By.Id("txtFirstOption")).SendKeys("66");
            ScrollToElement(By.Id("txtSecondOption")).Click();
            ScrollToElement(By.Id("txtSecondOption")).SendKeys("55");
            ScrollToElement(By.Id("txtThirdOption")).Click();
            ScrollToElement(By.Id("txtThirdOption")).SendKeys("10");
            ScrollToElement(By.Id("txtFourthOption")).Click();
            ScrollToElement(By.Id("txtFourthOption")).SendKeys("11");
            //Thread.Sleep(3000);
            ScrollToElement(By.Id("CorrectAnswer")).Click();
            ScrollToElement(By.Id("CorrectAnswer")).SendKeys("10");

            ScrollToElement(By.Id("CorrectAnswerPoints")).Click();
            ScrollToElement(By.Id("CorrectAnswerPoints")).SendKeys("2");
            //Thread.Sleep(3000);
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            ScrollToElement(By.LinkText("Add question")).Click();
            ScrollToElement(By.CssSelector(".fa-square")).Click();
            ScrollToElement(By.Id("QuestionName")).Click();
            ScrollToElement(By.Id("QuestionName")).SendKeys("Is 5 greater than 4?");
            ScrollToElement(By.Id("CorrectAnswer")).Click();
            ScrollToElement(By.Id("CorrectAnswer")).SendKeys("true");
            //Thread.Sleep(5000);
            ScrollToElement(By.Id("CorrectAnswerPoints")).Click();
            ScrollToElement(By.Id("CorrectAnswerPoints")).SendKeys("3");
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            ScrollToElement(By.CssSelector(".publish-btn")).Click();
            driver.FindElement(By.CssSelector("#publishForm > .btn-primary")).Click();
            Thread.Sleep(2000);

            ScrollToElement(By.XPath("//div[h4[text()='AdminTest']]//a[text()='Start quiz']")).Click();
            //Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".radio:nth-child(6) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(11) > .fa-circle")).Click();
            //Thread.Sleep(5000);
            ScrollToElement(By.Id("btnFinish")).Click();
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.LinkText("Quiz results"));
            ScrollToElement(By.Id("statusFilter")).Click();
            {
                var dropdown = ScrollToElement(By.Id("statusFilter"));
                dropdown.FindElement(By.XPath("//option[. = 'Passed']")).Click();
            }
            ScrollToElement(By.Id("minimumScoreFilter")).Click();
            ScrollToElement(By.Id("minimumScoreFilter")).SendKeys("42");
            ScrollToElement(By.Id("minimumScoreFilter")).Click();
            ScrollToElement(By.Id("sortAscendingBtn")).Click();
            ScrollToElement(By.Id("filterBtn")).Click();
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.LinkText("Logout"));
            Assert.Pass();
        }

        [Test]
        public void TestRegular()
        {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            //driver.Manage().Window.Size = new System.Drawing.Size(1296, 688);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.LinkText("Registration"));
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("regular1");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("regular1");
            ScrollToElement(By.Id("PasswordConfirm")).Click();
            ScrollToElement(By.Id("PasswordConfirm")).SendKeys("regular1");
            //Thread.Sleep(2000);
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            Thread.Sleep(2000);
            ScrollToElement(By.Id("Username")).Click();
            ScrollToElement(By.Id("Username")).SendKeys("regular1");
            ScrollToElement(By.Id("Password")).Click();
            ScrollToElement(By.Id("Password")).SendKeys("regular1");
            //Thread.Sleep(2000);
            ScrollToElement(By.CssSelector(".btn:nth-child(1)")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            Thread.Sleep(2000);
            ClickNavItem_(By.LinkText("All quizzes"));
            //Thread.Sleep(4000);
            ScrollToElement(By.LinkText("Start quiz")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(5) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(9) > .fa-circle")).Click();
            //Thread.Sleep(2000);
            ScrollToElement(By.CssSelector(".radio:nth-child(14) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(20) > .fa-circle")).Click();
            //Thread.Sleep(2000);
            ScrollToElement(By.CssSelector(".radio:nth-child(24) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(30) > .fa-circle")).Click();
            //Thread.Sleep(2000);
            ScrollToElement(By.CssSelector(".radio:nth-child(35) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(40) > .fa-circle")).Click();
            //Thread.Sleep(2000);
            ScrollToElement(By.CssSelector(".radio:nth-child(44) > .fa-circle")).Click();
            ScrollToElement(By.CssSelector(".radio:nth-child(50) > .fa-circle")).Click();
            ScrollToElement(By.Id("btnFinish")).Click();
            //Thread.Sleep(2000);
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            //Thread.Sleep(2000);
            ClickNavItem_(By.LinkText("Quiz results"));
            ScrollToElement(By.Id("statusFilter")).Click();
            {
                var dropdown = driver.FindElement(By.Id("statusFilter"));
                dropdown.FindElement(By.XPath("//option[. = 'Passed']")).Click();
            }
            ScrollToElement(By.Id("minimumScoreFilter")).SendKeys("58");
            ScrollToElement(By.Id("minimumScoreFilter")).Click();
            ScrollToElement(By.Id("sortDescendingBtn")).Click();
            ScrollToElement(By.Id("filterBtn")).Click();
            //driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.Name("term"));
            ScrollToElement(By.Name("term")).SendKeys("test");
            ScrollToElement(By.CssSelector(".btn")).Click();
           // driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            ClickNavItem_(By.LinkText("Logout"));
            Assert.Pass(); 
        }
    }
    
}
