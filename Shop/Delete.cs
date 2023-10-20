using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Delete
    {
     public void DeleteAllProducts()
     {
            string path = "Umumiy.txt";
            bool res = File.Exists(path);

            if (res)
            {
                System.Console.WriteLine("Uchirildi");

            }
            else
            {
                System.Console.WriteLine("bu malumot mavjud emas");
            }





     }
        public void OneDeletaProduct(string nameProduct)
        {
            string path = $"{nameProduct}.txt";
            bool res = File.Exists(path);
            if(res == true)
            {
                File.Delete(path);
                string[] malumot = File.ReadAllLines("Umumiy.txt");
                for(int i = 0; i < malumot.Length; i += 3)
                {
                    if (malumot[i] == nameProduct)
                    {
                        malumot[i] = malumot[i].Remove(0);
                        malumot[i + 1] = malumot[i + 1].Remove(0);
                        malumot[i + 2] = malumot[i + 2].Remove(0); 
                    }
                }
                File.Delete("Umumiy.txt");
                foreach(var item in malumot)
                {
                    File.AppendAllText("Umumiy.txt", item + "\n");
                }
            }
            else
            {
                Console.WriteLine("Bu malumot mavjud emas");
            }

        }

    }
}
