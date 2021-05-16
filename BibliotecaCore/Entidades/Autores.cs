using System;
using System.Collections.Generic;

namespace BibliotecaCore.Entidades
{
    public  class Autores
    {
        public Autores()
        {
            Libro = new HashSet<Libro>();
        }

        public int AtrId { get; set; }
        public string AtrNombre { get; set; }
        public DateTime AtrFechaNacimiento { get; set; }
        public string AtrCiudad { get; set; }
        public string AtrEmail { get; set; }

        public virtual ICollection<Libro> Libro { get; set; }
    }
}
