using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        //private FizzBuzz _FizzBuzz { get; set; }

        //[SetUp]
        //public void Setup()
        //{
        //    _FizzBuzz = new FizzBuzz();
        //}

        [Test]
        [TestCase(1,"1")]
        [TestCase(3,"Fizz")]
        [TestCase(5,"Buzz")]
        [TestCase(15,"FizzBuzz")]
        public void GetOutput_InputIsDevidableBy3And5_ShouldReturnFizzBuzz(int Number, string ExpectedValue)
        {
            var result = FizzBuzz.GetOutput(Number);
            //Assert.That(result, Is.EqualTo(ExpectedValue));
            Assert.That(result, Does.Match(ExpectedValue));
        }
    }
}
