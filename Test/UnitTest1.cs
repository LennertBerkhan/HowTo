using NUnit.Framework;
using OclAspectTest;
using HowTo;

namespace Test
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            string ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            //Attach OCLs to program (Bool para 1. debugger 2. custom methode)
            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }
    }
}