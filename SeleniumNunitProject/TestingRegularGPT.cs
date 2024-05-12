using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Threading;
using SeleniumNunitProject.Driver;
using System.Drawing;

namespace SeleniumNunitProject
{
    [TestFixture]
    public class RegularUserTests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); // You can replace ChromeDriver with FirefoxDriver or other WebDriver based on your preference
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }

        [Test]
        public void RegularUserCanTakeQuiz()
        {
            // Navigate to the registration page and register as a regular user
            driver.Navigate().GoToUrl("http://localhost:5106/");
            driver.FindElement(By.LinkText("Registration")).Click();
            driver.FindElement(By.Id("Username")).SendKeys("regularuser");
            driver.FindElement(By.Id("Password")).SendKeys("password123");
            driver.FindElement(By.Id("PasswordConfirm")).SendKeys("password123");
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(2000);
            // Login as the regular user
            driver.FindElement(By.Id("Username")).SendKeys("regularuser");
            driver.FindElement(By.Id("Password")).SendKeys("password123");
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();

            // Navigate to the available quizzes and start one
            driver.FindElement(By.LinkText("All quizzes")).Click();
            driver.FindElement(By.LinkText("Start quiz")).Click();

            // Answer the quiz questions
            var quizQuestions = driver.FindElements(By.CssSelector(".quiz-question"));
            foreach (var question in quizQuestions)
            {
                var options = question.FindElements(By.CssSelector("input[type='radio']"));
                // Assuming the user selects the first option for each question
                options[0].Click();
            }

            // Finish the quiz
            driver.FindElement(By.Id("btnFinish")).Click();

            // Assert that the quiz results are displayed
            Assert.IsTrue(driver.FindElement(By.CssSelector(".quiz-results")).Displayed);
        }
    }
}
