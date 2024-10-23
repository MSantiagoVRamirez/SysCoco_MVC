using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class votacion
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("usuarios")]
        [Required(ErrorMessage = "El campo 'usuario' es obligatorio.")]
        public int usuario { get; set; }

        public usuarios? Usuario { get; set; }

        [ForeignKey("encuesta")]
        [Required(ErrorMessage = "El campo 'encuesta' es obligatorio.")]
        public int encuesta { get; set; }

        public encuesta? Encuesta { get; set; }
    }
}
