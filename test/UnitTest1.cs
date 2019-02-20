using System;
using console;
using Xunit;

namespace test
{
    public int x = 1;
    public class UnitTest1
    {
        [Fact]
        public void Test1()

        {
            var aInstance = new A();
            Assert.Equal(1, aInstance.a);
        }
    }
}