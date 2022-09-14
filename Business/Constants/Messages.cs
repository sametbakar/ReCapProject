using System;
using System.Collections.Generic;
using System.Linq;
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
        public static string CarAdded = "Araç eklendi";
        public static string CarDeleted= "Araç silindi";
        public static string CarUpdated = "Araç güncellendi";
        public static string CarNameInvalid = "Araç ismi en az 2 karakter olmalıdır";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araçlar listelendi";

        public static string RentalNotDelivered = "İade edilmemiş araç olduğundan işlem gerçekleştirilemedi";
        public static string RentalAdded = "Araç kiralama işlemi başarılı";
    }
}
