using System;
using System.Collections.Generic;

namespace Senai.Saep.Web.Razor.Dominios
{
    public partial class Equipamentos
    {
        public int Id { get; set; }
        public int TipoEquipamentoId { get; set; }
        public DateTime Data { get; set; }

        public virtual TiposEquipamentos TipoEquipamento { get; set; }
    }
}
