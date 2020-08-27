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






        // GET: Lecturer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

  

 
    }
}
