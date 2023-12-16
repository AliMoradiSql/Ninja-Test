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
    public class ErrorLoggerTests
    {
        private ErrorLogger _logger;

        [SetUp]
        public void Setup()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetLastMethodProperty()
        {
            var messeage = "Unexpected Error Happend !";
            _logger.Log(messeage);

            Assert.That(_logger.LastError, Is.EqualTo(messeage));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void ThrowExaption_InvalidValue_ThrowExaption(string error)
        {

            Assert.That(() => _logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaisedErrorLogEvent()
        {
            var id = Guid.Empty;

            _logger.ErrorLogged += (sender, args) => { id = args; };

            _logger.Log("Test For Genarate Guid");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
