using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SySCoco.Models
{
    public class usuarios
    {
        public int id { get; set; }

        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }

        [DataType(DataType.Password)]
        public string contraseña { get; set; }

        [DataType(DataType.Date)]
        public DateTime fechaNacimiento { get; set; }
        [MaxLength(10)]
        public string numeroTelefono { get; set; }

        [DataType(DataType.EmailAddress)]
        public string correo { get; set; }

        [ForeignKey("roles")]

        public int rolesid { get; set; }

        public roles? roles { get; set; }
    }
}
