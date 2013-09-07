using NUnit.Framework;

namespace Inflector.Tests
{
    [TestFixture]
    public class HumanizeTests : InflectorTestBase
    {
        [Test]
        [TestCase("some_title", "Some title")]
        [TestCase("some-title", "Some-title")]
        [TestCase("Some_title", "Some title")]
        [TestCase("someTitle", "Sometitle")]
        [TestCase("someTitle_Another", "Sometitle another")]
        [TestCase("HistoricalUsageData", "Historical Usage Data")]
        [TestCase("LBMPZone", "LBMP Zone")]
        [TestCase("LBMP", "LBMP")]
        [TestCase("Historical", "Historical")]
        [TestCase("Bill2StartDate", "Bill 2 Start Date")]
        [TestCase("Bill234StartDate", "Bill 234 Start Date")]
        [TestCase("FifteenThousandsKWHOrLessAnnually", "Fifteen Thousands KWH Or Less Annually")]
        [TestCase("_7x24", "7x24")]
        public void Humanize(string input, string expectedResult)
        {
            Assert.That(input.Humanize(), Is.EqualTo(expectedResult));
        }
    }
}