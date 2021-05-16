using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BibliotecaCore.DTOs
{
    public class LibroDto
    {
        public int LbrId { get; set; }
        [Required]
        public string LbrTitulo { get; set; }
        [Required]
        public int LbrAño { get; set; }
        [Required]
        public string LbrGenero { get; set; }
        public int LbrNumeroPaginas { get; set; }
        [Required]
        public int LbrEdtId { get; set; }
        [Required]
        public int LbrAtrId { get; set; }
    }
}
