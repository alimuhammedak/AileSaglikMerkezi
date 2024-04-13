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
        internal static readonly string PersonelNotFound = "Personel bulunamadı";
        internal static readonly string PersonelFound = "Personel bulundu";
        internal static readonly string PersonelNameIsNotEmpty = "Personel adı boş olamaz";
        internal static readonly string HastaAdIsNotEmpty = "Hasta adı boş olamaz";
    }
}
