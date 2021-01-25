using Xunit;

namespace XUnitDesignPattern
{
    public class UnitTest
    {
        //test 123890
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
