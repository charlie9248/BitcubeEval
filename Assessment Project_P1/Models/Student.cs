using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assessment_Project_P1.Models
{
    public class Student : Person
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage ="This feild must be filled")]
        [Range(1, 3 ,ErrorMessage ="Value must be between 1 and 3")]
        public int DegreeId { get; set; }
    }
}