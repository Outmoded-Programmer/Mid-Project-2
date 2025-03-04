using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Project_2
{
    abstract class Staff : Person
    {

        public string Role { get; set; }
        public Staff(int id, string name, string role , long contact , string email  ):base(id , name , contact , email)
        {
            Role = role;
        }
        public abstract void ShowDuties(); 
    }
}
