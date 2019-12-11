using Api.Dtos;
using AutoMapper;
using Dominio.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Profiles
{
    public class PerroProfile:Profile
    {

        public PerroProfile()
        {
            CreateMap<PerroDto, Perros>();//alta
            CreateMap<Perros, PerroDto>();
        }
    }
}
