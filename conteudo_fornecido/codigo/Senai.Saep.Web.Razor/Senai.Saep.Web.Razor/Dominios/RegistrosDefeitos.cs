using System;
using System.ComponentModel.DataAnnotations;

namespace Senai.Saep.Web.Razor.Dominios
{
    public partial class RegistrosDefeitos
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data do Defeito")]
        [Required]
        public DateTime DataDefeito { get; set; }

        [Display(Name = "Tipo de Equipamento")]
        public int TipoEquipamentoId { get; set; }
        [Display(Name = "Tipo de Defeito")]
        public int TipoDefeitoId { get; set; }
        public string Observacao { get; set; }

        [Display(Name = "Tipo de Defeito")]
        public virtual TiposDefeitos TipoDefeito { get; set; }
        [Display(Name = "Tipo de Equipamento")]
        public virtual TiposEquipamentos TipoEquipamento { get; set; }
    }
}
