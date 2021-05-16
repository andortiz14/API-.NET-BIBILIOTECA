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
    public class libroRepositorio: ILibroRepositorio
    {
        private readonly BibliotecaContext _context;

        public libroRepositorio(BibliotecaContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<Libro>> GetLibros() 
        {
            var libro = await _context.Libro.ToListAsync();
           
            return libro;
        }
        public async Task<Libro> GetLibros(int id)
        {
            var libro = await _context.Libro.FirstOrDefaultAsync(x=> x.LbrId == id);

            return libro;
        }
        public async Task InsertLibro(Libro libro)
        {
            _context.Libro.Add(libro);
            await _context.SaveChangesAsync();
        }
    }
}
