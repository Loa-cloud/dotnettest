using Xunit;
using System;

namespace TestOne
{
    public class Test : IDisposable
    {

        public Test()
        {
        }

        public void Dispose()
        {
        }

        [Fact]
        public void Test1()
        {
            int a = 1;
            int b = 1;
            Assert.Equal(a, b);
        }
    }
}
