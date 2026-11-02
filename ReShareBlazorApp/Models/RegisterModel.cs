using System.ComponentModel.DataAnnotations;

namespace ReShareBlazorApp.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Podaj nazwe użytkownika.")]
        [MinLength(8, ErrorMessage = "Nazwa urzytkownika musi mieć minimum 8 znaków.")]
        [MaxLength(24, ErrorMessage = "Nazwa urzytkownika musi mieć maksimum 24 znaków.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Podaj adress E-mail.")]
        [EmailAddress(ErrorMessage = "Nieprawidłowy adress E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj hasło.")]
        [MinLength(8,ErrorMessage = "Hasło musi mieć minimum 8 znaków.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdź hasło.")]
        [Compare(nameof(Password), ErrorMessage = "Hasła muszą być identyczne.")]
        public string ConfirmPassword { get; set; }

        [Range(typeof(bool), "true", "true", ErrorMessage = "Musisz zaakceptować regulamin.")]
        public bool AcceptTerms { get; set; }
    }
}
