
namespace SolidPrinciples.SingleResponsibility
{
        public class HotelRoom
        {
            public int RoomNumber { get; set; }
            public bool IsBooked { get; private set; }

            public void BookRoom()
            {
                if (!IsBooked)
                {
                    IsBooked = true;
                }
            }

            public bool CheckAvailability()
            {
                return !IsBooked;
            }

            public string GenerateInvoice()
            {
                if (IsBooked)
                {
                    return $"Invoice for Room {RoomNumber}";
                }
                return string.Empty;
            }
        }
    }

