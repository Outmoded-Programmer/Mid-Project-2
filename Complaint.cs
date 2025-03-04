using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class Complaint
    {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public string ComplaintText { get; set; }

            public Complaint(int studentId, string studentName, string complaintText)
            {
                StudentId = studentId;
                StudentName = studentName;
                ComplaintText = complaintText;
            }

            public void DisplayComplaint()
            {
                Console.WriteLine($"Student ID: {StudentId}, Name: {StudentName}");
                Console.WriteLine($"Complaint: {ComplaintText}");
                Console.WriteLine();
            }
        }

    }
