using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Reservations
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public int Room_id { get; set; }
        public DateTime Checkin_at { get; set; }
        public DateTime Checkout_at { get; set; }
        public DateTime Updated_at { get; set; }

        // status : Open = 0 , In_progress = 1 , End = 2 , Cancel = 3
        public Reservation_status Reservation_status { get; set; }







    }
}
