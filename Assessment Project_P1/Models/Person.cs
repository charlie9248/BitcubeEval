using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Assessment_Project_P1.Models
{
    public class Person
    {
        [Required( ErrorMessage = "Forenames is required")]
        public string Forenames { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress , ErrorMessage ="Email not in the right format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date, ErrorMessage = "Date not in the right format")]
        public DateTime DOB { get; set; }
        public string Firstname { get => Forenames; set => Forenames = value;}
        public string Fullname { get => Forenames + " " + Surname; set => Forenames  = value; }
    }
}