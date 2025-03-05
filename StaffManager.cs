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
        public List<Staff> StaffList { get;  set; }  // ✅ Ensure it's private
        public string Password { get; private set; }

        public StaffManager(int id, string name, string email, long contact, string password)
            : base(id, name, "Staff Manager", contact, email)
        {
            Password = password;
            StaffList = new List<Staff>(); // ✅ Always initialized
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
            if (FindById(staff.Id) != null)
            {
                Console.WriteLine("Error: Staff ID already exists. Choose a unique ID.");
                return;
            }

            StaffList.Add(staff);
            Console.WriteLine($"{staff.Name} ({staff.Role}) has been successfully added.");

            // ✅ Print staff count to check if it's increasing
            Console.WriteLine($"DEBUG: Total Staff Count: {StaffList.Count}");
        }


        public void RemoveStaff(int removeId)
        {
            Staff staff = FindById(removeId);
            if (staff != null)
            {
                StaffList.Remove(staff);
                Console.WriteLine($"{staff.Name} ({staff.Role}) has been removed.");
            }
            else
            {
                Console.WriteLine("No staff member found by this ID.");
            }
        }

        public List<Staff> GetStaffList()
        {
            return StaffList;
        }

        public void ShowAllStaff()
        {
            if (StaffList.Count == 0)
            {
                Console.WriteLine("No staff members available.");
                return;
            }

            Console.WriteLine("\n=== Staff Members ===");
            foreach (var staff in StaffList)
            {
                Console.WriteLine($"[ID: {staff.Id}] {staff.Name} - {staff.Role}");
            }
            Console.WriteLine("=====================");
        }

        public Staff FindById(int id)
        {

            foreach (Staff staff in StaffList)
            {
                Console.WriteLine($"DEBUG: Checking Staff ID: {staff.Id}");
                if (staff.Id == id)
                {
                    Console.WriteLine("DEBUG: Staff Found!");
                    return staff;
                }
            }
            return null;
        }

    }

}
