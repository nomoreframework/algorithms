using System;
using Xunit;
using Simple_Pig_Latin;

namespace TEST
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("igPay atinlay siay oolcay",Program.PigIt("Pig latin is cool"));
            Assert.Equal("hisTay siay ymay tringsay", Program.PigIt("This is my string"));
        }
    }
}
