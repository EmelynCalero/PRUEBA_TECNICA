using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaWeb.DALC;
using MatriculaWeb.BLL.Models;

namespace MatriculaWeb.BLL.BLL
{
    public class SeccionBLL
    {
        DBEntities db = new DBEntities();

        public List<Seccion> ReadAll()
        {
            return this.db.SECCION.Where(s => s.ESTADO=="1").Select(s => new Seccion()
            {
                IDSECCION = s.IDSECCION,
                DESCRIPCION =s.DESCRIPCION
               
            }).ToList();
        }
    }
}
