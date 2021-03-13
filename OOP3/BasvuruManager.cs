using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection 
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme
            //////////

            krediManager.Hesapla();
            loggerService.Log(); //hangi servis seçilmişse onu logla komutu
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager>krediler) //birden fazla kredi tipi seçeceğimiz zaman

        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();  //listedeki her bir kredinin hesaplamasını yapma komutu 
            }
        }
    }
}
