using BibliotecaCore.Entidades;
using BibliotecaCore.Interfaces;
using BibliotecaInfrasttruture.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaInfrasttruture.Repositorios
{
    public class EditorialRepositorio:IEditorialRepositorio
    {
        private readonly BibliotecaContext _context;

        public EditorialRepositorio(BibliotecaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Editoriales>> GetEditoriales()
        {
            var editoriales = await _context.Editoriales.ToListAsync();

            return editoriales;
        }
        public async Task<Editoriales> GetEditoriales(int id)
        {
            var editorial = await _context.Editoriales.FirstOrDefaultAsync(x => x.EdtId == id);

            return editorial;
        }

        public async Task InsertEditoriales (Editoriales editoriales)
        {
            _context.Editoriales.Add(editoriales);
            await _context.SaveChangesAsync();
        }
    }
}
