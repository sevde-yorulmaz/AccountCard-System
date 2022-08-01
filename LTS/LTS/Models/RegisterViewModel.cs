using EntityLayer.Concrete;
using System.ComponentModel.DataAnnotations;

namespace LTS.Models
{
    public class RegisterViewModel
    {
        [Display(Name = "Adınız")]
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        public string Name { get; set; }

        [Display(Name = "Soyadınız")]
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        public string SurName { get; set; }

        [Display(Name = "Telefon Numaranız")]
        [Required(ErrorMessage = "Lütfen Telefon Numarası Giriniz")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Telefon Numarası Tekrarı")]
        [Compare("PhoneNumber", ErrorMessage = "Telefon Numarası Aynı Değil")]
        public string PhoneNumberConfirm { get; set; }

        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrarı")]
        [Compare("Password", ErrorMessage = "Şifreler Aynı Değil")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Emailiniz")]
        [Required(ErrorMessage = "Lütfen Email Adresinizi Giriniz")]
        public string Email { get; set; }

        [Display(Name = "Kullanıcı Adınız")]
        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Giriniz")]
        public string UserName { get; set; }
    }
}
