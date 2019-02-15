using System;
using console;
using Xunit;

namespace test
{
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