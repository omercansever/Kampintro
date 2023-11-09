namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        Kurs kurs1 = new Kurs();
            kurs1.adi = "C#";
            kurs1.egitmen = "Ömercan Cansever";
            kurs1.ızlenme = 100;

            Kurs kurs2 = new Kurs();
            kurs2.adi = "C++";
            kurs2.egitmen = "Can Yoldaş";
            kurs2.ızlenme = 200;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.adi + " : " + kurs.egitmen);
            }
        }
           
    }

    class Kurs
    {
        public string adi { get; set; }
        public string egitmen { get; set; }
        public int ızlenme { get; set; }
    }

}