using System;
using System.Collections.Generic;

namespace BibliotecaCore.Entidades
{
    public  class Editoriales
    {
        public Editoriales()
        {
            Libro = new HashSet<Libro>();
        }

        public int EdtId { get; set; }
        public string EdtNombre { get; set; }
        public string EdtDireccion { get; set; }
        public string EdtTelefono { get; set; }
        public string EdtEmail { get; set; }
        public int? EdtMaximo { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
