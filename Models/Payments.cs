using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Payments
    {
        public int id { get; set; }
        public int reservation_id { get; set; }
        public int amount { get; set; }
        public string payment_method { get; set; }

        // Status : Prepaid = 0 ; Postpaid = 1 ; Debit = 2
        public Payment_status payment_status { get; set; }
        public DateTime paid_at { get; set; }
        public DateTime updated_at { get; set; }


    }
}
