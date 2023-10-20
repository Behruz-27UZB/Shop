using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class AddInfo
    {
        public void AddProduct(string nameProduct, int priceProduct, int amountProduct)
        {
            string path = $"{nameProduct}.txt";
            bool res = File.Exists(path);
            if (!res)
            {
                File.AppendAllText(path, nameProduct + "\n" + priceProduct + "\n" + amountProduct + "\n");
                File.AppendAllText("Umumiy.txt", nameProduct + "\n" + priceProduct + "\n" + amountProduct + "\n");
            }
            else if (res)
            {
                string[] malumot = File.ReadAllLines(path);
                if (malumot[0] == nameProduct)
                {
                    int narxi = Convert.ToInt32(malumot[1]);
                    int miqdor = Convert.ToInt32(malumot[2]);
                    malumot[1] = narxi.ToString();
                    malumot[2] = narxi.ToString();
                }
                File.Delete(path);
                foreach (var item in malumot)
                {
                    File.AppendAllText(path, item + "\n");
                }
                string[] malumot1 = File.ReadAllLines("Umumiy.txt");
                for (int i = 0; i < malumot1.Length; i += 3)
                {
                    if (malumot1[i] == nameProduct)
                    {
                        int narxi = Convert.ToInt32(malumot1[i + 1]);
                        int miqdor = Convert.ToInt32(malumot1[i + 1]);
                        narxi += priceProduct;
                        miqdor += amountProduct;
                        malumot1[i + 1] = narxi.ToString();
                        malumot1[i + 2] = miqdor.ToString();

                    }
                }
                File.Delete("Umumiy.txt");
                foreach (var item in malumot1)
                {
                    File.AppendAllText(path, item + "\n");
                }

            }
        }
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
