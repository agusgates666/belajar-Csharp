using System;
using System.Collections.Generic;

// Agus
// Asinkron 4
class Program
{
    static void Main()
    {
        // arraynya
        int[] lemparanDadu ={ 6, 4, 2, 1, 6, 3, 3, 3, 4, 5 };

        for (int i = 0; i < lemparanDadu.Length; i++)
        {
            // outpur lemparan dadu 1-10
            Console.WriteLine($"Lemparan dadu {i + 1} : {lemparanDadu[i]}");
        }
        Console.WriteLine();
        // Karena array itu mulainya index atau 0 jadi lemparan akan dikurangi 1 hehe
        int poinPertama = lemparanDadu[2] + lemparanDadu[3];
        int poinKedua = lemparanDadu[7] + lemparanDadu[8];
        int poinKetiga = lemparanDadu[8] + lemparanDadu[9];
        int poinBonusPertama = lemparanDadu[5] + lemparanDadu[6] + lemparanDadu[7];

        // total poin 
        int totalPoin = poinPertama + poinKedua + poinKetiga + poinBonusPertama;

        // outputnyah
        Console.WriteLine("Poin pertama didapat dari poin lemparan dadu 3 dan 4 : " + poinPertama);
        Console.WriteLine("Poin kedua didapat dari poin lemparan dadu 8 dan 9 : " + poinKedua);
        Console.WriteLine("Poin ketiga didapat dari poin lemparan dadu 9 dan 10 : " + poinKetiga);
        Console.WriteLine("Poin bonus pertama didapat dari poin lemparan dadu 6, 7, dan 8 : " + poinBonusPertama);
        Console.WriteLine("Jumlah poin yang didapat : " + totalPoin);
    }
}



