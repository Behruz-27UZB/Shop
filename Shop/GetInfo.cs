using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class GetInfo
    {

        public void ProductOlish(string nameProduct)
        {
            string path = $"{nameProduct}.txt";
            bool res = File.Exists(path);
            if (res)
            {
                bool tekshir = false;
                string[] malumot = File.ReadAllLines(path);

                for (int i = 0; i < malumot.Length; i++)
                {
                    if (malumot[i] == nameProduct)
                    {
                        tekshir = true;
                        System.Console.WriteLine($"Nomi: {malumot[i]}\n" +
                                                $"Narhi: {malumot[i + 1]}\n" +
                                                $"Miqdori: {malumot[i + 2]}");


                    }
                }
                if (tekshir == false)
                {
                    System.Console.WriteLine("Bu Dori mavjud emas");
                }

            }
            else
            {
                System.Console.WriteLine("Bu malumot mavjud emas");
            }
        }
    }

}
