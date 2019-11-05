using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Defeito
    {
        public int DefeitoId { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Informe a data")]
        [Display(Name = "Data do defeito")]
        public DateTime DataDefeito { get; set; }
        [Required(ErrorMessage = "Informe a observação")]
        public string Observacao { get; set; }
        [Required(ErrorMessage = "Informe o tipo do defeito")]
        [Display(Name = "Tipo do defeito")]
        public int? TipoDefeitoId { get; set; }
        [Required(ErrorMessage = "Informe o Equipamento")]
        [Display(Name = "Tipo do Equipamento")]
        public int? EquipamentoId { get; set; }

        [Display(Name = "Tipo do Equipamento")]
        public Equipamento Equipamento { get; set; }
        [Display(Name = "Tipo do defeito")]
        public TipoDefeito TipoDefeito { get; set; }
    }
}
