using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public class Lecturer  : Person
    {
        public int LecturerId { get; set; }
        public List<Degree> DegreeNumber { get; set; }
       
    }
}