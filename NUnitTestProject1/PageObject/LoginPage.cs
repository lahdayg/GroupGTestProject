using NUnitTestProject1.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PageObject
{
    class LoginPage
    {

        public LoginPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignIn => driver.FindElement(By.CssSelector("body > div.ng-scope > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));

        IWebElement Username => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement Email => driver.FindElement(By.CssSelector("body > div.ng-scope > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));

        IWebElement Password => driver.FindElement(By.XPath("/html/body/div[1]/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        IWebElement SignUp => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));






        public void ClickOnSignInButton()
        {
            SignIn.Click();
        }

        public void EnterUsername()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys("TestAutomation" + randomInt);
            //Username.SendKeys("TestAutomation09444");
        }

        public void EnterEmail()
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys("testdemo" + randomInt + "@gmail.com");
            //Email.SendKeys("demodemo7578973@example.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("PasswordSecure");
        }

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }




















    }
}
