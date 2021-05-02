using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Monsters.Models
{
    public class Student
    {

     
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string EmailAdress { get; set; }

        public string PhoneNumber { get; set; }

        public string Course
        {
            get; set;
        }

    
    }
}
