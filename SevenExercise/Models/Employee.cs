using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SevenExercise.Models
{
    public class Employee
    {
        public int Id { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Gender { set; get; }
        public int Age { set; get; }

        public string Email { set; get; }

        public string Phone { set; get; }

        public Skill Skill { set; get; }
    }
}