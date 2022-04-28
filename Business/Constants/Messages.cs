using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string JobListAdded = "Meslek Eklendi";
        public static string JobListNameInvalid = "Meslek İsmi Geçersiz";
        public static string JobListListed = "Meslekler Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda. Daha sonra tekrar deneyin";
        public static string CandidateListed = "Adaylar Listelendi";
        public static string CandidateAdded = "Aday Sisteme Eklendi";
        public static string CandidateDeleted = "Aday Sistemden Çıkarıldı";
        public static string JobListAllreadyExists = "Meslek Sistemde Mevcut";
        public static string AuthorizationDenied = "İşlem Yapmaya Yetkiniz Yok";
        public static string UserRegistered = "Kullanıcı Kayıt Oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Paralo Hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
