using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public class Person
    {
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Firstname { get => Forenames; set => Forenames = value;}
        public string Fullname { get => Forenames + " " + Surname; set => Forenames  = value; }
    }
}