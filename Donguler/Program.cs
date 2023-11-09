namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array-Dizi

            string[] kurslar = new string[] {
                "Yazılım geliştirici Yetiştirme Kapmı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java",
                "C#",
                "C++"
            };
             
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitiş");

            foreach(string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");
        }
    }
}