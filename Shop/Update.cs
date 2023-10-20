using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Update
    {
        public void UpdateProduct(string nameProduct)
        {

            string path = "Meva.txt";

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
                        System.Console.Write("name: ");
                        malumot[i] = Console.ReadLine();
                        System.Console.Write("narxi:");
                        malumot[i + 1] = Console.ReadLine();

                    }

                }

                File.Delete(path);
                File.AppendAllLines(path, malumot);

            }
            else
            {
                System.Console.WriteLine("bu malumot mavjud emas");

            }

        }

    }
}
