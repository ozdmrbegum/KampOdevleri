using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("***** Müşteri Ekle *****");
            Console.WriteLine("Müşteri ID               : {0} ",musteri.Id);
            Console.WriteLine("Müşterinin Adı ve Soyadı : {0}{1} ",musteri.isim,musteri.soyisim);
            Console.WriteLine("Müşterinin Yaşı          : {0} ",musteri.yas);
            Console.WriteLine("Müşterinin Cinsiyeti     : {0} ",musteri.cinsiyet);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("***** Müşteri Listeleme *****");
            Console.WriteLine("Müşteri ID               : {0} ", musteri.Id);
            Console.WriteLine("Müşterinin Adı ve Soyadı : {0}{1} ", musteri.isim, musteri.soyisim);
            Console.WriteLine("Müşterinin Yaşı          : {0} ", musteri.yas);
            Console.WriteLine("Müşterinin Cinsiyeti     : {0} ", musteri.cinsiyet);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("***** Müşteri Silme *****");
            Console.WriteLine("Müşteri ID               : {0} ", musteri.Id);
            Console.WriteLine("Müşterinin Adı ve Soyadı : {0}{1} ", musteri.isim, musteri.soyisim);
            Console.WriteLine("Müşterinin Yaşı          : {0} ", musteri.yas);
            Console.WriteLine("Müşterinin Cinsiyeti     : {0} ", musteri.cinsiyet);
        }
    }
}
