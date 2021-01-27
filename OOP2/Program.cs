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
            musteri1.Adi = "Ensar";
            musteri1.Soyadi = "KILIC";
            musteri1.TcNo = "1234567890";

            //Kodlama.io 
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";




            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Ensar";
            //musteri1.Soyadi = "KILIC";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "?";


            //Gerçek müşteri -Tüzel müşteri -- bunlar birbirinin yerine asla kullanılamaz
            // SOLID in L si ile ilgii bu kural- yazılım da SOLID
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);

        }
    }
}
