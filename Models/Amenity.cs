using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Amenity
    {
        public int id { get; set; }
        public string name { get; set; }

        // Amenity_status : Active = 0 ; Inactive = 1
        public StatusCommon amenity_status { get; set; }
    }
}
