namespace SySCoco.Models
{
    public class roles
    {
        public int id { get; set; }

        public enum nombre
        {
            institucion,
            moderador,
            estudiante,
            acudiente

        }
        public nombre Nombre { get; set; }
        public bool Estado { get; set; }


    }
}

