using Domain.Model;

namespace IssueTracker.UnitTests
{
    [TestClass]
    public class RentTests
    { 


        //[TestMethod]
        //public void Method_Scenario_ExpectedBehavior()
        //{
        //    throw new NotImplementedException();
        //}


        // Scenario #1
        [TestMethod]
        public void CanReturn_UserIsAdmin_ReturnsTrue()
        {
            // Arrange
            var rent = new Rent();

            // Act
            var result = rent.CanReturn(new User { IsAdmin = true });

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanReturn_UserIsNotAdminOrRentee_ReturnsFalse()
        {
            // Arrange
            var user = new User();
            var rent = new Rent() {  Rentee = user };
            
            // Act
            var result = rent.CanReturn(new User());

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CanReturn_UserIsRentee_ReturnsTrue()
        {
            // Arrange
            var rentee = new User();
            var rent = new Rent() { Rentee = rentee };

            // Act
            var result = rent.CanReturn(rentee);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CanReturn_UserIsEmpty_ShouldArgumentNullException()
        {
            // Arrange
            var rent = new Rent();

            // Act
            rent.CanReturn(null);
        }


    }
}