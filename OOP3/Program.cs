using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditBaseManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            ICreditBaseManager tasitKrediManager = new TasitKrediManager();
            ICreditBaseManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyacKrediManager);

            List<ICreditBaseManager> krediler = new List<ICreditBaseManager>() {ıhtiyacKrediManager, tasitKrediManager, konutKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}