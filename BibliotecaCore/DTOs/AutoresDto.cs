using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaCore.DTOs
{
    public class AutoresDto
    {
        public int AtrId { get; set; }
        [Required]
        public string AtrNombre { get; set; }
        [Required]
        public DateTime AtrFechaNacimiento { get; set; }
        public string AtrCiudad { get; set; }
        [Required]
        public string AtrEmail { get; set; }
    }
}
