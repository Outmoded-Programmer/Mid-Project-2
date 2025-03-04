using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_Project_2
{
    class Admin : Person
    {
        public List<Student> students = new List<Student>();
        public List<Room> rooms = new List<Room>();
        public string Password { get; protected set; }

        public Admin(int id, string name, long contact, string email, string password)
            : base(id, name, contact, email)
        {
            this.Password = password;
            TotalRoom(); 
        }

        public void TotalRoom()
        {
            for (int i = 0; i < 8; i++)
            {
                Room room = new Room(i + 1);
                rooms.Add(room);
            }
        }

        public override string ShowDetails()
        {
            return $"Admin: \n Name: {Name} \n Contact: {Contact} \n Email: {Email}";
        }

        public void AddStudent()
        {
            Console.Write("Enter student id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (FindStudentById(id) != null)
            {
                Console.WriteLine("Student with this ID already exists.");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student email: ");
            string email = Console.ReadLine();
            Console.Write("Enter student's contact info: ");
            long contact = Convert.ToInt64(Console.ReadLine());

            Student student = new Student(id, name, contact, email);
            students.Add(student);
            Console.WriteLine("Student added successfully.");

            // Admin selects a room
            Console.WriteLine("\nAvailable Rooms:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room {room.RoomNumber} - {room.Students.Count}/4 Students");
            }

            Console.Write("\nEnter Room Number to Assign Student: ");
            int roomNumber = Convert.ToInt32(Console.ReadLine());

            Room selectedRoom = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (selectedRoom == null)
            {
                Console.WriteLine("Invalid room number. Student not assigned.");
                return;
            }

            if (selectedRoom.IsFull())
            {
                Console.WriteLine("This room is already full. Choose another room.");
                return;
            }

            selectedRoom.AddStudent(student);
            Console.WriteLine($"Student {name} (ID: {id}) assigned to Room {roomNumber}.");
            Console.WriteLine($"Room {roomNumber} now has {selectedRoom.Students.Count} students.");
        }

        public void RemoveStudent()
        {
            Console.Write("Enter student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Student student = FindStudentById(id);
            if (student == null)
            {
                Console.WriteLine("No student found.");
                return;
            }


            students.Remove(student);

            foreach (var room in rooms)
            {
                if (room.Students.Contains(student))
                {
                    room.RemoveStudent(student);
                    Console.WriteLine($"Student removed from Room {room.RoomNumber}");
                    break;
                }
            }

            Console.WriteLine("Student removed successfully.");
        }
        public void UpdateStudent(int id, long contact , string email)
        {

            Student student = FindStudentById(id);
            if(student == null)
            {
                Console.WriteLine("No Student found");
                return;
            }
            student.Email = email;
            student.Contact = contact;
        }

        public void DisplayStudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            Console.WriteLine("Student List:");
            foreach (var student in students)
            {
                Console.WriteLine(student.ShowDetails());
                Console.WriteLine("----------------------");
            }
        }

        public void DisplayRooms()
        {
            Console.WriteLine("\nRooms and Assigned Students:");
            foreach (var room in rooms)
            {
                Console.WriteLine($"Room {room.RoomNumber}: {room.Students.Count}/4 Students");
                foreach (var student in room.Students)
                {
                    Console.WriteLine($" Name: {student.Name} ; (ID: {student.Id})");
                }
                Console.WriteLine();
            }
        }

        public Student FindStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        public void ViewComplaints()
        {
            Console.WriteLine("\nComplaints of Students\n");
            bool hasComplaints = false;
            foreach(var student in students)
            {
                if(student != null)
                {
                    student.ViewComplaint();
                    Console.WriteLine("----------------------");
                    hasComplaints = true;
                }
                if (!hasComplaints)
                {
                    Console.WriteLine("\nThere are no complaints");

                }
            }
        }
        
    }
}
