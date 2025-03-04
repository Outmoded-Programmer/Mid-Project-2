using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    class Student: Person , IStudentActions
    {
        private int allocatedRoom;

        private List<Complaint> Complaints { get; set; } = new List<Complaint>();

        private bool HasPaid = false;

        public Student(int id, string name, long contact, string email) : base(id, name, contact, email)
        {
        }

        public void AssignedRoom(Room room)
        {
            allocatedRoom = room.RoomNumber;
        }

        public void FeePayment()
        {
            if (HasPaid)
            {
                Console.WriteLine("Fees has aleready been paid");
            }
            else
            {
                Console.WriteLine("Enter your payment:");
                double fees = Convert.ToDouble(Console.ReadLine());
                if(fees < 5000)
                {
                    Console.WriteLine("Insuffiecent payment");
                    return;
                }
                else
                {
                    Console.WriteLine("Payment Successful");
                    HasPaid = true;
                }
            }

        }
        public override string ShowDetails()
        {
            return $" Student:\n Id: {Id} \n Name: {Name} \n Room: {allocatedRoom + 1}  \n Email: {Email} \n Contact info: {Contact} ";
        }
        public  void DisplayDetails()
        {
            if (!HasPaid)
            {
                Console.WriteLine("You need to pay the fees to see details");
            }
            else
            {
                Console.WriteLine($" Student:\n Id: {Id} \n Name: {Name} \n Room: {allocatedRoom + 1}  \n Email: {Email} \n Contact info: {Contact} ");
            }
        }
        public void SubmitComplaint()
        {

            Console.WriteLine("Enter your complaint:");
            string complaintText = Console.ReadLine();

            // Store complaint using the Complaint class
            Complaints.Add(new Complaint(Id, Name, complaintText));

            Console.WriteLine("Your complaint has been registered.");
        }
        public void ViewComplaint()
        {
            if(Complaints.Count == 0)
            {
                Console.WriteLine("There are no complaints");
                return;
            }
            Console.WriteLine("\n List Of complaints \n");
            foreach(var complaint in Complaints)
            {
                complaint.DisplayComplaint();
            }
        }
    }
}
