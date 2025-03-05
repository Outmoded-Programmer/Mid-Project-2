using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Mid_Project_2
{
    class AdminPanel
    {
        private List<Student> students;
        private Admin admin;

        public AdminPanel(List<Student> students)
        {
            this.students = students;
            admin = new Admin(1, "Taha", 03259881310, "taha@gmail.com", "admin123");
            admin.students = this.students;
        }

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
                Console.WriteLine("\nChoose Action: \n1. Add Student \n2. Remove Student \n3. Update Student \n4. View Students \n5. View Rooms \n6. View Complaints \n7. Exit Admin Panel");
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
                        Console.Write("\nEnter ID of the student to update: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Enter New Contact: ");
                        long contact = Convert.ToInt64(Console.ReadLine());
                        admin.UpdateStudent(id, contact, email);
                        Console.WriteLine($"Student: \n ID:{id} \n updated email:  {email} updated Contact: {contact}");

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