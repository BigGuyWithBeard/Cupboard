using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cupboard.Asda.Tests
{
    [TestClass]
    public class UnitScraper
    {
        [TestMethod]
        public void UnitScraper_TestMe()
        {
            var asda = new Cupboard.Asda.Scraper();
            var content = asda.TestMe().Result;

            Assert.Inconclusive();
        }
    }
}
