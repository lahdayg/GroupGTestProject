using NUnit.Framework;
using NUnitTestProject1.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        LoginPage loginpage;

        public LoginSteps()
        {
            loginpage = new LoginPage();
        }







        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            loginpage.NavigateToWebsite();
        }

        
        [Given(@"I click on Signup Button")]
        public void GivenIClickOnSignButton()
        {
            loginpage.ClickOnSignInButton(); 
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            loginpage.EnterUsername();
        }
        
        [Given(@"I enter my email addresss")]
        public void GivenIEnterMyEmailAddresss()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            loginpage.EnterPassword();
        }
        
        [When(@"I click on the sign up button")]
        public void WhenIClickOnTheSignUpButton()
        {
            loginpage.ClickOnSignUp();
        }
        
        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(loginpage.IsNewArticleDisplayed);
        }

        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            loginpage.EnterEmail();
        }

    }
}


