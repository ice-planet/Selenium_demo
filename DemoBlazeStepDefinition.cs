using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Data;
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

            driver = new ChromeDriver("E:\\chromedriver.exe");
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();

        }

        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            driver.FindElement(By.Id("signin2")).Click();
            Thread.Sleep(2000);

        }

        [When(@"enter the username and password")]
        public void WhenEnterTheUsernameAndPassword()
        {
            driver.FindElement(By.Id("sign-username")).SendKeys("kaepsong");
            Thread.Sleep(500);
            driver.FindElement(By.Id("sign-password")).SendKeys("kaepsong123");
            Thread.Sleep(500);

        }

        [Then(@"by clicking signup I should be able to signup successfully")]
        public void ThenByClickingSignupIShouldBeAbleToSignupSuccessfully()
        {
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[3]/button[2]")).Click();
            //var popup= driver.SwitchTo().Alert();
            //popup.Should().NotBeNull();
            //popup.Accept();
            Thread.Sleep(4000);
            driver.SwitchTo().Alert().Accept();



        }
        [Then(@"login to the website using the same")]
        public void ThenLoginToTheWebsiteUsingTheSame()
        {
            driver.FindElement(By.Id("login2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("loginusername")).SendKeys("atlas");
            driver.FindElement(By.Id("loginpassword")).SendKeys("atlas123");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]")).Click();


        }

           
        [Given(@"user is loggedin")]
            void GivenUserIsLoggedin()
            {
            /* string currentUrl = driver.Url;
             Assert.That(currentUrl, Is.EqualTo("https://www.demoblaze.com/index.html"));
            */
            driver = new ChromeDriver("E:\\chromedriver.exe");
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();
           /* driver.FindElement(By.Id("login2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("loginusername")).SendKeys("atlas");
            driver.FindElement(By.Id("loginpassword")).SendKeys("atlas123");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]")).Click();
           */
            Thread.Sleep(1000);
        }

            [When(@"i clicked on contacts")]
            void WhenIClickedOnContacts()
            {
                driver.FindElement(By.LinkText("Contact")).Click();
                Thread.Sleep(5000);
            }

        

        [Then(@"i enter ""([^""]*)"" as email,""([^""]*)"" as contact and ""([^""]*)"" as message")]
        public void ThenIEnterAsEmailAsContactAndAsMessage(string email, string contact, string message)
        {

            Thread.Sleep(2000);
            driver.FindElement(By.Id("recipient-email")).SendKeys(email);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("recipient-name")).SendKeys(contact);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("message-text")).SendKeys(message);
            Thread.Sleep(1000);
               

        }



        [Then(@"click on send")]
        public void ThenClickOnSend()
        {
            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);

        }

        [Given(@"user is loggedin in the website")]
        public void GivenUserIsLoggedinInTheWebsite()
        {
            driver = new ChromeDriver("E:\\chromedriver.exe");
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("login2")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("loginusername")).SendKeys("atlas");
            driver.FindElement(By.Id("loginpassword")).SendKeys("atlas123");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]")).Click();
            Thread.Sleep(4000);
        }

        [When(@"i click on laptop section")]
        public void WhenIClickOnLaptopSection()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Laptops")).Click();
            Thread.Sleep(1000);
        }

        [When(@"click on Macbook Air to add it to the cart")]
        public void WhenClickOnMacbookAirToAddItToTheCart()
        {

            driver.FindElement(By.LinkText("MacBook air")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Add to cart")).Click();
            Thread.Sleep(1000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);

        }

        [Then(@"I navigate to the cart")]
        public void ThenINavigateToTheCart()
        {
            driver.FindElement(By.Id("cartur")).Click();
            Thread.Sleep(1000);

        }

        [Then(@"I verify whether the Macbook Air is present or not")]
        public void ThenIVerifyWhetherTheMacbookAirIsPresentOrNot()
        {
            IWebElement table = driver.FindElement(By.ClassName("table-responsive"));
            IList<IWebElement> product = table.FindElements(By.TagName("tr"));
            foreach (IWebElement row in product)
            {
                IList<IWebElement> columns = row.FindElements(By.TagName("td"));
                if (columns.Count >= 4 && columns[1].Text.Contains("MacBook air"))
                {
                    Console.WriteLine("product added successfully");
                }

            }
        }

    }
}
