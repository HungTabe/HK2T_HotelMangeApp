using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Amenity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Amenity_status : Active = 0 ; Inactive = 1
        public Amenity_status Amenity_status { get; set; }
    }
}
