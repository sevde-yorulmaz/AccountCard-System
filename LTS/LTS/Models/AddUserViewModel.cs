using System.ComponentModel.DataAnnotations;

namespace LTS.Models
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Lüften Ad  Giriniz")]
        public string name { get; set; }

        [Required(ErrorMessage = "Lüften Soyad  Giriniz")]
        public string surname { get; set; }

        [Required(ErrorMessage = "Lüften Kullanıcı Adı Giriniz")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lüften Mail Giriniz")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Lüften Telefon Giriniz")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Lüften Geçici Şifre Giriniz")]
        public string password { get; set; }

        
    }
}
