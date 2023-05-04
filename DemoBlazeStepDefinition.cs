using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBlaze.StepDefinitions
{
    [Binding]
    public class DemoBlazeStepDefinition
    {
        static IWebDriver driver;
        [Given(@"I am in Home page of demoBlaze website")]
        public void GivenIAmInHomePageOfDemoBlazeWebsite()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();

        }

        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            driver.FindElement(By.Id("signin2")).Click();
            
        }

        [When(@"enter the username and password")]
        public void WhenEnterTheUsernameAndPassword()
        {
            driver.FindElement(By.Id("sign-username")).SendKeys("subhra");
            driver.FindElement(By.Id("sign-password")).SendKeys("subhra123");
        }

        [Then(@"by clicking signup I should be able to signup successfully")]
        public void ThenByClickingSignupIShouldBeAbleToSignupSuccessfully()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/button[2]")).Click();
            //var popup= driver.SwitchTo().Alert();
            //popup.Should().NotBeNull();
            //popup.Accept();
            driver.SwitchTo().Alert().Accept();
            
        
                
        }
        [Then(@"login to the website using the same")]
        public void ThenLoginToTheWebsiteUsingTheSame()
        {
            driver.FindElement(By.Id("login2")).Click();
            driver.FindElement(By.Id("loginusername")).SendKeys("subhra");
            driver.FindElement(By.Id("loginpassword")).SendKeys("subhra123");
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]")).Click();


        }


    }
}
