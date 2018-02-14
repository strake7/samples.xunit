using Xunit;

namespace TestOutputExample
{
    /// <summary>
    /// Demo one instance per test. Count is always 1 though incremented at the end of each test
    /// </summary>
    public class InstanceExample
    {
        private int count = 0;

        public InstanceExample()
        {
            count = 1;
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(1, count);
            count++;
        }
        
        [Fact]
        public void Test2()
        {
            Assert.NotEqual(2, count);
            count++;
        }
        
        [Fact]
        public void Add2_Is4()
        {
            Assert.Equal(4, 2+2);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsOdd(int value)
        {
            Assert.False(value%2 == 0);
        }
    }
}