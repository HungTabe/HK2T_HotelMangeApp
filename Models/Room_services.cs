using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Room_services
    {
        public int Id { get; set; }
        public int Reservation_id { get; set; }
        public int Service_id { get; set; }
        public int Quantity { get; set; }

        // Status : Active = 0 ; Inactive = 1
        public Room_service_status Room_service_status { get; set; }
        public DateTime Ordered_at { get; set; }
        public DateTime Updated_at { get; set; }


    }
}
