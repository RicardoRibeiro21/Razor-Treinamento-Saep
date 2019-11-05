using System;
using System.Collections.Generic;

namespace Senai.Saep.Web.Razor.Dominios
{
    public partial class TiposEquipamentos
    {
        public TiposEquipamentos()
        {
            Equipamentos = new HashSet<Equipamentos>();
            RegistrosDefeitos = new HashSet<RegistrosDefeitos>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Equipamentos> Equipamentos { get; set; }
        public virtual ICollection<RegistrosDefeitos> RegistrosDefeitos { get; set; }
    }
}
