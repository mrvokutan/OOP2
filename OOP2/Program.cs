using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "merve";
            musteri1.Soyadi = "okutan";
            musteri1.TcNo = "12345678946";





            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";




            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            



            
            
            
            
           
            
            
            
            
            
            
            
            
            
            
            
            
            
            //şirket adı olamaz kişi ismi
            // gerçek - tüzel birbirine benziyor diye birbirlerinin yerine kullanılamaz. Farklı müşteri tipleridir
         
            
        
              
        }
    }
}
