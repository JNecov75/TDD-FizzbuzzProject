using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        FizzBuzzService _fizzBuzz;
        [TestInitialize]
        public void Init() 
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [TestMethod]
        public void shouldPrintNumberWhenNumberIsEntered() 
        {
            Assert.AreEqual("2", _fizzBuzz.Print(2));
        }

        [TestMethod]
        public void shouldPrintFizz() 
        {
            Assert.AreEqual("fizz", _fizzBuzz.Print(3));
            Assert.AreEqual("fizz", _fizzBuzz.Print(6));
        }
    }
}
