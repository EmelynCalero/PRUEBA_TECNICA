using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriculaWeb.BLL.Models
{
    public class Curso
    {
        public string IDCURSO { get; set; }
        public string DESCRIPCION { get; set; }
        public string IDSECCION { get; set; }
        public int CREDITOS { get; set; }

        public int VACANTESDIS { get; set; }

        public int VACANTESUSADAS { get; set; }
    }
}
