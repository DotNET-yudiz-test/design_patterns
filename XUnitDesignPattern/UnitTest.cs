using Xunit;

namespace XUnitDesignPattern
{
    //test
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
            Assert.False(false);
        }
    }
}
