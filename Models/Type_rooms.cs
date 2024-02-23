using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Type_rooms
    {
        public int id { get; set; }
        public string title { get; set; }
        public int type { get; set; }
        public int adult_capacity { get; set; }
        public int kids_capacity { get; set; }
        public int base_price { get; set; }
        public int amenity_id { get; set; }

        // Type_rooms_status : Active = 0 , Inactive = 1
        public StatusCommon type_rooms_status { get; set; }
        public DateTime updated_at { get; set; }
        public int image_id {  get; set; }
        // Image tồn tại 1 bảng chứa riêng
    }
}
