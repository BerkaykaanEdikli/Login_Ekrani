using System.ComponentModel.DataAnnotations;

namespace Login_Ekranı.Models
{
	public class LoginUyeModel
	{
		[Required(ErrorMessage = "Sevgili Eleman Adını Gir!")]
		[Display(Name = "Ad")]
		public string Ad { get; set; }

        [Required(ErrorMessage = "Sevgili Eleman Soyadını Gir!")]
        [Display(Name = "Soyad")]
		public string Soyad { get; set; }

        [Required(ErrorMessage = "Sevgili Eleman Kendine Kullanıcı Adı Oluşturmalısın")]
        [Display(Name = "Kullanıcı Adı")]
		[MinLength(6)]
		[MaxLength(12)]
		public string KullaniciAdi { get; set; }

        [Required(ErrorMessage = "Sevgili Eleman E-Posta Boş BIRAKILAMAZ!")]
        [EmailAddress(ErrorMessage = "Geçerli E-Posta Giriniz!!!")]
		[Display(Name = "E-Posta")]
		public string ePosta { get; set; }

        [Required(ErrorMessage = "Sevgili Eleman Doğum Tarihi Boş BIRAKILAMAZ!")]
        [DataType(DataType.Date)]
		[Display(Name = "Doğum Tarihi")]
		[Range(1920,2004)]
		public DateTime DogumTarihi { get; set; }

        [Required(ErrorMessage = "Sevgili Eleman Telefon Numarası Girmelisniz!")]
        [DataType(DataType.PhoneNumber)]
		[Display(Name = "Telefon Numarası")]
		public string Telefon { get; set; }

        [Required(ErrorMessage = "Sevgili Eleman URL'niz Boş BIRAKILAMAZ!")]
        [DataType(DataType.Url)]
		[Display(Name = "İnternet Adresi (URL)")]
		public string urlAdress { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Şifre")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Harf ve sayıdan oluşan 8 karakter giriniz.")]

        public string Sifre { get; set; }

		[DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Sifre",ErrorMessage = "Şifreler Aynı Değil !!!")]
        public string SifreTekrar { get; set; }
    }
}
