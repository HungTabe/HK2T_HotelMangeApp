using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Users
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string city { get; set; }
        public string district { get; set; }    
        public string? ward { get; set; }
        public string address { get; set; }
        public string CardID { get; set; }
        public string phone { get; set; }
        public string? email { get; set; }
        public DateTime  birthDay { get; set; }
        public string gender { get; set; }

        // Position : Customer = 1, Admin = 2, Housekeeper = 3, Receptionist = 4
        public Position position { get; set; }

        public decimal? salary { get; set; }

        // Có 1 table riêng cho User Image
        public string image { get; set; }

        public string password { get; set; }

      




    }
}
