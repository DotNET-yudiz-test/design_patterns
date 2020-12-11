using Xunit;

namespace XUnitDesignPattern
{
    public class UnitTest
    {
        [Fact]
        public void SuccessTest()
        {
            Assert.False(false);
        }

        [Fact]
        public void FailTest()
        {
            Assert.False(true);
        }
    }
}
