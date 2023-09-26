//Agus
//Asinkron 3

using System;

namespace PermainanAdudu
{
    class Program
    {
        static void Main(string[] args)
        {
    
            int lemparan_dadu_1 = 6;
            int lemparan_dadu_2 = 6;
            int lemparan_dadu_3 = 6;
            int lemparan_dadu_4 = 6;

            int poin_dadu_1_2 = lemparan_dadu_1 + lemparan_dadu_2;
            int poin_dadu_3_4 = lemparan_dadu_3 + lemparan_dadu_4;

            int bonus_1_2 = 0;
            int bonus_3_4 = 0;

            if (poin_dadu_1_2 == 12)
            {
                bonus_1_2 = 2;
            }
            if (poin_dadu_3_4 == 12)
            {
                bonus_3_4 = 2;
            }
            if (Math.Abs(lemparan_dadu_1 - lemparan_dadu_3) == 2)
            {
                bonus_1_2 += 0;
            }
            if ((lemparan_dadu_2 + lemparan_dadu_4) % 6 == 0)
            {
                bonus_3_4 += 0;
            }

            int total_poin = poin_dadu_1_2 + poin_dadu_3_4 + bonus_1_2;

            Console.WriteLine("Lemparan dadu 1 : " + lemparan_dadu_1);
            Console.WriteLine("Lemparan dadu 2 : " + lemparan_dadu_2);
            Console.WriteLine("Lemparan dadu 3 : " + lemparan_dadu_3);
            Console.WriteLine("Lemparan dadu 4 : " + lemparan_dadu_4);
            Console.WriteLine("\nJumlah poin yang didapat : " + total_poin);
            Console.WriteLine($"{poin_dadu_1_2} poin dari lemparan dadu 1 dan 2");
            if (bonus_1_2 > 0)
            {
                Console.WriteLine($"{bonus_1_2} poin dari bonus lemparan dadu 1 dan 2");
            }
            Console.WriteLine($"{poin_dadu_3_4} poin dari lemparan dadu 3 dan 4");
            if (bonus_3_4 > 0)
            {
                Console.WriteLine($"{bonus_3_4} poin dari bonus lemparan dadu 3 dan 4");
            }

            Console.ReadLine();
        }
    }
}