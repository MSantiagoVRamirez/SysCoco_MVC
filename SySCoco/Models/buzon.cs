using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class buzon
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El campo 'nombre' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El 'nombre' no puede exceder los 100 caracteres.")]
        public string nombre { get; set; }

        [ForeignKey("usuarios")]
        [Required(ErrorMessage = "El campo 'usuarios' es obligatorio.")]
        public int usuarios { get; set; }

        public usuarios? Usuarios { get; set; }

        [Required(ErrorMessage = "El campo 'mensaje' es obligatorio.")]
        [StringLength(1000, ErrorMessage = "El 'mensaje' no puede exceder los 1000 caracteres.")]
        public string mensaje { get; set; }
    }
}