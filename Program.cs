using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 8;
            musteri.isim = "Begüm";
            musteri.soyisim = "Özdemir";
            musteri.cinsiyet = "Kadın";
            musteri.yas = 21;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 10;
            musteri2.isim = "Ogün";
            musteri2.soyisim = "Özdemir";
            musteri2.cinsiyet = "Erkek";
            musteri2.yas = 29;

            Musteri[] musteriler = new Musteri[] { musteri, musteri2 };
            foreach (Musteri i in musteriler)
            {
                Console.WriteLine("Müşteri ID           : {0} ", i.Id);
                Console.WriteLine("Müşterinin İsmi      : {0} ", i.isim);
                Console.WriteLine("Müşterinin Soyismi   : {0} ", i.soyisim);
                Console.WriteLine("Müşterinin Yaşı      : {0} ", i.yas);
                Console.WriteLine("Müşterinin Cinsiyeti : {0} ", i.cinsiyet);
                Console.WriteLine();
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                Console.WriteLine("Müşteri ID           : {0} ", musteri2.Id);
                Console.WriteLine("Müşterinin İsmi      : {0} ", musteri2.isim);
                Console.WriteLine("Müşterinin Soyismi   : {0} ", musteri2.soyisim);
                Console.WriteLine("Müşterinin Yaşı      : {0} ", musteri2.yas);
                Console.WriteLine("Müşterinin Cinsiyeti : {0} ", musteri2.cinsiyet);
               

            }
            Console.WriteLine();
            Console.WriteLine("--------METOTLAR--------");
            Console.WriteLine();

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri);
            Console.WriteLine();
            musterimanager.Ekle(musteri2);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine();
            musterimanager.Listele(musteri);
            Console.WriteLine();
            musterimanager.Listele(musteri2);
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine();
            musterimanager.Sil(musteri);
            Console.WriteLine();
            musterimanager.Sil(musteri2);

            Console.ReadLine();
        }
    }
}
