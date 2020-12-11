using Xunit;

namespace XUnitDesignPattern
{
    //test 123
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
