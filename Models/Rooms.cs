using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public int Type_room_id { get; set; }
        public string Room_number { get; set; }
        public int Floor { get; set; }
        public string? Description { get; set; }

        // Status : Active = 0 , Inactive = 1
        public Room_status Room_status { get; set; }
        public DateTime Updated_at { get; set; }



    }
}
