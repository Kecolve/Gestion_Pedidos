﻿using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Estados
    {
        [Key] public int id_estado { get; set; }
        public string? etapa { get; set; }

    }
}
