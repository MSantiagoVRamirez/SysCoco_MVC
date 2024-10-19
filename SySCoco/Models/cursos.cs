using System.ComponentModel.DataAnnotations.Schema;

namespace SySCoco.Models
{
    public class cursos
    {
        public int id { get; set; }
        [ForeignKey("materia")]
        public int materiaid { get; set; }
        public materia? materia { get; set; }
    }
}
