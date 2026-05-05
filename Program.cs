using System;
namespace Aplikacja
{
    class Aplikacja
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj adres IP");
                int oktetPierwszy = 192;
                int oktetDrugi = 168;
                int oktetTrzeci = 1;
                int oktetCzwarty = 93;
            Console.WriteLine($"Adres IP: {oktetPierwszy}.{oktetDrugi}.{oktetTrzeci}.{oktetCzwarty}");
            Console.WriteLine("Podaj maske podsieciw bitach");
                int maskaPierwszy = 8;
                int maskaDrugi = 8;
                int maskaTrzeci = 8;
                int maskaCzwarty = 0;
            Console.WriteLine($"Maska podsieci: {maskaPierwszy}.{maskaDrugi}.{maskaTrzeci}.{maskaCzwarty}");
                int bityPodsieci = 32;
                int bityZajete = maskaPierwszy+maskaDrugi+maskaTrzeci+maskaCzwarty;
                int bityWolne = bityPodsieci - bityZajete;
                int liczbaPodsieci = (int)Math.Pow(2, bityWolne)-2;
            Console.WriteLine($"Liczba podsieci: {liczbaPodsieci}");
        }
    }
}