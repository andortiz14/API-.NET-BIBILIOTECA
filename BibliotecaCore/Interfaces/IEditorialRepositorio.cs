using BibliotecaCore.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaCore.Interfaces
{
    public interface IEditorialRepositorio
    {
        Task<IEnumerable<Editoriales>> GetEditoriales();
        Task<Editoriales> GetEditoriales(int id);
        Task InsertEditoriales(Editoriales editoriales);
    }
}
