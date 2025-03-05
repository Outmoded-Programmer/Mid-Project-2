using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class StaffManagerPanel
    {
        private StaffManager staffManager;  

        public StaffManagerPanel(StaffManager manager)
        {
            this.staffManager = manager;
        }

        public void ManageStaff(string staffPassword)
        {
            if (staffManager.Password != staffPassword)
            {
                Console.WriteLine("Invalid Password.");
                return;
            }

            Console.WriteLine(staffManager.ShowDetails());

            while (true)
            {
                Console.WriteLine("\nStaff Manager Panel:");
                Console.WriteLine("1. Add Staff");
                Console.WriteLine("2. Remove Staff");
                Console.WriteLine("3. View Staff");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Staff ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        

                        if (staffManager.FindById(id) != null)
                        {
                            Console.WriteLine("Error: Staff ID already exists. Choose a unique ID.");
                            break;
                        }

                        Console.Write("Enter Staff Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter staff email: ");
                        string email = Console.ReadLine();
                        Console.Write("Enter contact info: ");
                        long contact = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Choose Role: 1. Cleaning 2. Maintenance 3. Security");
                        int roleChoice = Convert.ToInt32(Console.ReadLine());
                        Staff newStaff = null;

                        switch (roleChoice)
                        {
                            case 1:
                                newStaff = new CleaningStaff(id, name, email, contact);
                                break;
                            case 2:
                                newStaff = new MaintenanceStaff(id, name, email, contact);
                                break;
                            case 3:
                                newStaff = new SecurityStaff(id, name, email, contact);
                                break;
                            default:
                                Console.WriteLine("Invalid role selection.");
                                break;
                        }

                        if (newStaff != null)
                        {
                            staffManager.AddStaff(newStaff);  
                        }
                        break;

                    case 2:
                        Console.Write("Enter Staff ID to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        staffManager.RemoveStaff(removeId);
                        break;

                    case 3:
                        staffManager.ShowAllStaff(); 
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
