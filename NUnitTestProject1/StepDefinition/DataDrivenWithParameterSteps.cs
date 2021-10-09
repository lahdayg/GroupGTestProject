using NUnitTestProject1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        
            DataDrivenWithParameterPage dataDrivenWithParameterPage;

            public DataDrivenWithParameterSteps()
            {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
            }




            [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter username text ""(.*)""")]
        public void GivenIEnterUsernameText(string UsernameText)
        {
            dataDrivenWithParameterPage.EnterUsername(UsernameText);
        }
        
        [Given(@"I enter my email address ""(.*)""")]
        public void GivenIEnterMyEmailAddress(string EmailText)
        {
            dataDrivenWithParameterPage.EnterEmail(EmailText);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string PasswordText)
        {
            dataDrivenWithParameterPage.EnterPassword(PasswordText);
        }
    }
}
