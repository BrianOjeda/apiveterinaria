using Dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.contracts
{
    public interface IPerrosService
    {
        void Create(Perros perro);
        Task<List<Perros>> listado();
    }
}
