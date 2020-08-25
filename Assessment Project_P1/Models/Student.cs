using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        public Degree StudDegree { get; set; }
    }
}