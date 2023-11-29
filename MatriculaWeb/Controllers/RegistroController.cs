using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MatriculaWeb.DALC;
using MatriculaWeb.BLL;
using MatriculaWeb.BLL.BLL;
using MatriculaWeb.BLL.Models;
using MatriculaWeb.BLL.ViewModels;


namespace MatriculaWeb.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        // GET: Registro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registro/Create
        public ActionResult Create()
        {
            EnviarTiposMatriculas();
            EnviarSecciones();
            EnviarCursos();
            EnviarEstados();
            return View();
        }

        private void EnviarSecciones()
        {
            ViewBag.secciones = new SeccionBLL().ReadAll();
        }

        private void EnviarCursos()
        {
            ViewBag.cursos = new CursoBLL().ReadAll();
        }
        private void EnviarTiposMatriculas()
        {
            List<TipoMatricula> items = new List<TipoMatricula>();

            items.Add(new TipoMatricula { DESCRIPCION = "PRESENCIAL", IDTIPO = "0" });

            items.Add(new TipoMatricula { DESCRIPCION = "VIRTUAL", IDTIPO = "1" });          

            ViewBag.tipos = items;

           
        }
        private void EnviarEstados()
        {
            List<Estado> items = new List<Estado>();

            items.Add(new Estado { IDESTADO = "0", DESCRIPCION = "ACTIVO" });

            items.Add(new Estado { IDESTADO = "1", DESCRIPCION = "INACTIVO" });

            ViewBag.estados = items;


        }
        // POST: Registro/Create
        [HttpPost]
        public ActionResult Create(RegistroViewModel registro)
        {
            EnviarTiposMatriculas();
            EnviarSecciones();
            EnviarCursos();
            EnviarEstados();
            try
            {
             if (ModelState.IsValid)
                    using (DBEntities db = new DBEntities())
                    {
                        //GENERAR IDMATRICULA
                        var idMatricula = db.MATRICULA.OrderByDescending(m => m.IDMATRICULA).First().IDMATRICULA ;
                   
                        //GENERAR IDMATRICULA
                        var idAlumno = db.ALUMNO.OrderByDescending(a => a.IDALUMNO).First().IDALUMNO ;

                        var oRegistro = new MATRICULA();
                        oRegistro.IDMATRICULA = idMatricula +1 ;
                        oRegistro.IDALUMNO = idAlumno +1 ;
                        oRegistro.IDCURSO = registro.Curso;
                        oRegistro.IDSECCION = registro.Seccion;
                        oRegistro.TIPO_MATRICULA = registro.TipoMatricula.ToString();              
                        oRegistro.FECHA_MATRICULA = registro.FechaRegistro;
                        var oAlumno  = new ALUMNO();
                        oAlumno.IDALUMNO = idAlumno.ToString();
                        oAlumno.NOMBRES = registro.Nombres;
                        oAlumno.APEMATERNO = registro.Paterno;
                        oAlumno.APEMATERNO = registro.Materno;
                        oAlumno.ESTADO = registro.Estado;
                        db.MATRICULA.Add(oRegistro);                     
                        db.ALUMNO.Add(oAlumno);
                        db.SaveChanges();

                    }
                return    
                    View();
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Registro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registro/Edit/5
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

        // GET: Registro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registro/Delete/5
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
