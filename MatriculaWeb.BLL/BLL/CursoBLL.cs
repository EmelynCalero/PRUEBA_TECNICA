using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaWeb.DALC;
using MatriculaWeb.BLL.Models;

namespace MatriculaWeb.BLL.BLL
{
    public class CursoBLL
    {
        DBEntities db = new DBEntities();

        public List<Curso> ReadAll()
        {
            return this.db.CURSO.Select(s => new Curso()
            {
                IDCURSO = s.IDCURSO,
                DESCRIPCION = s.DESCRIPCION

            }).ToList();
        }
    }
}
