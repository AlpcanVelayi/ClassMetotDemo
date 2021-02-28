using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Sepete Eklendi"+" "+ musteri.Id +" "+ musteri.Adi +" "+ musteri.Soyadi +" "+ musteri.Yasi +" "+ musteri.TcKimlikNo);
        }
        public void Listeleme(Musteri [] musteriler) 
        {
            Console.WriteLine("İstenen müşteriler aşağıda listelenmiştir :" );
            foreach (Musteri musteri in musteriler )
            {
                Console.WriteLine($"Adı : " + musteri.Adi + "\n" + "Soyadı : " + musteri.Soyadi + "\n" + "Yaşı : " + musteri.Yasi + "\n" + "Tc Kimlik Numarası : " + musteri.TcKimlikNo);
            }
        }
        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Seçtiğiniz müşteri silindi " + musteri.Id);
        }
    }
}
