namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Değer tipler
            int sayi1 = 10;
            int sayi2 = 30; 
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //Referans tipler
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 3000 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 olur 
        }
    }
}