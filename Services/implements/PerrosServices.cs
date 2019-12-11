using Dominio.contracts;
using Dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Services.contracts;

namespace Services.implements
{
    public class PerrosServices:IPerrosService
    {

        public readonly bdVeterinariaContext bdVeterinariaContext;
        public readonly IRepository<Perros> repository;
        public PerrosServices(IRepository<Perros> repository) {
            this.repository = repository;
        }


        public async void Create(Perros perros)
        {
            this.repository.Add(perros);
            this.repository.Save();
        }

        public async Task<List<Perros>> listado()
        {
            return this.repository.GetAll().ToList();
        }
    }
}
