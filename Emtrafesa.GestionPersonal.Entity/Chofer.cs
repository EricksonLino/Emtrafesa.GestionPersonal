using System.ComponentModel.DataAnnotations;

namespace Emtrafesa.GestionPersonal.Entity
{
    public class Chofer
    {
        [Key]        
        public int Id { get; set; }
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
