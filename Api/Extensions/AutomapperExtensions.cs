using Api.Profiles;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Extensions
{
    public static class AutomapperExtensions
    {
        public static void ConfigureAutomapper(this IServiceCollection services)
        {
            // Auto Mapper Configurations
            /*Si llegase a pasar la siguiente excepcion:
             * exception: "Collection was modified; enumeration operation may not execute."
             * Hay dos posibilidades: 
             * 1) Está mal hecho el mapeo de dto a entidad o viseversa.
             * 2) Se cambio el orden de los AddProfile, se ve que cada uno tiene un enum al crearse
             * y depende de otro, por eso falla, conclusion, no ordenar alfabeticamente
             */

            services.AddSingleton(provider => new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PerroProfile());
               
            }).CreateMapper());

        }

    }
}
