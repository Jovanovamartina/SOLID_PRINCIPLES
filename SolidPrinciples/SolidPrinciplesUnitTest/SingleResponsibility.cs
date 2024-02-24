using SolidPrinciples.SingleResponsibility;

namespace SolidPrinciplesUnitTest
{
    [TestClass]
    public class SingleResponsibility
    {
        [TestMethod]
        public void MarkAsBooked()
        {
            // Arrange
            HotelRoomSolid room = new HotelRoomSolid();

            // Act
            room.MarkAsBooked();

            // Assert
            Assert.IsTrue(room.IsBooked);
        }

        [TestMethod]
        public void BookRoom_WhenRoomIsNotBooked()
        {
            // Arrange
            HotelRoomSolid room = new HotelRoomSolid();
            RoomBookingManager bookingManager = new RoomBookingManager();

            // Act
            bool result = bookingManager.BookRoom(room);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(room.IsBooked);
        }

    }
}