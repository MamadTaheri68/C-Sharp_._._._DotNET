using Xunit;

namespace OnlinesShop.Test.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Should_Return_True()
        {
            var testString = "mamdad";

            bool result = (testString == "mamdad");

            Assert.True(result);
        }

        [Fact]
        public void Should_Return_False()
        {
            var testString = "mamdad";

            bool result = (testString == "mmm");

            Assert.False(result);
        }

    }
}