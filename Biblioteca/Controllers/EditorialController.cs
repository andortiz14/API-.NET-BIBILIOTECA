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
    public class EditorialController : ControllerBase
    {
        private readonly IEditorialRepositorio _IEditorialRepositorio;
        private readonly IMapper _IMapper;

        public  EditorialController(IEditorialRepositorio editorialRepositorio, IMapper mapper)
        {
            _IEditorialRepositorio = editorialRepositorio;
            _IMapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetEditoriales()
        {
            var Editorales = await _IEditorialRepositorio.GetEditoriales();
            var editorialesDto = _IMapper.Map<IEnumerable<EditorialesDto>>(Editorales);

            return Ok(editorialesDto);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEditoriales(int id)
        {
            var editorial = await _IEditorialRepositorio.GetEditoriales(id);
            var editorialDto = _IMapper.Map<EditorialesDto>(editorial);
            return Ok(editorialDto);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEditoriales(EditorialesDto editorialesDto)
        {
            var editorial = _IMapper.Map<Editoriales>(editorialesDto);
            await _IEditorialRepositorio.InsertEditoriales(editorial);

            return Ok(editorial);
        }
    }
}
