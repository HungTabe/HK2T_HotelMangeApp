using HK2TProject_HotelManage_Server.Data.Enum;

namespace HK2TProject_HotelManage_Server.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string District { get; set; }    
        public string? Ward { get; set; }
        public string Address { get; set; }
        public string ID_card { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public DateOnly Birth_day { get; set; }
        public string Gender { get; set; }

        // Position : Customer = 1, Admin = 2, Housekeeper = 3, Receptionist = 4
        public Position Position { get; set; }

        public decimal? Salary { get; set; }

        // Có 1 table riêng cho User Image
        public string Image { get; set; }

        public int? Hours_worked {  get; set; }

        public decimal? Hours_Rate { get; set; }

        public decimal CalculateSalary(int Hours_worked, decimal Hours_Rate)
        {
            // Tính lương bằng cách nhân số giờ làm việc với phí 1 giờ
            decimal Salary = Hours_worked * Hours_Rate;
            return Salary;
        }



    }
}
