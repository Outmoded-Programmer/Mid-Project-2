﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            AdminPanel adminPanel = new AdminPanel(students);
            StaffManager staffManager = new StaffManager(1, "Ali", "shahzad@gmail.com", 03340002348, "manager123");
            StaffManagerPanel staffManagerPanel = new StaffManagerPanel(staffManager);
            StaffPanel staffPanel = new StaffPanel(staffManager.GetStaffList()); 
            StudentPanel studentPanel = new StudentPanel(students);
            Console.WriteLine("");
            Console.WriteLine(" Hostel Management System: ");
            while (true)
            {

                Console.WriteLine(" Enter your choice: \n \n 1. Admin \n 2. Student \n 3. Staff Manager \n 4. Staff Panel \n 5. Exit");

                int roleChoice = Convert.ToInt32(Console.ReadLine());

                switch (roleChoice)
                {
                    case 1:
                        Console.Write("Enter password for admin panel: ");
                        string adminPassword = Console.ReadLine();
                        adminPanel.Panel(adminPassword);
                        break;
                    case 2:
                        studentPanel.Panel();
                        break;
                    case 3:
                        Console.Write("Enter password for staff manager panel: ");
                        string staffPassword = Console.ReadLine();
                        staffManagerPanel.ManageStaff(staffPassword);
                        break;
                    case 4:
                        staffPanel.AccessPanel();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        Console.WriteLine();
                        Console.WriteLine("Exited successfully.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
