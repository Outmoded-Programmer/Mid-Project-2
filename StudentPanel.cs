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
            Console.Write("Student Panel: \nEnter your student ID: ");
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
                Console.WriteLine("No student with this ID found.");
                return;
            }

            Console.WriteLine($"Welcome! {foundStudent.Name}");
            while (true)
            {
                Console.WriteLine("\nChoose Action: \n1. Pay Fee \n2. Show Details \n3. Submit Complaint  \n4. Exit Student Panel");
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

