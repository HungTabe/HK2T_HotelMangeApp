using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Rooms
    {
        public int id { get; set; }
        public int type_room_id { get; set; }
        public string room_number { get; set; }
        public int floor { get; set; }
        public string? description { get; set; }

        // Status : Active = 0 , Inactive = 1
        public Room_status room_status { get; set; }
        public DateTime updated_at { get; set; }



    }
}
