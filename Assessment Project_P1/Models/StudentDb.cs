using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public static class StudentDb
    {
       public static List<Student> studList = new List<Student>() {

                new Student {DOB=DateTime.Now , Email="studentOne@gmail.com" , Forenames="Student1" , Surname="stud One" , StudentId=1 ,DegreeId=1 },
                new Student {DOB=DateTime.Now , Email="studentTwo@gmail.com" , Forenames="Student2" , Surname="stud Two" , StudentId=2  ,DegreeId=3},
                new Student {DOB=DateTime.Now , Email="studentThree@gmail.com" , Forenames="Student3" , Surname="stud Three" , StudentId=3 ,DegreeId=1 },
                new Student {DOB=DateTime.Now , Email="studentFour@gmail.com" , Forenames="Student4" , Surname="stud Four" , StudentId=4  ,DegreeId=2 },
            };
    }
}