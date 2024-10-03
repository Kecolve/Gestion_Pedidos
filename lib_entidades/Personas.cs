using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Personas
    {
        [Key] public int id { get; set; }
        public string? nombre { get; set; }
        public int cedula { get; set; }

    }

}
