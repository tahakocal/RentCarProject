using Core.Entities.Concrete;
using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string LenghtNotEnough = "Isim uzunlugu yeterli degil";

        //Car
        public static string CarAdded = "Arac Eklendi";
        public static string CarUpdated = "Id`li Arac Guncellendi";
        public static string CarNotUpdated = "Id`li Arac Guncellenemedi !!";
        public static string CarDeleted = "Id`li Arac silindi";
        public static string CarNotDeleted = "Id`li Arac silinemedi !!";
        public static string CarListed = "Araclar Listelendi !!";
        public static string MaintenanceTime = "Bakim saati !!!";

        //Brand
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandUpdated = "Marka Guncellendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandListed = "Markalar Listelendi";
        //Color
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorUpdated = "Renk Guncellendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorListed = "Renkler Listelendi";

        //User
        public static string UserAdded = "Kullanici Eklendi";
        public static string UserUpdated = "Kullanici Guncellendi";
        public static string UserDeleted = "Kullanici Silindi";
        public static string UserListed = "Kullanicilar Listelendi";

        //Rental
        public static string RentalAdded = "Kiralik Arac Eklendi";
        public static string RentalUpdated = "Kiralik Arac Guncellendi";
        public static string RentalDeleted = "Kiralik Arac Silindi";
        public static string RentalListed = "Kiralik Araclar Listelendi";

        //Customer
        public static string CustomerAdded = "Musteri Eklendi";
        public static string CustomerUpdated = "Musteri Guncellendi";
        public static string CustomerDeleted = "Musteri Silindi";
        public static string CustomerListed = "Musteriler Listelendi";

        //CarImage
        public static string CarImageAdded = "Araba Resmi Eklendi";
        public static string CarImageDeleted = "Araba Resmi Silindi.";
        public static string CarImageUpdated = "Araba Resmi Guncellendi.";
        public static string CarImagesListed = "Araba Resimleri Listelendi.";
        public static string CarImageListedById = "Araba Resimleri Idye gore Listelendi.";

        public static string AuthorizationDenied = "Giris Rededildi";

        public static string TokenCreated = "Token Olusturuldu !!";
        public static string UserNotFound = "Kullanici Bulunamadi !!";
        public static string WrongPassword = "Yanlis Sifre";
        public static string SuccessfulLogin = "Giris Basarili";
        public static string Registered = "Kayit olundu.";
        public static string UserAvailable = "Kullanici zaten mevcut";

        public static string GetErrorUserMessage = "Üye bilgisi / bilgileri getirilemedi.";
        public static string GetSuccessUserMessage = "Üye bilgisi / bilgileri getirildi.";
    }
}
