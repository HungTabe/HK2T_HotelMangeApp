using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Payments
    {
        public int Id { get; set; }
        public int Reservation_id { get; set; }
        public int Amount { get; set; }
        public string Payment_method { get; set; }

        // Status : Prepaid = 0 ; Postpaid = 1 ; Debit = 2
        public Payment_status Payment_status { get; set; }
        public DateTime Paid_at { get; set; }
        public DateTime Updated_at { get; set; }


    }
}
