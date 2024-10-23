using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class roles
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El campo 'Nombre' es obligatorio.")]
        public nombre Nombre { get; set; }

        public bool Estado { get; set; }

        public enum nombre
        {
            institucion,
            moderador,
            estudiante,
            acudiente
        }
    }
}
