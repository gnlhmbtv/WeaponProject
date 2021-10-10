using System;
using System.Collections.Generic;
using System.Text;

namespace AvtomatProject
{
    class Weapon
    {
        public int gulle { get; private set; }
        public Weapon()
        {
            gulle = 30;
        }
        public int Bashla(string atishNovu)
        {
            if (atishNovu == "t")
            {
                gulle--;
            }
            else if (atishNovu == "a")
            {
                gulle = 0;
            }
            else if (atishNovu == "2")
            {
                MagazinDeyish();
            }
            else if (atishNovu == "3" && gulle < 30)
            {
                MagazinDoldur();
            }
            return gulle;
        }
        public void MagazinDeyish()
        {
            gulle = 30;
            Console.WriteLine($"Gulle sayi:{gulle}");
        }

        public int MagazinDoldur()
        {
            gulle++;
            return gulle;
        }
    }
}
