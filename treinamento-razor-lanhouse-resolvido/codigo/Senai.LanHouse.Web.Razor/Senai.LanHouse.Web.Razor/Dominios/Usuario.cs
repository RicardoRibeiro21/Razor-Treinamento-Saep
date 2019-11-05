using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Senai.LanHouse.Web.Razor.Dominios
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Informe o seu email")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Informe a sua senha")]
        public string Senha { get; set; }
    }
}
