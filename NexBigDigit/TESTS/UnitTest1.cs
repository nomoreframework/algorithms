using System;
using Xunit;
using NexBigDigit;

namespace TESTS
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(21, Program.NextBiggerNumber(12));
            Assert.Equal(531, Program.NextBiggerNumber(513));
            Assert.Equal(2071,Program.NextBiggerNumber(2017));
            Assert.Equal(441, Program.NextBiggerNumber(414));
            Assert.Equal(414, Program.NextBiggerNumber(144));
            Assert.Equal(2145, Program.NextBiggerNumber(1542));
        }
    }
}
