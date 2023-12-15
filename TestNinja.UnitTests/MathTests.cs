using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        [Ignore("Becuse I Want To Test Ignore Atrr :) ")] // Ignore Test With A Message
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

        [Test]
        public void GetOddNumber_LimitIsGraderThanZero_ReturnOddNumberUptoLimit()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.Not.Empty);

            // Not Good Idea
            //Assert.That(result, Does.Contain(1));
            //Assert.That(result, Does.Contain(3));
            //Assert.That(result, Does.Contain(5));

            // makes Sure that array is exactly like {1,3,5},
            //Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Useful
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);

            //Better than befor
            Assert.That(result.Any(x => x % 2 == 1), Is.True);

        }
    }
}