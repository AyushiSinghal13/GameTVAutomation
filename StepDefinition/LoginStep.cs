using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GameTVAutomation.StepDefinition
{
    [Binding]
    public class LoginStep
    {
        [Given(@"I navigate to homepage")]
        public void GivenINavigateToHomepage()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\aysinghal\Desktop\New folder\GitHub\report.html");
            var report = new ExtentReports();

            report.AttachReporter(htmlReporter);

            //feature
            var featureExtent = report.CreateTest<Feature>("Login");


            //scenario
            var scenarioExtent = featureExtent.CreateNode<Scenario>("Login as admin");


            //step
            var stepExtent = scenarioExtent.CreateNode<Given>("I navigate to homepage");
            report.Flush();
            Console.WriteLine("test step");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            Console.WriteLine("test step");
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            Console.WriteLine("test step");
        }

        [Then(@"I should see user is logged in")]
        public void ThenIShouldSeeUserIsLoggedIn()
        {
            Console.WriteLine("test step");
        }

    }
}
