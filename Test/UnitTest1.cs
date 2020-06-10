using NUnit.Framework;
using HowTo;
using OclAspectTest;

namespace Test
{
    public class Tests
    {

        [Test]
        public void ValuesTypes()
        {
            //Checking the value of the integer variable number from class HowToUseIt
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }

        [Test]
        public void Objects()
        {
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }

        [Test]
        public void Lists()
        {
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }

        [Test]
        public void Pre()
        {
            //Condition number smaller three will be checked BEFORE method call addOne()
            var ocls = "context HowToUseIt::addOne() pre NumberLowerThree: self.number < 3";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }

        [Test]
        public void Post()
        {
            //Condition number smaller three will be checked AFTER method call addOne()
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }
        [Test]
        public void Inv()
        {
            //Inv condition is not practical / not possible at the moment
        }

        [Test]
        public void Debugger()
        {
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";
            
            //For calling the debugger the third parameter from AddConstraints(...) has to be true 
            //and UnitTest has to run in debug
            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, true, false);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }

        [Test]
        public void OwnErrorMessage()
        {
            var ocls = "context HowToUseIt::addOne() post NumberLowerThree: self.number < 3";

            //For a custom error message the fourth parameter from AddConstraints(...) has to be true 
            //and in CodeGenerator.cs the custom code has to be added into this if-condition: if (" + _customMethod + @")
            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, true);

            var program = new Program();
            Assert.IsTrue(program.countToTen());
        }
    }
}