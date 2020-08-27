using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public class Course : Institution
    {
        public int CourseId { get; set; }
        public int DegreeId { get; set; }
    }
}