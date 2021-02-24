using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ubsAuto
{
    [Binding]
    public sealed class ubssteps
    {
        public IWebDriver Driver;
        public ubssteps()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        private readonly ScenarioContext _scenarioContext;

        [Given(@"I open the browser")]
        public void GivenIOpenTheBrowser()
        {
            
            Console.WriteLine("Global instance it created..");
        }

        [When(@"I navigate to URL")]
        public void WhenINavigateToURL()
        {
            
            Driver.Navigate().GoToUrl("https://www.ubs.com");
        }

        [Given(@"I navigate to URL")]
        public void GivenINavigateToURL()
        {
            
            Driver.Navigate().GoToUrl("https://www.ubs.com");
        }


        [Then(@"I can see Page title")]
        public void ThenICanSeePageTitle()
        {
            String pageTitle = Driver.Title;
            Console.WriteLine("Page Title: "+pageTitle);
            Assert.IsTrue(pageTitle.Contains("Our financial services in your location"));
            Driver.Close();
        }

        [When(@"I Navigate to What we offer page")]
        public void WhenINavigateToWhatWeOfferPage()
        {
            Driver.FindElement(By.XPath("//*[@id='mainmenu']/li[1]/button")).Click();
            Task.Delay(5000).Wait();
            Driver.FindElement(By.XPath("//*[@id='mainmenu-navContent0']/li[1]/span/a")).Click();
            Task.Delay(5000).Wait();
        }

        [Then(@"I can see valid offer links")]
        public void ThenICanSeeValidOfferLinks()
        {
            IList<IWebElement> HeadingList = Driver.FindElements(By.XPath("//h2/span"));
            IList<String> HListInString =  Utility.ListIWebToString(HeadingList);
            foreach(String s in HListInString)
            {
                Console.WriteLine(s);
            }
            Assert.IsTrue(HListInString.Contains("Access"));
            Assert.IsTrue(HListInString.Contains("Bespoke financing"));
            Assert.IsTrue(HListInString.Contains("Debt and equity capital markets"));
            Driver.Close();
        }

        [When(@"I Navigate to About US page")]
        public void WhenINavigateToAboutUSPage()
        {
            Driver.FindElement(By.XPath("//*[@id='mainnavigation']/div/div[1]/div/div/ul/li[2]/a")).Click();
        }

        [Then(@"I can see About US page as landing page")]
        public void ThenICanSeeAboutUSPageAsLandingPage()
        {
            String heading = Driver.FindElement(By.XPath("//*[@id='main']/header/div/div/div/div/h1")).Text.ToString();
            Assert.IsTrue(heading.Contains("Our business"));
            Driver.Close();
        }


        [When(@"I Navigate to Focus page")]
        public void WhenINavigateToFocusPage()
        {
            Driver.FindElement(By.XPath("//*[@id='mainnavigation']/div/div[1]/div/div/ul/li[3]/a")).Click();
            
        }

        [Then(@"I can see Focus Submenu")]
        public void ThenICanSeeFocusSubmenu()
        {
            IList<IWebElement> HeadingList = Driver.FindElements(By.XPath("//*[@id='mainnavigation']/div/div[3]/div/ul/li[*]/a"));
            IList<String> HListInString = Utility.ListIWebToString(HeadingList);
            foreach (String s in HListInString)
            {
                Console.WriteLine(s);
            }
            Assert.IsTrue(HListInString.Contains("Future World"));
            Assert.IsTrue(HListInString.Contains("ESG & Sustainability"));
            Driver.Close();

        }

        [When(@"I Navigate to Regulatory Directory")]
        public void WhenINavigateToRegulatoryDirectory()
        {
            Driver.FindElement(By.XPath("//*[@id='mainnavigation']/div/div[1]/div/div/ul/li[4]/a")).Click();
            
        }


        [Then(@"I can see Regulatory Directory")]
        public void ThenICanSeeRegulatoryDirectory()
        {
            String heading = Driver.FindElement(By.XPath("//*[@id='main']/header/div/div/div/div/h1")).Text.ToString();
            Assert.IsTrue(heading.Contains("Regulatory Directory"));
            Driver.Close();
        }



    }
}
