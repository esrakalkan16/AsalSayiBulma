using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            //asal sayı bulma programı
            int sayi;

            Console.Write("{0}\n-> Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi > 0)
            {
                for (int i = 2; i < sayi; i++)
                {
                    if(sayi%i== 0)
                    {
                        Console.WriteLine("Sayı asal sayıdeğildir.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sayı asal sayıdır.");
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("0 ve negatif sayılarda asal sayı aranmaz!");
            }
            Console.ReadLine();
        }
    }
}
