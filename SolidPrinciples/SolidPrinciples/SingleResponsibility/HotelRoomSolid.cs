
namespace SolidPrinciples.SingleResponsibility
{
    public class HotelRoomSolid
    {
        public int RoomNumber { get; set; }
        public bool IsBooked { get; private set; }

        public void MarkAsBooked()
        {
            IsBooked = true;
        }
    }

    public class RoomBookingManager
    {
        public bool BookRoom(HotelRoomSolid room)
        {
            if (!room.IsBooked)
            {
                room.MarkAsBooked();
                return true;
            }
            return false;
        }

        public bool CheckAvailability(HotelRoom room)
        {
            return !room.IsBooked;
        }
    }

    public class InvoiceGenerator
    {
        public string GenerateInvoice(HotelRoom room)
        {
            if (room.IsBooked)
            {
                return $"Invoice for Room {room.RoomNumber}";
            }
            return string.Empty;
        }
    }
}

