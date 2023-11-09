using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        //Naming Convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi);
        }
    }
}
