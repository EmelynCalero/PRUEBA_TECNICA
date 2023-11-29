using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatriculaWeb.BLL;
using MatriculaWeb.BLL.BLL;
using MatriculaWeb.BLL.Models;

namespace MatriculaWeb.Controllers
{
    public class VacantesController : Controller
    {
        // GET: Vacantes
        public ActionResult Index()
        {

            ViewBag.vacantes = new VacanteBLL().ReadAll();           
            return View();
        }

        // GET: Vacantes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vacantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vacantes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacantes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vacantes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vacantes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vacantes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
