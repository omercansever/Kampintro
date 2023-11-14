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
            ICreditBaseManager esnafKrediManager = new EsnafKrediManager();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);

            List<ICreditBaseManager> krediler = new List<ICreditBaseManager>() {ıhtiyacKrediManager, tasitKrediManager, konutKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}