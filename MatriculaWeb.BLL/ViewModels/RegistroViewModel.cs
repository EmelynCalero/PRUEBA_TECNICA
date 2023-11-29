using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatriculaWeb.BLL.Models;

namespace MatriculaWeb.BLL.ViewModels
{
    public class RegistroViewModel
    {
        public string IdMatricula { get; set; }
        [Required]
        [StringLength(10)]
        [Display(Name = "Nro. Documento:")]
        public string NroDocumento { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Nombres:")]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido Paterno:")]
        public string Paterno { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Apellido Materno:")]
        public string Materno { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tipo Matricula:")]
        public string TipoMatricula { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "Curso:")]
        public string Curso { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Seccion:")]
        public string Seccion { get; set; }

        [Required]
        [Display(Name = "Estado:")]
        public int Estado { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha Registro:")]
        public DateTime FechaRegistro { get; set; }

        
        [Display(Name = "Fecha Anulacion:")]
        [DataType(DataType.Date)]
        public DateTime FechaAnulacion { get; set; }
    }
}
