using Mid_Project_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class SecurityStaff : Staff , IStaffDuties
    {
        public SecurityStaff(int id, string name , string email,long contact) : base(id, name, "Security Staff", contact, email)
        {
        }
        public override string ShowDetails()
        {
            return $"{Role}: \n Id: {Id} \n Name: {Name} \n Email: {Email} \n Contact: {Contact} \n";
        }

        public override void ShowDuties()
        {
            Console.WriteLine($"{Name} (Security Staff) - Responsible for hostel security.");
        }
        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is ensuring hostel security and monitoring entrances.");
        }

    }
}
