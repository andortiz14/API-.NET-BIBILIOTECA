using AutoMapper;
using BibliotecaCore.DTOs;
using BibliotecaCore.Entidades;
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
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepositorio _IAutorRepositorio;
        private readonly IMapper _IMapper;

        public AutorController(IAutorRepositorio autorRepositorio, IMapper mapper)
        {
            _IAutorRepositorio = autorRepositorio;
            _IMapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAutores()
        {
            var autores = await _IAutorRepositorio.GetAutores();
            var autoresDto = _IMapper.Map<IEnumerable<AutoresDto>>(autores);

            return Ok(autoresDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAutor(int id)
        {
            var autor = await _IAutorRepositorio.GetAutores(id);
            var autorDto = _IMapper.Map<AutoresDto>(autor);

            return Ok(autorDto);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAutor(AutoresDto autoresDto)
        {
            var autores = _IMapper.Map<Autores>(autoresDto);

            await _IAutorRepositorio.InsertAutores(autores);
            return Ok(autores);
        }
    }
}
