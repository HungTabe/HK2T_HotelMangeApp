using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Reservations
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int room_id { get; set; }
        public DateTime checkin_at { get; set; }
        public DateTime checkout_at { get; set; }
        public DateTime updated_at { get; set; }

        // status : Open = 0 , In_progress = 1 , End = 2 , Cancel = 3
        public Reservation_status reservation_status { get; set; }







    }
}
