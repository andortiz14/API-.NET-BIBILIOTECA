using AutoMapper;
using BibliotecaCore.DTOs;
using BibliotecaCore.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaInfrasttruture.Mapping
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile() 
        {
            CreateMap<Libro, LibroDto>();
            CreateMap<LibroDto, Libro>();

            CreateMap<Autores, AutoresDto>();
            CreateMap<AutoresDto, Autores>();

            CreateMap<Editoriales, EditorialesDto>();
            CreateMap<EditorialesDto, Editoriales>();

        }
    }
}
