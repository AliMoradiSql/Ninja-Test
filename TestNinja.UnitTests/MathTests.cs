using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void Steup()
        {
            //SetUp ==> Initial Befor Runnig Tests
            _math = new Math();
            //TearDown ==> Clean Up your Test Data Fro DataBase After Running Tests Often Use For Writing Integration Test

        }

        [Test]
        [Ignore("Becuse I Want To Test Ignore Atrr :) ")]
        public void Add_WhenCalled_ReturnSumOfArgumants()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void MaxValue_WhenCalled_ReturnMaxNumber(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
