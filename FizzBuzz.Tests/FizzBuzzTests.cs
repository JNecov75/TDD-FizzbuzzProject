using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void shouldPrintNumberWhenNumberIsEntered() 
        {
            FizzBuzzService _fizzBuzz = new FizzBuzzService();
            Assert.AreEqual("2", _fizzBuzz.Print(2));
        }

        [TestMethod]
        public void shouldPrintFizz() 
        {
            FizzBuzzService _fizzBuzz = new FizzBuzzService();
            Assert.AreEqual("fizz", _fizzBuzz.Print(3));
            Assert.AreEqual("fizz", _fizzBuzz.Print(6));
        }
    }
}
