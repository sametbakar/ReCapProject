using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme başarılı";
        public static string Deleted = "Silme başarılı";
        public static string Updated = "Güncelleme başarılı";
        public static string Listed = "Listeleme başarılı";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarNameInvalid = "Araç ismi en az 2 karakter olmalıdır";
        public static string CarListed = "Araçlar listelendi";

        public static string RentalNotDelivered = "İade edilmemiş araç olduğundan işlem gerçekleştirilemedi";
        public static string RentalAdded = "Araç kiralama işlemi başarılı";



        public static string CarImageAdded = "Araç görseli eklendi";
        public static string CarImageUpdated = "Araç görseli güncellendi";
        public static string CarImageDeleted = "Araç görseli silindi";
        public static string CarImageListed = "Araçlar listelendi";
        public static string CarImageLimitExceeded = "Bir araç için eklenebilecek görsel sayısı aşıldığı için ekleme başarısız";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı kaydoldu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Hatalı şifre";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string AccessTokenCreated="Token oluşturuldu";

        public static string UserAlreadyExists = "Kullanıcı mevcut";
    }
}
