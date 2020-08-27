using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public class Degree : Institution
    {
        public int DegreeId { get; set; }
        public string LectureFullName { get; set; }
       
    }
}