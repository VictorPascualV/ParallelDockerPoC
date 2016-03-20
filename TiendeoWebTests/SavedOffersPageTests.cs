using NUnit.Framework;
using OpenQA.Selenium;

namespace TiendeoWebTests
{
    [TestFixture]
    [Parallelizable]
    public class SavedOffersPageTests : BaseBrowserTest
    {
        [Test]
        public void CanGoToSavedOffersPage()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
            var savedOffersButton = Driver.FindElement(By.Id("headerTiendeo_BuscadorControl1_favorites"));

            savedOffersButton.Click();

            Assert.That(Driver.Url, Is.EqualTo(BaseUrl + "paginas_guardadas.aspx"));
        }
    }
}
