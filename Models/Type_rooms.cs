using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Type_rooms
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public int Adult_capacity { get; set; }
        public int Kids_capacity { get; set; }
        public int Base_price { get; set; }
        public int Amenity_id { get; set; }

        // Type_rooms_status : Active = 0 , Inactive = 1
        public Type_rooms_status Type_rooms_status { get; set; }
        public DateTime Updated_at { get; set; }
        public int Image_id {  get; set; }
        // Image tồn tại 1 bảng chứa riêng
    }
}
