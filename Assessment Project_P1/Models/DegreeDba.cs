using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessment_Project_P1.Models
{
    public static class DegreeDba
    {
     
       public static List<Degree> DegreeList = new List<Degree>() {

                new Degree {Courses = new List<Course>(){
                    new Course { CourseId=1 ,Name="Networking" , DegreeId=1 , Duration=48},
                    new Course { CourseId=2 ,Name="Programming" , DegreeId=1 , Duration=48}},DegreeId=1 ,Duration=4 ,Name="Information Technology" ,LectureFullName=" Mr Mhlaba"


                },
                new Degree {Courses = new List<Course>(){
                    new Course { CourseId=3 ,Name="Civil Engineering" , DegreeId=2 , Duration=24},
                    new Course { CourseId=4 ,Name="Mechanical Engineering" , DegreeId=2 , Duration=24},
                    new Course { CourseId=5 ,Name="Electronics Engineering" , DegreeId=2 , Duration=24},
                    new Course { CourseId=6 ,Name="Electrical ebginerring" , DegreeId=2 , Duration=24}},DegreeId=2 ,Duration=2 ,Name="Engineering" ,LectureFullName="Mr Kruger"


                },

                new Degree {Courses = new List<Course>(){
                    new Course { CourseId=7 ,Name="Architucture" , DegreeId=3 , Duration=36},
                    new Course { CourseId=8 ,Name="Quantity surveying" , DegreeId=3 , Duration=36}},DegreeId=3 ,Duration=3 ,Name="Building Science" ,LectureFullName="Mrs Norjie"
                },
            };
    }
}