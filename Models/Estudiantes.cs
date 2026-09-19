using System.ComponentModel.DataAnnotations;

namespace Tarea2.Models;

    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        //[Required(ErrorMessage ="Nombre es Obligatorio")]
        public string Nombre { get; set; }
       // [Required(ErrorMessage = "Dirrecion es Obligatorio")]
        public string Dirrecion { get; set; }

       // [Required(ErrorMessage = "Email es Obligatorio")]
        public string Email { get; set; }
    
       public string FechaNacimiento { get; set; }
      

}
