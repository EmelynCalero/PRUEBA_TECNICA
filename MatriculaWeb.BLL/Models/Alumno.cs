using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaWeb.BLL.Models
{
    public class Alumno
    {
        public string IDALUMNO { get; set; }
           public string NRODOC { get; set; }
        public string NOMBRES { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }

        public int ESTADO { get; set; }
    }
}
