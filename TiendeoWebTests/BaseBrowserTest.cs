using System;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace TiendeoWebTests
{
    [TestFixture]
    public class BaseBrowserTest
    {
        private readonly Uri _seleniumHubUrl = new Uri("http://192.168.99.100:32768/wd/hub");

        protected IWebDriver Driver;
        protected static readonly Uri BaseUrl = new Uri("http://www.tiendeo.com/");

        [SetUp]
        public void Initialize()
        {
            //Driver = new FirefoxDriver();
            Driver = new RemoteWebDriver(_seleniumHubUrl, DesiredCapabilities.Chrome());

            Driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
