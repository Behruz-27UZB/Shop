using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Find
    {
        public void FindProduct(string nameProduct)
        {
            string path = $"{nameProduct}.txt";
            bool res = File.Exists(path);
            if (res)
            {
                string[] malumotlar = File.ReadAllLines(path);
                for (int i = 0; i <= malumotlar.Length; i+=3)
                {
                    if (malumotlar[i] == nameProduct)
                    {
                        System.Console.WriteLine("nomi: " + malumotlar[i]);
                        System.Console.WriteLine("narxi: " + malumotlar[i + 1]);
                        System.Console.WriteLine("miqdori: " + malumotlar[i + 2]);
                    }
                }
            }
        }
    }
}
