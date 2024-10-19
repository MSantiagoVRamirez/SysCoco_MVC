using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class asistencia
    {
        public int id { get; set; }
        [ForeignKey("cursos")]
        public int curso { get; set; }
        public cursos? cursos { get; set; }
        [ForeignKey("usuarios")]
        public int usuario { get; set; }
        public usuarios? usuarios { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime fechaAsistencia { get; set; }
        public bool estado { get; set; }
    }
}
