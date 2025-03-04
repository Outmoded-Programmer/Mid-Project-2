using System;
using System.Collections.Generic;

namespace Mid_Project_2
{
    class Room
    {
        public int RoomNumber { get; set; }
        public List<Student> Students { get; private set; }  
        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (Students.Count < 4)  // ✅ Limit to 4 students per room
            {
                Students.Add(student);
                Console.WriteLine($"Student {student.Name} (ID: {student.Id}) added to Room {RoomNumber}.");
            }
            else
            {
                Console.WriteLine($"Room {RoomNumber} is full! Cannot add {student.Name}.");
            }
        }

        public void RemoveStudent(Student student)
        {
            if (Students.Remove(student))
            {
                Console.WriteLine($"Student {student.Name} (ID: {student.Id}) removed from Room {RoomNumber}.");
            }
            else
            {
                Console.WriteLine($"Student {student.Name} not found in Room {RoomNumber}.");
            }
        }

        public bool IsFull()
        {
            return Students.Count >= 4;
        }


        public void ShowRoomDetails()
        {
            Console.WriteLine($"\nRoom {RoomNumber}: {Students.Count}/4 Students");
            foreach (var student in Students)
            {
                Console.WriteLine($" Name: {student.Name} (ID: {student.Id})");
            }
        }
    }
}
