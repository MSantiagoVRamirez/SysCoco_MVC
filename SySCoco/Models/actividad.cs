using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class actividad
    {
        public int id { get; set; }
        [ForeignKey("usuarios")]
        public int creador { get; set; }
        public usuarios? usuarios { get; set; }
        [ForeignKey("cursos")]
        public int cursoid { get; set; }
        public cursos? cursos { get; set; }
        public string asunto { get; set; }
        public string contenido { get; set; }
        [DataType(DataType.Date)]
        public DateTime fechaCreacion { get; set; }

        [DataType(DataType.Date)]
        public DateTime fechaenvio { get; set; }
        [DataType(DataType.Url)]
        public string documentoAdjunto { get; set; }
    }
}
