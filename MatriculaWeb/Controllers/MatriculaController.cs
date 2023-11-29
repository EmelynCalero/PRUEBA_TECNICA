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
    public class MatriculaController : Controller
    {
        // GET: Matricula
        public ActionResult Index()
        {
            ViewBag.matriculas = new MatriculaBLL().ReadAll();
            return View();
        }

        // GET: Matricula/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matricula/Create
        public ActionResult Create()
        {
            ViewBag.seccion = new SeccionBLL().ReadAll();
            return View();
        }

        // POST: Matricula/Create
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

        // GET: Matricula/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matricula/Edit/5
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

        // GET: Matricula/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matricula/Delete/5
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
