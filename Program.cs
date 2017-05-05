using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] eskinazlar = new int[] { 500,100, 50, 20, 10, 5,1 };
            Console.Write("Miqdari daxil edin : ");
            int x = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < eskinazlar.Length; i++)
                {
                    if (x >= eskinazlar[i])
                    {
                        int eskinaz_sayi = x / eskinazlar[i];
                        int qaliq_mebleg = x - eskinazlar[i] * eskinaz_sayi;
                        Console.WriteLine("{0} eded {1}AZN", eskinaz_sayi, eskinazlar[i]);
                         x = qaliq_mebleg;
                    }
                }
                Console.ReadLine();
        }
    }
    }

