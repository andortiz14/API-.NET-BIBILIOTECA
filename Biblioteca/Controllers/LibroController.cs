using AutoMapper;
using BibliotecaCore.DTOs;
using BibliotecaCore.Entidades;
using BibliotecaCore.Excepciones;
using BibliotecaCore.Interfaces;
using BibliotecaInfrasttruture.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroRepositorio _ILibroRepositorio;
        private readonly IMapper _IMapper;
        public LibroController(ILibroRepositorio LibroRepositorio, IMapper mapper)
        {
            _ILibroRepositorio = LibroRepositorio;
            _IMapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetLibro()
        {
            var libros = await _ILibroRepositorio.GetLibros();
            var librosDto = _IMapper.Map<IEnumerable<LibroDto>>(libros);
           
            return Ok(librosDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLibro(int id)
        {
            var libro = await _ILibroRepositorio.GetLibros(id);
            var libroDto = _IMapper.Map<LibroDto>(libro);

            if (libro == null)
            {
                throw new BusinessExceptions("No se encontraron libros");
            }

            return Ok(libroDto);
        }
        [HttpPost]
        public async Task<IActionResult> CreateLibro(LibroDto libroDto)
        {
            var libro = _IMapper.Map<Libro>(libroDto);
            await _ILibroRepositorio.InsertLibro(libro);

            return Ok(libro);
        }
    }
}
