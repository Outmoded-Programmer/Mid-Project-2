using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class MaintenanceStaff : Staff, IStaffDuties
    {
        public MaintenanceStaff(int id, string name, string email, long contact) : base(id, name, "Maintenance Staff ", contact, email) { }
        public override void ShowDuties()
        {
            Console.WriteLine($"{Name} (Maintenance staff): \n Responsible for Maintenance and Repair");
        }
        public override string ShowDetails()
        {
            return $"{Role}: \n Id: {Id} \n Name: {Name} \n Email: {Email} \n Contact: {Contact} \n";
        }
        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is fixing hostels Maintenance issues");
        }
    }
}
