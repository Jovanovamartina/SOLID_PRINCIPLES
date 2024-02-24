
namespace SolidPrinciples.SingleResponsibility
{
    public class HotelRoomSolid
    {
        public int RoomNumber { get; set; }
        public bool IsBooked { get; set; }

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

        public bool CheckAvailability(HotelRoomSolid room)
        {
            return !room.IsBooked;
        }
    }

    public class InvoiceGenerator
    {
        public string GenerateInvoice(HotelRoomSolid room)
        {
            if (room.IsBooked)
            {
                return $"Invoice for Room {room.RoomNumber}";
            }
            return string.Empty;
        }
    }
}

