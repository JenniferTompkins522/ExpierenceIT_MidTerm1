using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExpirenceIT_MidTerm1.Models;

namespace ExpirenceIT_MidTerm1.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students/list
        public ActionResult List()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var students = db.Students.ToList();

            return View(students);
        }
       // GET: Students/Create
        public ActionResult Create()
        {

            var student = new Students(); 

            return View(student);
        }

        // GET: Students/Delete
        public ActionResult Delete()
        {

            var student = new Students();

            return View(student);

        }

        // GET: Students/Edit
        public ActionResult Edit()
        {

            var student = new Students();

            return View(student);


        }
        // GET: Students/Update
        public ActionResult Update()
        {

            var student = new Students();

            return View(student);