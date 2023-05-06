namespace Emtrafesa.GestionPersonal.Application.Dtos
{
    public class ChoferDto
    {      
        public int Id { get; set; }
        public string Nombre { get; set; } 
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public int HorasDeManejo { get; set; }
    }
}
