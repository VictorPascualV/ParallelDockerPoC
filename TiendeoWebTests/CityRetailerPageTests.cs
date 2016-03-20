using System;
using NUnit.Framework;

namespace TiendeoWebTests
{
    [TestFixture]
    [Parallelizable]
    public class CityRetailerPageTests : BaseBrowserTest
    {
        [Test]
        public void CanGoToCityRetailerPage()
        {
            var city = "Sabadell";
            var retailer = "carrefour";
            var targetUrl = new Uri(BaseUrl, city + "/" + retailer);

            Driver.Navigate().GoToUrl(targetUrl);

            Assert.That(Driver.Url, Is.EqualTo(targetUrl));
        }
    }
}