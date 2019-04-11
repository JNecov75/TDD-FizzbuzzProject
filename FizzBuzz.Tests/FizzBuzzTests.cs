using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void whenANumberIsEnteredItShouldBePrinted() 
        {
            FizzBuzzService _fizzBuzz = new FizzBuzzService();
            Assert.AreEqual("1", _fizzBuzz.Print(1));
        }
    }
}
