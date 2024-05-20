using Entities.DTOs.DoktorHastaListeDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        public static readonly string HastaAdded = "Hasta Eklendi";
        public static readonly string HastaUpdated = "Hasta Güncellendi";
        public static readonly string HastaListed = "Hasta listelendi";
        public static readonly string MaintenanceTime = "Sistem bakımda";
        public static readonly string ProductsListed = "Ürünler listelendi";
        public static readonly string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static readonly string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static readonly string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static readonly string AuthorizationDenied = "Yetkiniz yok.";
        public static readonly string UserRegistered = "Kullanıcı kayıt oldu";
        public static readonly string UserNotFound = "Kullanıcı bulunamadı";
        public static readonly string PasswordError = "Şifre hatalı";
        public static readonly string SuccessfulLogin = "Başarılı giriş";
        public static readonly string UserAlreadyExists = "Kullanıcı mevcut";
        public static readonly string AccessTokenCreated = "Access token oluşturuldu";
        public static readonly string IlacAdded = "İlaç eklendi";
        public static readonly string IlacDeleted = "İlaç silindi";
        public static readonly string IlacListed = "İlaçlar listelendi";
        public static readonly string IlacUpdated = "İlaç güncellendi";
        public static readonly string PersonelAdded = "Personel eklendi";
        public static readonly string PersonelListed = "Personel listelendi";
        public static readonly string PersonelDeleted = "Personel silindi";
        public static readonly string PersonelUpdated = "Personel güncellendi";
        public static readonly string PersonelNotFound = "Personel bulunamadı";
        public static readonly string PersonelFound = "Personel bulundu";
        public static readonly string PersonelNameIsNotEmpty = "Personel adı boş olamaz";
        public static readonly string HastaAdIsNotEmpty = "Hasta adı boş olamaz";
        public static readonly string KullaniciUpdated = "Kullanıcı güncellendi";
        public static readonly string KullaniciListed = "Kullanıcılar listelendi";
        public static readonly string KullaniciDeleted = "Kullanıcı silindi";
        public static readonly string KullaniciAdded = "Kullanıcı eklendi";
        public static readonly string KullaniciNotFound = "Kullanici bulunamadı";
        public static readonly string KullaniciIsTooShort = "Kullanıcı adı boş geçilemez";
        public static readonly string KullaniciPasswordNotNull = "Paralo boş geçilemez";
        public static readonly string DoktorNotFound = "Doktor Bulunamadı";
        public static readonly string HastaNotFound = "Hasta bulunamadı";
        public static readonly string HastalikNotAdded = "Hastalık eklenemedi";
        public static readonly string HastalikAdded = "Hastalık eklendi";
        public static readonly string HastalikNotDeleted = "Hastalık silinemedi";
        public static readonly string HastalikNotUpdated = "Hastalık güncellenemedi";
        public static readonly string HastalikUpdated = "Hastalık güncellendi";
        public static readonly string HastalikFound = "Hastalık bulundu";
        public static readonly string HastalikNotFound = "Hastalık bulunamadı";
        public static readonly string HastalikListed = "Hastalıklar listelendi";
        public static readonly string HastalikDeleted = "Hastalık silindi";
        public static readonly string TetkikAdded = "Tetkik eklendi";
        public static readonly string TetkikNotFound = "Tetkik bulunamadı";
        public static readonly string TetkikListed = "Tetkikler listelendi";
        public static readonly string TetkikDeleted = "Tetkik silindi";
        public static readonly string TetkikFound = "Tetkik bulundu";
        public static readonly string TetkikUpdated = "Tetkik güncellendi";
        public static readonly string ResimYolNotFound = "Resim yolu bulunamadı";
    }
}
