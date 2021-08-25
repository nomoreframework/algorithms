using System;
using Xunit;
using Scramblies;

namespace TESTS
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Scramblie.Scramble("rkqodlw", "world"));
            Assert.False(Scramblie.Scramble("katas", "steak"));
            Assert.False(Scramblie.Scramble("scriptjavx", "javascript"));
            Assert.True(Scramblie.Scramble("scriptingjava", "javascript"));
            Assert.True(Scramblie.Scramble("scriptsjava", "javascripts"));
            Assert.False(Scramblie.Scramble("javscripts", "javascript"));
            Assert.True(Scramblie.Scramble("aabbcamaomsccdd", "commas"));
            Assert.True(Scramblie.Scramble("sammoc", "commas"));
            Assert.True(Scramblie.Scramble("cedewaraaossoqqyt", "codewars"));
        }
    }
}
