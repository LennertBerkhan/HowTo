using NUnit.Framework;
using HowTo;

namespace Test
{
    public class Tests
    {

        [Test]
        public void Test1()
        {     
            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }
    }
}