using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserAdmin_ReturnsTrue()
        {
            //Arrage
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            //Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancellingTheReservation_ReturnsTrue()
        {
            //Arrage
            var user = new User();
            var reservation = new Reservation { MadeBy  = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancellingTheReservation_ReturnsFalse()
        {

            var reservation = new Reservation { MadeBy = new User() };

            var result = reservation.CanBeCancelledBy(new User());

            Assert.IsFalse(result);


        }

    }
}
