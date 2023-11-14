using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class EsnafKrediManager : ICreditBaseManager
    {
        void ICreditBaseManager.BiseyYap()
        {
            throw new NotImplementedException();
        }

        void ICreditBaseManager.Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }
    }
}
