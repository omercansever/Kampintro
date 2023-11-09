using System;

namespace Kampintro
{
     class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği

            string kategoriEtiketi = "kategoriEtiketi";
            int ogrSayisi = 32000;
            double faizOrani = 1.50; 
            bool sistemeGirisYApmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonunu Göster");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYApmisMi == true)
            {
                Console.WriteLine("Tebrikler Başarıyla Giriş Yaptınız");
            }
            else
            {
                Console.WriteLine("Lütfen Giriş Yapınız");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}