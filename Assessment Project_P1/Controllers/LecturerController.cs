using Assessment_Project_P1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment_Project_P1.Controllers
{
    public class LecturerController : Controller
    {
        // GET: Lecturer
       
        
        public ActionResult ListOfStudent()
        {
            return View(StudentDb.studList);
        }

        public ActionResult ListOfDegrees()
        {
            return View(DegreeDba.DegreeList);
        }

        // GET: Lecturer/Details/5
        public ActionResult Details(int? id)
        {
            var filter = DegreeDba.DegreeList.Where(x => x.Courses.Any(a => a.DegreeId == id)).ToList();
            return View(filter[0].Courses.Where(x => x.DegreeId == id).ToList());
        }

        // GET: Lecturer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lecturer/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
                return View();
        }



        public ActionResult StudentDegree(int id)
        {
            var studDegree = DegreeDba.DegreeList.Where(x => x.Courses.Any(a => a.DegreeId == id)).ToList();
            return View(studDegree);
        }

        public ActionResult AddstudentToDegree() {

            ViewBag.availableDegree = DegreeDba.DegreeList.Where(x => x.DegreeId != 0);
            return View();
        }

        [HttpPost]
        public ActionResult AddstudentToDegree(Student student)
        {
            student.StudentId = StudentDb.studList.Count() + 1;
            if (student.DegreeId != 0 && student.DOB != null && student.Email != "" && student.Surname != "" && student.Forenames != "") {

                StudentDb.studList.Add(student);

                return RedirectToAction("ListOfStudent");
            }
             ViewBag.availableDegree = DegreeDba.DegreeList.Where(x => x.DegreeId != 0);
            return View();
        }


        public ActionResult RemovestudentToDegree(int id )
        {


            //StudentDb.studList.RemoveAt(student.StudentId);
            StudentDb.studList.RemoveAll(x => x.StudentId == id);

            return RedirectToAction("ListOfStudent");
        }















    }
}
