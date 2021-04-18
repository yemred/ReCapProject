using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded="Araba Başarıyla Eklendi";
        public static string CarCountOfBrandError="Bir Markada En Fazla 10 Araba Olabilir";
        public static string CheckCarNameExist = "Sistemde Aynı İsimde Araba Mevcut";
        public static string BrandLimitExceded ="Toplam Marka Sayısı 10 dan Fazladır";
        public static string AuthorizationDenied="Giriş Yetkiniz Yok";
        public static string UserRegistered="Kayıt Olundu";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Parola Hatası";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string SuccessLogin="Başarılı Giriş";
  
    }
}
