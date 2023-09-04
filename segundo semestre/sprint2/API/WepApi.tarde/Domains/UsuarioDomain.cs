using System.ComponentModel.DataAnnotations;

namespace WepApi.tarde.Domains
{/// <summary>
/// classe que representa a entidade usuario
/// </summary>
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }

        [Required (ErrorMessage = "O E-mail e obrigatorio")]
        public string Email { get; set; }

        [StringLength(20, MinimumLength =3, ErrorMessage = "A senha deve ter entre 3 e 20 caracteres")]
        [Required(ErrorMessage = "a senha deve ter entre 3 e 20 caracteres")]
        public string Senha { get; set; }

        public string Permissao { get; set; }
    }
}
