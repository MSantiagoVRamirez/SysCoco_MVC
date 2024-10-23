using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class cursos
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("materia")]
        [Required(ErrorMessage = "El campo 'materiaid' es obligatorio.")]
        public int materiaid { get; set; }

        public materia? materia { get; set; }
    }
}
