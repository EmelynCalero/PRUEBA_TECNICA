using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaWeb.BLL.Models;
using MatriculaWeb.DALC;

namespace MatriculaWeb.BLL.Models
{
    public class Vacante
    {
        public string IDVACANTE { get; set; }      
   

        public string IDCURSO { get; set; }
        public string IDSECCION { get; set; }

        public Curso CURSO { get; set; }

        public Seccion SECCION { get; set; }

    }
}
