using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class TipoDefeito
    {
        public TipoDefeito()
        {
            Defeito = new HashSet<Defeito>();
        }

        public int TipoDefeitoId { get; set; }
        public string Titulo { get; set; }

        public ICollection<Defeito> Defeito { get; set; }
    }
}
