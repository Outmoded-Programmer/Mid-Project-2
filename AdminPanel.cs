using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class AdminPanel
    {
        Admin admin = new Admin(1, "Taha", 03259881310, "taha@gmail.com", "admin123");
        public void Panel(string password)
        {
            if (admin.Password != password)
            {
                Console.WriteLine("Invalid Password");
                return;
            }

            Console.WriteLine(admin.ShowDetails());

            while (true)
            {
                Console.WriteLine("\nChoose Action: \n 1. Add Student \n 2. Remove Student \n 3. Update Student \n 4. View Students \n 5. View Rooms \n 6. View Complaints \n 7. Exit Admin Panel");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        admin.AddStudent();
                        break;
                    case 2:
                        admin.RemoveStudent();
                        break;
                    case 3:
                        Console.Write("\n Enter id of the student to update: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n Enter New Email:");
                        string email = Console.ReadLine();
                        Console.Write("Enter New Contact:");
                        long contact = Convert.ToInt64(Console.ReadLine());
                        admin.UpdateStudent(id, contact , email);
                        break;
                    case 4:
                        admin.DisplayStudent();
                        break;
                    case 5:
                        admin.DisplayRooms();
                        break;
                    case 6:
                        admin.ViewComplaints();
                        break;
                    case 7:
                        Console.WriteLine("Exiting Admin Panel...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
