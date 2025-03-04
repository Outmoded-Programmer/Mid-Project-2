using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }

        public  Person (int id, string name ,long contact , string email)
        {
            this.Id = id;
            this.Name = name;
            this.Contact = contact;
            this.Email = email;
        }

        public abstract string ShowDetails();
    }
}
