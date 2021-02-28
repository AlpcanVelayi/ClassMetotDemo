using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Alpcan";
            musteri2.Soyadi = "Velayi";
            musteri2.Yasi = 25;
            musteri2.TcKimlikNo = 32869765400;

            Musteri musteri1 = new Musteri();
            musteri1.Id = 3;
            musteri1.Adi = "Gözde";
            musteri1.Soyadi = "Doğuer";
            musteri1.Yasi = 25;
            musteri1.TcKimlikNo = 40255072612;

           

            Musteri[] musteriler = { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listeleme(musteriler);
           

            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
        }
    }
}
