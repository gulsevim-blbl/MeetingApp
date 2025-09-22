using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad Soyad alanı gereklidir.")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon alanı gereklidir.")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Email alanı gereklidir."), EmailAddress(ErrorMessage ="Geçerli bir email adresi giriniz.")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Lütfen katılım durumunuzu seçiniz.")]
        public bool? WillAttend { get; set; }
        
    }
}