using System;
using System.Collections.Generic;

namespace Dominio.entidades
{
    public partial class Gatos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? CantidadDientes { get; set; }
    }
}
