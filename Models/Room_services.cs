using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Room_services
    {
        public int id { get; set; }
        public int reservation_id { get; set; }
        public int service_id { get; set; }
        public int quantity { get; set; }

        // Status : Active = 0 ; Inactive = 1
        public Room_service_status room_service_status { get; set; }
        public DateTime ordered_at { get; set; }
        public DateTime updated_at { get; set; }


    }
}
