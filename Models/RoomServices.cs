using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class RoomServices
    {
        public int id { get; set; }
        public int reservationId { get; set; }
        public int serviceId { get; set; }
        public int quantity { get; set; }

        // Status : Active = 0 ; Inactive = 1
        public StatusCommon roomServiceStatus { get; set; }
        public DateTime ordered_at { get; set; }
        public DateTime updated_at { get; set; }


    }
}
