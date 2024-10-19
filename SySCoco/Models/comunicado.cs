using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class comunicado
    {
        public int id { get; set; }
        [ForeignKey("usuarios")]
        public int remitente { get; set; }
        public usuarios? Remitente { get; set; }
        [ForeignKey("usuarios")]
        public int destinatario { get; set; }
        public usuarios? Destinatario { get; set; }
        public string asunto { get; set; }
        public string contenido { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime fechaCreacion { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime fechaEnvio { get; set; }
        [DataType(DataType.Url)]
        public string archivoAdjunto { get; set; }
    }
}
