using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace GameTVAutomation.StepDefinition
{
    [Binding]
    public class UserFormStep
    {
        [Given(@"I start entering user details")]
        public void GivenIStartEnteringUserDetails()
        {
            Console.WriteLine("test step");
        }

        [Then(@"User details should be added successfully")]
        public void ThenUserDetailsShouldBeAddedSuccessfully()
        {
            Console.WriteLine("test step");
        }


    }
}
