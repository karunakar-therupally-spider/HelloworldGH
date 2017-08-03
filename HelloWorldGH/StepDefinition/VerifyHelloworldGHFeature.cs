using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace HelloWorldGH.StepDefinition
{
    [Binding]
    public sealed class VerifyHelloworldGHFeature
    {
        String siteUrl = "http://www.helloworld.com";
        IWebDriver fdriver = new FirefoxDriver();

        [Given(@"User navigates to HelloWorld site")]
        public void GivenUserNavigatesToHelloWorldSite()
        {
            fdriver.Navigate().GoToUrl(siteUrl);
            fdriver.Manage().Window.Maximize();
        }

        [When(@"Click on Platform Login")]
        public void WhenClickOnPlatformLogin()
        {
            fdriver.FindElement(OpenQA.Selenium.By.XPath("//li/a[contains(text(),'What We Do')]")).Click();
        }
        [Then(@"System should display Client Login Page")]
        public void ThenSystemShouldDisplayClientLoginPage()
        {

            fdriver.FindElement(OpenQA.Selenium.By.XPath("//div[@class='row']//h1[starts-with(text(),'Market')]")).Equals("Marketing Solutions for the World's Best Brands");
            fdriver.Close();
        }


    }
}
