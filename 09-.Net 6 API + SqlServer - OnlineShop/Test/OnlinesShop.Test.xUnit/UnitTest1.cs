using Xunit;

namespace OnlinesShop.Test.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var testString = "mamdad";

            bool result = (testString == "mamdad");

            Assert.True(result);
        }

    }
}