using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaWeb.DALC;
using MatriculaWeb.BLL.Models;

namespace MatriculaWeb.BLL.BLL
{
    public class MatriculaBLL
    {
        DBEntities db = new DBEntities();

        public List<Matricula> ReadAll()
        {
            return this.db.MATRICULA.Select(p => new Matricula()
            {
            IDMATRICULA = p.IDMATRICULA,
            IDALUMNO = p.IDALUMNO,
            IDCURSO = p.IDCURSO,
            IDSECCION = p.IDSECCION,
            TIPOMATRICULA = p.IDMATRICULA,
            //FECHA_REGISTRO = (DateTime) p.FECHA_MATRICULA,
            //FECHA_ANULACION = (DateTime)p.FECHA_ANULACION,
            ALUMNO = new Alumno()
            {
                IDALUMNO =p.IDALUMNO,
                NRODOC = p.ALUMNO.NRODOC,
                NOMBRES = p.ALUMNO.NOMBRES,
                PATERNO = p.ALUMNO.APEPATERNO,
                MATERNO = p.ALUMNO.APEMATERNO,
                },
            CURSO = new Curso()
            {
                IDCURSO = p.CURSO.IDCURSO,
                DESCRIPCION=p.CURSO.DESCRIPCION,
                CREDITOS = (int)p.CURSO.CREDITOS,
                IDSECCION = p.IDSECCION
            },
            SECCION = new Seccion()
            {
                IDSECCION = p.IDSECCION,
                DESCRIPCION = p.IDSECCION,
                ESTADO = p.SECCION.ESTADO
            }


            }).ToList();
        }
    }
}
