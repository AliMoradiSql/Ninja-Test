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
    public class DemeritPointsTests
    {
        private DemeritPointsCalculator _demeritPointsCalculator;

        [SetUp]
        public void Setup()
        {
            _demeritPointsCalculator = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66,0)]
        [TestCase(70,1)]
        [TestCase(75,2)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int Speed,int expectedValue)
        {
            var result = _demeritPointsCalculator.CalculateDemeritPoints(65);

            Assert.That(result, Is.Zero);
        }

        [Test]
        public void CalculateDemeritPoints_WhenSpeedIsLesssThanZero_ThrowExeption()
        {
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(-1), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        } 
        
        [Test]
        public void CalculateDemeritPoints_WhenSpeedIsnotInLimtOfMaxSpeed_ThrowExeption()
        {
            Assert.That(() => _demeritPointsCalculator.CalculateDemeritPoints(301), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
