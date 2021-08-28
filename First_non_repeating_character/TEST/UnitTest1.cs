using System;
using Xunit;
using First_non_repeating_character;

namespace TEST
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("a", Kata.FirstNonRepeatingLetter("a"));
            Assert.Equal("t", Kata.FirstNonRepeatingLetter("stress"));
            Assert.Equal("e", Kata.FirstNonRepeatingLetter("moonmen"));
            Assert.Equal("", Kata.FirstNonRepeatingLetter("moonmeEn"));

        }
    }
}
