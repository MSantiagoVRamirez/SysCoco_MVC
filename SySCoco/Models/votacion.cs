using System.ComponentModel.DataAnnotations.Schema;

namespace SySCoco.Models
{
    public class votacion
    {
        public int id { get; set; }
        [ForeignKey("usuarios")]
        public int usuario { get; set; }
        public usuarios? Usuario { get; set; }
        [ForeignKey("encuesta")]
        public int encuesta { get; set; }
        public encuesta? Encuesta { get; set; }
    }
}
