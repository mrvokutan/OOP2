using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();            
            IKrediManager tasitKrediManager = new TasitKrediManager();          
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseloggerService = new DataBaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

             
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseloggerService); //buraya ne yazarsan onu hesaplar

            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
