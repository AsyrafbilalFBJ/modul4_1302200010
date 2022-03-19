using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302200010
{
    class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T A1, T A2, T A3)
        {
            dynamic a1 = A1;
            dynamic a2 = A2;
            dynamic a3 = A3;
            Console.WriteLine(a1 + a2 + a3);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<long>(13, 02, 20);
            Console.ReadKey();
        }
    }
}
