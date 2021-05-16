using BibliotecaCore.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCore.Interfaces
{
    public interface ILibroRepositorio
    {
        Task<IEnumerable<Libro>> GetLibros();
        Task<Libro> GetLibros(int id);
        Task InsertLibro(Libro libro);
    }
}
