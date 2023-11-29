using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaWeb.DALC;
using MatriculaWeb.BLL.Models;

namespace MatriculaWeb.BLL.BLL
{
   public class VacanteBLL
    {

        DBEntities db = new DBEntities();

        public List<Vacante> ReadAll()
        {
            return this.db.VACANTES.Select(p => new Vacante()
            {
                IDVACANTE = p.IDVACANTES,
                IDCURSO = p.IDCURSO,
                IDSECCION = p.IDSECCION,
                CURSO = new Curso()
                {
                    IDCURSO =p.CURSO.IDCURSO,
                    DESCRIPCION = p.CURSO.DESCRIPCION,
                    VACANTESDIS = (int)p.CURSO.VACANTES_DISPONIBLES,
                    CREDITOS = (int)p.CURSO.CREDITOS

                },
                SECCION = new Seccion()
                {
                    IDSECCION= p.SECCION.IDSECCION,
                    DESCRIPCION = p.SECCION.DESCRIPCION
                }

            }).ToList();
        }
    }
}
