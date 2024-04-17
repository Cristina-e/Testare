using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;

namespace PlaywrightNunitProject
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public async Task TestCreator()
        {
            await Page.GotoAsync("http://localhost:5106/");
            // Click on the navbar-toggler-icon
            await Page.ClickAsync(".navbar-toggler-icon");
            await Page.ClickAsync("text=Login");
            /*
            // Click on the Registration link
            await Page.ClickAsync("text=Registration");

            // Fill in the registration form
            await Page.FillAsync("#Username", "creator1", new() { Timeout = 3000 });
            await Page.FillAsync("#Password", "creator1", new() { Timeout = 3000 });
            await Page.FillAsync("#PasswordConfirm", "creator1", new() { Timeout = 3000 });
            await Page.SelectOptionAsync("#Role", "Quiz Creator", new() { Timeout = 5000 });
            await Page.ClickAsync("button:text('Register')", new() { Timeout = 9000 });
            */
            // Log in
            await Page.FillAsync("#Username", "creator1", new() { Timeout = 10000 });
            await Page.FillAsync("#Password", "creator1", new() { Timeout = 10000 });
            await Page.ClickAsync("button:text('Login')", new() { Timeout = 9000 });

            // Navigate to My quizzes
            await Page.ClickAsync(".navbar-toggler-icon", new() { Timeout = 9000 });
            await Page.WaitForSelectorAsync("text=My quizzes", new() { Timeout = 10000 });

            // Click on the "My quizzes" link
            await Page.ClickAsync("text=My quizzes");
            // Create a new quiz
            await Page.ClickAsync(".rounded-circle");
            await Page.FillAsync("#Name", "CreatorTest");
            await Page.FillAsync("#Description", "This is a test for my creator");
            await Page.SelectOptionAsync("#Category", "ComputerScience");
            await Page.ClickAsync("button:text('Create Quiz')");

            // Update quiz
            await Page.ClickAsync("text=Update");
            await Page.FillAsync("#Description", "update");
            await Page.ClickAsync(".btn:nth-child(1)");

            // Add questions
            await Page.ClickAsync("text=Add question");
            await Page.FillAsync("#QuestionName", "Is NUnit a testing framework for C#?");
            await Page.ClickAsync(".fa-square");
            await Page.FillAsync("#CorrectAnswer", "true");
            await Page.FillAsync("#CorrectAnswerPoints", "200");
            await Page.ClickAsync(".btn:nth-child(1)");

            await Page.ClickAsync("text=Add question");
            await Page.FillAsync("#QuestionName", "Choose a testing framework for C#?");
            await Page.FillAsync("#txtFirstOption", "JUnit");
            await Page.FillAsync("#txtSecondOption", "NUnit");
            await Page.FillAsync("#txtThirdOption", "Cucumber");
            await Page.FillAsync("#txtFourthOption", "Behave");
            await Page.FillAsync("#CorrectAnswer", "NUnit");
            await Page.FillAsync("#CorrectAnswerPoints", "600");
            await Page.ClickAsync(".btn:nth-child(1)");

            // Publish quiz
            await Page.ClickAsync(".publish-btn");
            await Page.ClickAsync("#publishForm > .btn-primary");

            // Start the quiz
            await Page.ClickAsync("//div[h4[text()='CreatorTest']]//a[text()='Start quiz']");

            // Answer questions
            await Page.ClickAsync(".radio:nth-child(4) > .fa-circle");
            await Page.ClickAsync(".radio:nth-child(10) > .fa-circle");
            await Page.ClickAsync("#btnFinish");

            // Navigate to All quizzes
            await Page.ClickAsync(".navbar-toggler-icon");
            await Page.ClickAsync("text=All quizzes");

            // Delete the quiz
            await Page.ClickAsync(".delete-btn");
            await Page.ClickAsync(".btn-primary");

            // Navigate to Quiz results
            await Page.ClickAsync(".navbar-toggler-icon");
            await Page.ClickAsync("text=Quiz results");

            // Filter and sort quiz results
            await Page.SelectOptionAsync("#statusFilter", "Passed");
            await Page.FillAsync("#minimumScoreFilter", "62");
            await Page.ClickAsync("#sortAscendingBtn");
            await Page.ClickAsync("#filterBtn");

            // Logout
            await Page.ClickAsync(".navbar-toggler-icon");
            await Page.ClickAsync("text=Logout");
        }
    }
}
