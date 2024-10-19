using System.ComponentModel.DataAnnotations.Schema;

namespace SySCoco.Models
{
    public class encuesta
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public enum tipoP
        {
            Cerrada,
            Abierta
        }
        public tipoP tipoPregunta { get; set; }
        public string pregunta { get; set; }
        public string texto { get; set; }
        public string respuesta { get; set; }
        [ForeignKey("usuarios")]
        public int usuario { get; set; }
        public usuarios? Usuario { get; set; }
    }
}

