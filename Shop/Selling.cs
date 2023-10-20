using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Selling
    {
        public void SotipOlish(string productName, int priductNarhi, int productSoni)
        {
            string path = $"{productName}.txt";
            bool res = File.Exists(path);
            if (res)
            {
                //Umumiy sotilgan mahsulotlar malumoti
                string path1 = "Bankomat.txt";
                bool res1 = File.Exists(path1);
                if (res1)
                {
                    string[] malumotNBU = File.ReadAllLines("Bankomat.txt");
                    bool tekshir2 = false;
                    for (int i = 0; i < malumotNBU.Length; i += 2)
                    {
                        if (malumotNBU[i] == productName)
                        {
                            tekshir2 = true;
                            int narhi = Convert.ToInt32(malumotNBU[i + 1]);
                            narhi += productSoni * priductNarhi;
                            malumotNBU[i + 1] = narhi.ToString();
                        }
                    }
                    if (tekshir2)
                    {
                        File.Delete(path1);
                        foreach (var item in malumotNBU)
                        {
                            File.AppendAllText(path1, item + "\n");

                        }

                    }

                }
                else
                {
                    File.AppendAllText(path1,productName);

                }

                //path dagi bitta mahsulotni sotadi
                string[] malumot = File.ReadAllLines(path);
                int miqdor = Convert.ToInt32(malumot[2]);
                miqdor -= productSoni;
                malumot[2] = miqdor.ToString();
                File.Delete(path);
                foreach (var item in malumot)
                {
                    File.AppendAllText(path, item + "\n");
                }

                //Umumiy.txt faile ichidan bitta mahsulotni sotadi

                string[] malumot1 = File.ReadAllLines("Umumiy.txt");
                bool tekshir1 = false;
                for (int i = 0; i < malumot1.Length; i += 3)
                {

                    if (malumot1[i] == productName)
                    {
                        int miqdori2 = Convert.ToInt32(malumot1[i + 1]);
                        int miqdori3 = Convert.ToInt32(malumot1[i + 2]);
                        if (miqdori3 > 0 && miqdori2 == priductNarhi)
                        {
                            tekshir1 = true;
                            miqdori3 -= productSoni;
                            malumot1[i + 2] = miqdori3.ToString();
                            System.Console.WriteLine("Do'konimizga yana kelip turing");
                            System.Console.WriteLine("Dori soni: " + miqdori3);

                        }

                    }
                    File.Delete("Umumiy.txt");
                    foreach (var item in malumot1)
                    {
                        File.AppendAllText("Umumiy.txt", item + "\n");
                    }
                }
                if (tekshir1 == false)
                {
                    System.Console.WriteLine("Bu Dori mavjid emas");
                }
            }
            else
            {
                Console.WriteLine("Baza mavjud emas");
            }


        }
    }
}
