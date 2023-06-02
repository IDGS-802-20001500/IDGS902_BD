using IDGS902_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS902_BD.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {

            using (AlumnosDBContext dbAlumno = new AlumnosDBContext())
            {
                //Select * from alumnos

                return View(dbAlumno.Alumnos.ToList());
            }
            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Alumnos alum)
        {
            using (AlumnosDBContext dbAlumnos = new AlumnosDBContext())
            {
                dbAlumnos.Alumnos.Add(alum);
                dbAlumnos.SaveChanges();




            }
            return RedirectToAction("Index");



        }




    }
}