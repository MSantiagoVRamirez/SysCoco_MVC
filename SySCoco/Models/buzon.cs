using System.ComponentModel.DataAnnotations.Schema;

namespace SySCoco.Models
{
    public class buzon
    {
        public int id { get; set; }
        public string nombre { get; set; }
        [ForeignKey("usuarios")]
        public int usuarios { get; set; }
        public usuarios? Usuarios { get; set; }
        public string mensaje { get; set; }
    }
}
