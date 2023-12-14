using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User{ IsAdmin = true });

            //Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingReservation_ReturnsTrue()
        {
            var User = new User();
            var reservation = new Reservation { MadeBy = User};

            var result = reservation.CanBeCancelledBy(User); 
            
            Assert.IsTrue(result);

        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingReservation_RetuensFalse()
        {
            var reservation = new Reservation { MadeBy = new User()};

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);

        }
    }
}
