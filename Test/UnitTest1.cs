using NUnit.Framework;
using HowTo;
using OclAspectTest;

namespace Test
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }
    }
}