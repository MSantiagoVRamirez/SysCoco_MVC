﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class comunicado
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("usuarios")]
        [Required(ErrorMessage = "El campo 'remitente' es obligatorio.")]
        public int remitente { get; set; }

        public usuarios? Remitente { get; set; }

        [ForeignKey("usuarios")]
        [Required(ErrorMessage = "El campo 'destinatario' es obligatorio.")]
        public int destinatario { get; set; }

        public usuarios? Destinatario { get; set; }

        [Required(ErrorMessage = "El campo 'asunto' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El 'asunto' no puede exceder los 100 caracteres.")]
        public string asunto { get; set; }

        [Required(ErrorMessage = "El campo 'contenido' es obligatorio.")]
        [StringLength(2000, ErrorMessage = "El 'contenido' no puede exceder los 2000 caracteres.")]
        public string contenido { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "La 'fecha de creación' es obligatoria.")]
        public DateTime fechaCreacion { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "La 'fecha de envío' es obligatoria.")]
        public DateTime fechaEnvio { get; set; }

        [DataType(DataType.Url)]
        [StringLength(200, ErrorMessage = "La URL del 'archivo adjunto' no puede exceder los 200 caracteres.")]
        public string archivoAdjunto { get; set; }
    }
}
