using BibliotecaCore.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCore.Interfaces
{
    public interface IAutorRepositorio
    {
        Task<IEnumerable<Autores>> GetAutores();
        Task<Autores> GetAutores(int id);
        Task InsertAutores(Autores autores);
    }
}
