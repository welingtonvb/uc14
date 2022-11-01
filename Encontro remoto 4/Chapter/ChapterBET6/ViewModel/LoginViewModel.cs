using System.ComponentModel.DataAnnotations;

namespace ChapterBET6.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "E-mail requerido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha requerida!")]
        public string Senha { get; set; }
    }
}
