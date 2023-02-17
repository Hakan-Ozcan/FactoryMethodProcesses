using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodProcesses
{
    //Eğer Factory Method tasarım desenenini interface kullanarak uygulamak istiyorsanız, “Oyun” isimli abstract sınıfını interface’e çevirmeniz yeterlidir. Tabi bu çevrim sırasında interface kurallarını dikkate almalı ve oyunları interfaceden türetirken yapılacak implementte override komutu olmadan uygulama gerçekleştirilmelidir.


    interface IOyun
    {
        void Platform();
    }
    class Atarii : IOyun
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun ATARİ platformunda çalışmaktadır.");
        }
    }
    class PCC : IOyun
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
        }
    }
    class PSS : IOyun
    {
        public void Platform()
        {
            Console.WriteLine("Bu oyun PS platformunda çalışmaktadır.");
        }
    }
}
