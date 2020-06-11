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
            //Checking if the value of an variable from an object is greater 40
            var ocls = "context ResearchProject::amountStudents() pre responsibleProf: self.Responsible.Age <= 40";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            program.addStudentsToProject();
            Assert.IsTrue(program.singleObjectTest());
        }

        [Test]
        public void Lists()
        {
            //Checking if there is an object in a list of objects thats age is greater than 20
            var ocls = "context ResearchProject::amountStudents() pre OlderThan20: self.Students->exists(s | s.Age > 20)";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);
            
            var program = new Program();
            program.addStudentsToProject();
            Assert.IsTrue(program.singleObjectTest());
        }

        [Test]
        public void Lists2()
        {
            //Checking each student is older than 10
            var ocls = "context ResearchProject::amountStudents() pre OlderThan10: self.Students->forAll(s | s.Age > 10)";

            OclTestProvider.AddConstraints(new[] { "HowTo" }, ocls, false, false);

            var program = new Program();
            program.addStudentsToProject();
            Assert.IsTrue(program.singleObjectTest());
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
            //Kind of workaround would be to write an OCL for each method and check the 
            //value of the variable even if the variable is not used.
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