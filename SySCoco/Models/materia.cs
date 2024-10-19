using System.ComponentModel.DataAnnotations.Schema;

namespace SySCoco.Models
{
    public class materia
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        [ForeignKey("usuarios")]
        public int usuariosid { get; set; }
        public usuarios? usuarios { get; set; }
    }
}
