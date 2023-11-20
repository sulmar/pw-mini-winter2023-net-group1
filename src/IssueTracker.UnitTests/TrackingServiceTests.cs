using Domain.Model;
using Infrastructure;

namespace IssueTracker.UnitTests
{
    [TestClass]
    public class TrackingServiceTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetLocation_EmptyFile_ShouldThrowException()
        {
            // Arrange
            IFileReader fileReader = new FakeEmptyFileReader();
            TrackingService service = new TrackingService(fileReader);

            // Act
            service.GetLocation();

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void GetLocation_InvalidFile_ShouldThrowException()
        {
            // Arrange
            IFileReader fileReader = new FakeInvalidFileReader();
            TrackingService service = new TrackingService(fileReader);

            // Act
            service.GetLocation();

            // Assert
        }

        [TestMethod]
        public void GetLocation_ValidFile_ReturnsLocation()
        {
            // Arrange
            IFileReader fileReader = new FakeValidFileReader();
            TrackingService service = new TrackingService(fileReader);

            // Act
            Location location = service.GetLocation();

            // Assert
            Assert.AreEqual(21.01, location.Latitude);
            Assert.AreEqual(51.01, location.Longitude);
        }
    }
}