using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaCore.DTOs
{
    public class EditorialesDto
    {
        public int EdtId { get; set; }
        [Required]
        public string EdtNombre { get; set; }
        public string EdtDireccion { get; set; }
        public string EdtTelefono { get; set; }
        [Required]
        public string EdtEmail { get; set; }
        [Required]
        public int? EdtMaximo { get; set; }
    }
}
