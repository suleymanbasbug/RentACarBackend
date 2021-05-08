using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarPriceInvalid = "Geçersiz Tutar";
        public static string CarDeleted = "Araç silindi";
        public static string CarUpdated = "Araç bilgileri güncellendi";
        public static string CarsListed = "Araçlar listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ColorNameInvalid = "Geçersiz renk ismi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted="Renk silindi";
        public static string ColorUpdated="Renk güncellendi";
        public static string BrandAdded="Marka eklendi";
        public static string BrandNameInvalid="Geçersiz marka ismi";
        public static string BrandDeleted="Marka silindi";
        public static string BrandUpdated="Marka güncellendi";
        public static string BrandListed="Markalar Listelendi";
        public static string ColorListed="Renkler Listelendi";
        public static string ImageCount = "Bir aracın en fazla 5 resim olabilir";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Bu kullanıcı mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";
    }
}
