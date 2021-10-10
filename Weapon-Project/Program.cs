using System;

namespace AvtomatProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon silah = new Weapon();
            string start;
            Console.WriteLine("        Avtomat Simulyasiyasi");
            Console.WriteLine("********************************************");
            Console.WriteLine("1-Atish   2-Magazin Deyish     3-Magazin Doldur");
            Console.WriteLine("Bashlamaq ucun 1-e basin.");
            start = Console.ReadLine();
            Console.Clear();
            while (silah.gulle >= 1)
            {
                if (start == "1")
                {
                    Console.WriteLine("Atish novu daxil edin: Tek-tek atmaq ucun 't', avtomatik atmaq ucun 'a' yazin.");
                    silah.Bashla(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Gulle sayi:{silah.gulle}");
                    if (silah.gulle == 0)
                    {
                        Console.WriteLine("Gulle bitti.");
                        Console.WriteLine("Magazini deyismek ucun 2-e basin.");
                        silah.Bashla(Console.ReadLine());
                    }
                    else if (silah.gulle >= 30)
                    {
                        Console.WriteLine("Magazin tam doldu.Yeniden baslamaq ucun herhansi bir klavise basin. ");
                        silah.Bashla(Console.ReadLine());
                        Console.Clear();
                    }
                }
            }
        }
    }
}

