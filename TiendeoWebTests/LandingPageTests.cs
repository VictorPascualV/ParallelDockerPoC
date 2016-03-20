using NUnit.Framework;

namespace TiendeoWebTests
{
    [TestFixture]
    [Parallelizable]
    public class LandingPageTests : BaseBrowserTest
    {
        [Test]
        public void CanGoToLandingPage()
        {
            Driver.Navigate().GoToUrl(BaseUrl);

            Assert.That(Driver.Url, Is.EqualTo(BaseUrl));
        }

    }
}
