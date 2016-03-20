using System;
using NUnit.Framework;

namespace TiendeoWebTests
{
    [TestFixture]
    [Parallelizable]
    public class CityCategoryPageTests : BaseBrowserTest
    {
        [Test]
        public void CanGoToCityCategoryPage()
        {
            var city = "cornella";
            var category = "Deporte";
            var targetUrl = new Uri(BaseUrl, city + "/" + category);

            Driver.Navigate().GoToUrl(targetUrl);

            Assert.That(Driver.Url, Is.EqualTo(targetUrl));
        }
    }
}
