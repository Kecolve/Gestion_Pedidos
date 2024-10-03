using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Transportistas
    {
        [Key] public int id { get; set; }
        public string? tipo_transportista { get; set; }

    }
}
