using System;
using System.Collections.Generic;

namespace BibliotecaCore.Entidades
{
    public  class Libro
    {
        public int LbrId { get; set; }
        public string LbrTitulo { get; set; }
        public int LbrAño { get; set; }
        public string LbrGenero { get; set; }
        public int LbrNumeroPaginas { get; set; }
        public int LbrEdtId { get; set; }
        public int LbrAtrId { get; set; }

        public virtual Autores LbrAtr { get; set; }
        public virtual Editoriales LbrEdt { get; set; }
    }
}
