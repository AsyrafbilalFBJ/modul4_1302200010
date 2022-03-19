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
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }
        public void AddNewData(T dataBaru, DateTime dataDate)
        {
            storedData.Add(dataBaru);
            inputDates.Add(dataDate);
        }
        public void PrintAllData()
        {
            int i = 0;
            foreach (T Data in storedData)
            {
                Console.Write(Data +" ");
                Console.WriteLine(inputDates[i]);
                i++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<long>(13, 02, 20);
            SimpleDataBase<int> objData = new SimpleDataBase<int>();
            objData.AddNewData(12, DateTime.Now);
            objData.AddNewData(34, DateTime.Now);
            objData.AddNewData(56, DateTime.Now);
            objData.PrintAllData();
            Console.ReadKey();
        }
    }
}
