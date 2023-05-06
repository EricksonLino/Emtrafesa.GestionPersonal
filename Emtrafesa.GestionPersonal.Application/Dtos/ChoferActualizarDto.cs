using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emtrafesa.GestionPersonal.Application.Dtos
{
    public class ChoferActualizarDto
    {
     
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(8)]
        public string Dni { get; set; }
        [Required]
        public int HorasDeManejo { get; set; }
    }
}
