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
    public class AutorRepositorio:IAutorRepositorio
    {
        private readonly BibliotecaContext _context;

        public AutorRepositorio(BibliotecaContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Autores>> GetAutores()
        {
            var autores = await _context.Autores.ToListAsync();

            return autores;
        }
        public async Task<Autores> GetAutores(int id)
        {
            var autor = await _context.Autores.FirstOrDefaultAsync(x => x.AtrId == id);

            return autor;
        }
       
        public async Task InsertAutores(Autores autores)
        {
            _context.Autores.Add(autores);
            await _context.SaveChangesAsync();
        }

    }
}
