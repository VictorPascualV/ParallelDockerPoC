using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TiendeoWebTests
{
    [TestFixture]
    public class BaseBrowserTest
    {
        protected IWebDriver Driver;
        protected static readonly Uri BaseUrl = new Uri("http://www.tiendeo.com/");
        
        [SetUp]
        public void Initialize()
        {
            //Driver = new FirefoxDriver();
            Driver = new RemoteWebDriver(GridSetup.SeleniumHubUrl, DesiredCapabilities.Chrome());
            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
