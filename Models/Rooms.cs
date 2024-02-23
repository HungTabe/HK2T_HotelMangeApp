using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Rooms
    {
        public int id { get; set; }
        public int typeRoomId { get; set; }
        public string roomNumber { get; set; }
        public int floor { get; set; }
        public string? description { get; set; }

        // Status : Active = 0 , Inactive = 1
        public StatusCommon roomStatus { get; set; }
        public DateTime updated_at { get; set; }



    }
}
