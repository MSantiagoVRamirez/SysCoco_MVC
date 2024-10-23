using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class asistencia
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("cursos")]
        [Required(ErrorMessage = "El campo 'curso' es obligatorio.")]
        public int curso { get; set; }

        public cursos? cursos { get; set; }

        [ForeignKey("usuarios")]
        [Required(ErrorMessage = "El campo 'usuario' es obligatorio.")]
        public int usuario { get; set; }

        public usuarios? usuarios { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "La 'fecha de asistencia' es obligatoria.")]
        public DateTime fechaAsistencia { get; set; }

        [Required(ErrorMessage = "El campo 'estado' es obligatorio.")]
        public bool estado { get; set; }
    }
}
