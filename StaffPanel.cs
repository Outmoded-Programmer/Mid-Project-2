using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class StaffPanel
    {
        private List<Staff> staffMembers;

        public StaffPanel(List<Staff> staffMembers)
        {
            this.staffMembers = staffMembers;
        }

        public void AccessPanel()
        {
            Console.Write("Enter Staff ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Staff foundStaff = null;

            foreach (Staff staff in staffMembers)
            {
                if (staff.Id == id)
                {
                    foundStaff = staff;
                    break;
                }
            }

            if (foundStaff == null)
            {
                Console.WriteLine("Staff member not found.");
                return;
            }

            Console.WriteLine($"Welcome {foundStaff.Name}, your role: {foundStaff.Role}");
            foundStaff.ShowDuties();

            if (foundStaff is IStaffDuties staffActions)
            {
                staffActions.PerformDuties();
            }
        }
    }
}