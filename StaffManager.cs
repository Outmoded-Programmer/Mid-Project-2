using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class StaffManager : Staff
    {
        public List<Staff> StaffList { get; set; }
        public string Password { get; set; }
        public StaffManager(int id, string name, string email, long contact , string password) : base(id, name, "Staff Manager", contact, email)
        {
            Password = password;
            StaffList = new List<Staff>();
        }
        public override string ShowDetails()
        {
            return $"{Role}: \n Id: {Id} \n Name: {Name} \n Email: {Email} \n Contact: {Contact} \n";
        }

        public override void ShowDuties()
        {
            Console.WriteLine($"{Name} (Staff Manager) - Responsible for Assigning and Hiring Staff.");
        }

        public void AddStaff(Staff staff)
        {
            Console.Write("Enter staff member id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (FindById(id) != null)
            {
                Console.WriteLine("Member with this ID already exists.");
                return;
            }
            StaffList.Add(staff);
            Console.WriteLine($" {staff.Name}: {staff.Role} has been hired");
        }
        public void RemoveStaff(int removeId)
        {
            Console.WriteLine("Enter id to of the staff member to be removed");
            int id = Convert.ToInt32(Console.ReadLine());
            Staff staff = FindById(id);
            if (staff != null)
            {
                Console.WriteLine($"{staff.Name} ({staff.Role}) has been removed.");
            }
            else
            {
                Console.WriteLine("No staff member found by this id");
            }
        }

        public void UpdateStaffInfo()
        {
            Console.WriteLine($"Enter Staff id to update info");
            int id = Convert.ToInt32(Console.ReadLine());
            Staff staff = FindById(id);
            if (staff != null)
            {
                Console.Write("Enter new Staff member name:");
                string name = Console.ReadLine();
                staff.Name = name;
                Console.Write("Enter new Staff member name:");
                string role = Console.ReadLine();
                staff.Role = role;
                Console.Write("Enter new Staff member name:");
                long contact = Convert.ToInt64(Console.ReadLine());
                staff.Contact = contact;
                Console.Write("Enter new Staff member name:");
                string email = Console.ReadLine();
                staff.Email = email;
            }
            else
            {
                Console.WriteLine("No staff member found by this id");
            }
        }
        public void ShowAllStaff()
        {
            Console.WriteLine("\n List of Staff Members");
            foreach(var staff in StaffList)
            {
                staff.ShowDuties();
            }
        }
        public Staff FindById(int id)
        {
            foreach (Staff staff in StaffList)
            {
                if (staff.Id == id)
                {
                    return staff;
                }
            }
            return null;
        }

    }
}
