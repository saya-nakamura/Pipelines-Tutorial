using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CosoleAppTest
{
    [TestClass]
    public class UnitTest1
    {
        ConsoleApp.ICalc Calc;
        [TestInitialize]
        public void TestInitialize()
        {
            Calc = new ConsoleApp.Calc();
        }
        [TestMethod]
        public void TestMethodAdd()
        {
            
            int result = Calc.Add(3, 5);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestMethodSubstract()
        {
            int result = Calc.Substract(3, 5);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestMethodMulti()
        {
            int result = Calc.Multiplication(3, 5);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestMethodDivision()
        {
            int result = Calc.Division(3, 5);
            Assert.AreEqual(0, result);
        }
    }
}
