using System.ComponentModel.DataAnnotations;

namespace Senai.Saep.Web.Razor.Dominios
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Informe o email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Informe um e-mail válido")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
