using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class CleaningStaff : Staff , IStaffDuties
    {
        public CleaningStaff(int id, string name , string email, long contact) : base(id, name, "CLeaning Staff", contact, email)
        {
        }
        public override string ShowDetails()
        {
            return $"{Role}: \n Id: {Id} \n Name: {Name} \n Email: {Email} \n Contact: {Contact} \n";
        }
        public override void ShowDuties()
        {
            Console.WriteLine($"{Name} (Cleaning Staff) - Responsible for cleaning rooms and common areas.");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is cleaning the hostel rooms.");
        }
    }
}
