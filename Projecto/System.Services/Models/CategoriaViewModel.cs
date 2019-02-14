﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace System.Services.Models
{
    public class CategoriaViewModel
    {
        [Required(ErrorMessage = "El campo Id es obligatorio")]
        public int CategoriaId { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Nombre { get; set; }
    }
}
