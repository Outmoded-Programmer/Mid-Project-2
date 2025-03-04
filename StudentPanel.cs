using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class StudentPanel
    {

        private List<Student> students;

        public StudentPanel(List<Student> students)
        {
            this.students = students;
        }

        public void Panel()
        {
            Console.Write("Student Panel: \n Enter your student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student foundStudent = null;
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    foundStudent = student;
                    break;
                }
            }

            if (foundStudent == null)
            {
                Console.WriteLine("No student with this ID.");
                return;
            }

            Console.WriteLine($"Welcome! {foundStudent.Name}");
            while (true)
            {
                Console.WriteLine("\nChoose Action: \n 1. Pay Fee \n 2. Show Details \n 3. Submit Complaint  \n 4. Exit Student Panel");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foundStudent.FeePayment();
                        break;
                    case 2:
                        foundStudent.DisplayDetails();
                        break;
                    case 3:
                        foundStudent.SubmitComplaint();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Student Panel...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }

}

