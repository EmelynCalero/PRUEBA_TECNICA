using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaWeb.BLL.Models
{
    public class Matricula
    {
        public string IDMATRICULA { get; set; }
        public string IDALUMNO { get; set; }
        public string IDCURSO { get; set; }
        public string IDSECCION { get; set; }

        public string TIPOMATRICULA { get; set; }

        public DateTime FECHA_REGISTRO   { get; set; }
        public DateTime FECHA_ANULACION { get; set; }
        
        public Alumno ALUMNO { get; set; }

        public Curso CURSO { get; set; }

        public Seccion SECCION { get; set; }


    }
}
