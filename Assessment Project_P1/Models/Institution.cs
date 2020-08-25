using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public class Institution
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public  List<Course> Courses { get; set; }
    }
}