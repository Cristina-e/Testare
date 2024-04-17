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

namespace SeleniumNunitProject
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            
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
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Registration")).Click();
            driver.FindElement(By.Id("Username")).Click();
            driver.FindElement(By.Id("Username")).SendKeys("creator1");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("creator1");
            driver.FindElement(By.Id("PasswordConfirm")).Click();
            driver.FindElement(By.Id("PasswordConfirm")).SendKeys("creator1");
            SelectElement selectElement= new SelectElement(driver.FindElement(By.Id("Role")));
            selectElement.SelectByText("Quiz Creator");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Register']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Username")).Click();
            driver.FindElement(By.Id("Username")).SendKeys("creator1");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("creator1");
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("My quizzes")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".rounded-circle")).Click();
            driver.FindElement(By.Id("Name")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("CreatorTest");
            driver.FindElement(By.Id("Description")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("This is a test for my creator");
            Thread.Sleep(2000);
            SelectElement selectElement2 = new SelectElement(driver.FindElement(By.Id("Category")));
            selectElement2.SelectByText("ComputerScience");
      
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Create Quiz']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Update")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Description")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("update");
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            driver.FindElement(By.LinkText("Add question")).Click();
            driver.FindElement(By.Id("QuestionName")).Click();
            driver.FindElement(By.Id("QuestionName")).SendKeys("Is Nunit a testing framework for c#?");
            driver.FindElement(By.Id("txtFirstOption")).Click();
            driver.FindElement(By.CssSelector(".fa-square")).Click();
            driver.FindElement(By.Id("CorrectAnswer")).Click();
            driver.FindElement(By.Id("CorrectAnswer")).SendKeys("true");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CorrectAnswerPoints")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CorrectAnswerPoints")).SendKeys("200");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Add question")).Click();
            driver.FindElement(By.Id("QuestionName")).Click();
            driver.FindElement(By.Id("QuestionName")).SendKeys("Choose a testing framework for c#?");
            driver.FindElement(By.Id("txtFirstOption")).Click();
            driver.FindElement(By.Id("txtFirstOption")).SendKeys("JUnit");
            driver.FindElement(By.Id("txtSecondOption")).Click();
            driver.FindElement(By.Id("txtSecondOption")).SendKeys("NUnit");
            driver.FindElement(By.Id("txtThirdOption")).Click();
            driver.FindElement(By.Id("txtThirdOption")).SendKeys("Cucumber");
            driver.FindElement(By.Id("txtFourthOption")).Click();
            driver.FindElement(By.Id("txtFourthOption")).SendKeys("Behave");
            driver.FindElement(By.Id("CorrectAnswer")).Click();
            driver.FindElement(By.Id("CorrectAnswer")).SendKeys("NUnit");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("tr:nth-child(13) > .w-75")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CorrectAnswerPoints")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CorrectAnswerPoints")).SendKeys("600");
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(".publish-btn")).Click();
            driver.FindElement(By.CssSelector("#publishForm > .btn-primary")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//div[h4[text()='CreatorTest']]//a[text()='Start quiz']")).Click();

            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(".radio:nth-child(4) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(10) > .fa-circle")).Click();
            driver.FindElement(By.Id("btnFinish")).Click();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.LinkText("All quizzes")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(".delete-btn")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Quiz results")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("statusFilter")).Click();
            {
                var dropdown = driver.FindElement(By.Id("statusFilter"));
                dropdown.FindElement(By.XPath("//option[. = 'Passed']")).Click();
            }
            Thread.Sleep(4000);
            {
                var element = driver.FindElement(By.Id("minimumScoreFilter"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).ClickAndHold().Perform();
            }
            {
                var element = driver.FindElement(By.Id("minimumScoreFilter"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            Thread.Sleep(4000);
            {
                var element = driver.FindElement(By.Id("minimumScoreFilter"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Release().Perform();
            }
            Thread.Sleep(4000);
            driver.FindElement(By.Id("minimumScoreFilter")).SendKeys("62");
            driver.FindElement(By.Id("minimumScoreFilter")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.Id("sortAscendingBtn")).Click();
            driver.FindElement(By.Id("filterBtn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();

            Assert.Pass();
        }

        [Test]
        public void TestAdmin() {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector(".navbar-toggler")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("Username")).Click();
            driver.FindElement(By.Id("Username")).SendKeys("admin");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("admin");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[text()='Login']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            /*
            Thread.Sleep(5000);
            driver.FindElement(By.LinkText("All quizzes")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".flex-even:nth-child(1) > .quiz-div:nth-child(6) > .delete-btn")).Click();
            driver.FindElement(By.CssSelector(".btn-primary")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            */
            driver.FindElement(By.LinkText("My quizzes")).Click();
            driver.FindElement(By.CssSelector(".rounded-circle")).Click();
            driver.FindElement(By.Id("Name")).Click();
            driver.FindElement(By.Id("Name")).SendKeys("AdminTest");
            driver.FindElement(By.Id("Description")).Click();
            driver.FindElement(By.Id("Description")).SendKeys("This is just a test for my admin");
            driver.FindElement(By.Id("Category")).Click();
            {
                var dropdown = driver.FindElement(By.Id("Category"));
                dropdown.FindElement(By.XPath("//option[. = 'Math']")).Click();
            }
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            driver.FindElement(By.LinkText("Add question")).Click();
            driver.FindElement(By.Id("QuestionName")).Click();
            driver.FindElement(By.Id("QuestionName")).SendKeys("What is 5+5 equal to?");
            driver.FindElement(By.Id("txtFirstOption")).Click();
            driver.FindElement(By.Id("txtFirstOption")).SendKeys("66");
            driver.FindElement(By.Id("txtSecondOption")).Click();
            driver.FindElement(By.Id("txtSecondOption")).SendKeys("55");
            driver.FindElement(By.Id("txtThirdOption")).Click();
            driver.FindElement(By.Id("txtThirdOption")).SendKeys("10");
            driver.FindElement(By.Id("txtFourthOption")).Click();
            driver.FindElement(By.Id("txtFourthOption")).SendKeys("11");
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CorrectAnswer")).Click();
            driver.FindElement(By.Id("CorrectAnswer")).SendKeys("10");
            driver.FindElement(By.Id("CorrectAnswerPoints")).Click();
            driver.FindElement(By.Id("CorrectAnswerPoints")).SendKeys("2");
            Thread.Sleep(3000);
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            driver.FindElement(By.LinkText("Add question")).Click();
            driver.FindElement(By.CssSelector(".fa-square")).Click();
            driver.FindElement(By.Id("QuestionName")).Click();
            driver.FindElement(By.Id("QuestionName")).SendKeys("Is 5 greater than 4?");
            driver.FindElement(By.Id("CorrectAnswer")).Click();
            driver.FindElement(By.Id("CorrectAnswer")).SendKeys("true");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("CorrectAnswerPoints")).Click();
            driver.FindElement(By.Id("CorrectAnswerPoints")).SendKeys("3");
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".publish-btn")).Click();
            driver.FindElement(By.CssSelector("#publishForm > .btn-primary")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".flex-even:nth-child(2) > .quiz-div:nth-child(7) > .text-danger:nth-child(4)")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector(".radio:nth-child(6) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(11) > .fa-circle")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("btnFinish")).Click();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Quiz results")).Click();
            driver.FindElement(By.Id("statusFilter")).Click();
            {
                var dropdown = driver.FindElement(By.Id("statusFilter"));
                dropdown.FindElement(By.XPath("//option[. = 'Passed']")).Click();
            }
            driver.FindElement(By.Id("minimumScoreFilter")).Click();
            driver.FindElement(By.Id("minimumScoreFilter")).SendKeys("42");
            driver.FindElement(By.Id("minimumScoreFilter")).Click();
            driver.FindElement(By.Id("sortAscendingBtn")).Click();
            driver.FindElement(By.Id("filterBtn")).Click();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        [Test]
        public void TestRegular()
        {
            driver.Navigate().GoToUrl("http://localhost:5106/");
            driver.Manage().Window.Size = new System.Drawing.Size(1296, 688);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Registration")).Click();
            driver.FindElement(By.Id("Username")).Click();
            driver.FindElement(By.Id("Username")).SendKeys("regular1");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("regular1");
            driver.FindElement(By.Id("PasswordConfirm")).Click();
            driver.FindElement(By.Id("PasswordConfirm")).SendKeys("regular1");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("Username")).Click();
            driver.FindElement(By.Id("Username")).SendKeys("regular1");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).SendKeys("regular1");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".btn:nth-child(1)")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("All quizzes")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.LinkText("Start quiz")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(5) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(9) > .fa-circle")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".radio:nth-child(14) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(20) > .fa-circle")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".radio:nth-child(24) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(30) > .fa-circle")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".radio:nth-child(35) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(40) > .fa-circle")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".radio:nth-child(44) > .fa-circle")).Click();
            driver.FindElement(By.CssSelector(".radio:nth-child(50) > .fa-circle")).Click();
            driver.FindElement(By.Id("btnFinish")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Quiz results")).Click();
            driver.FindElement(By.Id("statusFilter")).Click();
            {
                var dropdown = driver.FindElement(By.Id("statusFilter"));
                dropdown.FindElement(By.XPath("//option[. = 'Passed']")).Click();
            }
            driver.FindElement(By.Id("minimumScoreFilter")).SendKeys("58");
            driver.FindElement(By.Id("minimumScoreFilter")).Click();
            driver.FindElement(By.Id("sortDescendingBtn")).Click();
            driver.FindElement(By.Id("filterBtn")).Click();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.Name("term")).Click();
            driver.FindElement(By.Name("term")).SendKeys("test");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
            driver.FindElement(By.CssSelector(".navbar-toggler-icon")).Click();
        }
    }
    
}
