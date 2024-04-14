using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class TypeRooms
    {
        public int id { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public int adultCapacity { get; set; }
        public int kidsCapacity { get; set; }
        public int basePrice { get; set; }
        public int amenityId { get; set; }
        
        // Type_rooms_status : Active = 0 , Inactive = 1
        public StatusCommon typeRoomsStatus { get; set; }
        public DateTime updated_at { get; set; }
        public int imageId {  get; set; }
        // Image tồn tại 1 bảng chứa riêng
    }
}
