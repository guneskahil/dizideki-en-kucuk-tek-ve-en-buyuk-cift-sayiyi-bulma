using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev9agrubu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elemansayisi = 14;
            int[] dizi = new int[elemansayisi];
            rastgele(elemansayisi, dizi);
            Console.WriteLine("Dizinin elemanları");
            int x = 0;
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
                x += 1;
            }
            int tekrar = 0;
            int çiftbüyük = 0;
            int teksayibul = 0;
            int tekküçük;
            do
            {
                if (dizi[teksayibul] % 2 == 1)
                {
                    tekküçük = dizi[teksayibul];
                    break;
                }
                teksayibul++;
            } while (true);
            do
            {
                if (dizi[tekrar] % 2 == 0)
                {
                    if (dizi[tekrar] > çiftbüyük)
                    {
                        çiftbüyük = dizi[tekrar];
                    }
                }
                else
                {
                    if (dizi[tekrar] < tekküçük)
                    {
                        tekküçük = dizi[tekrar];
                    }
                }
                tekrar += 1;
            } while (tekrar < elemansayisi);
            Console.WriteLine();
            Console.Write("En büyük çift sayı:");
            Console.WriteLine(çiftbüyük);
            Console.Write("En küçük tek sayı:");
            Console.WriteLine(tekküçük);
            Console.ReadLine();
        }
        static void rastgele(int elemansayisi, int[] dizi)
        {
            Random r = new Random();
            int x = 0;
            while (x < elemansayisi)
            {
                dizi[x] = r.Next(100) + 2;
                x++;
            }
        }
    }
}

