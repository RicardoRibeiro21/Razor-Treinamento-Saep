using System;
using System.Collections.Generic;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Equipamento
    {
        public Equipamento()
        {
            Defeito = new HashSet<Defeito>();
        }

        public int EquipamentoId { get; set; }
        public string Nome { get; set; }

        public ICollection<Defeito> Defeito { get; set; }
    }
}
