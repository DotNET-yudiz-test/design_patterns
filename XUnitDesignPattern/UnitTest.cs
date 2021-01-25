using Xunit;

namespace XUnitDesignPattern
{
    public class UnitTest
    {
        //test 123
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
