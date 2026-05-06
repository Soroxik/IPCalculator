using System;
namespace Aplikacja
{
    class Aplikacja
    {
        static void Main(string[] args)
        {
            // Tablica do adresu IP
            int[] Ip = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Podaj oktet IP");
                int oktet = int.Parse(Console.ReadLine());
                if (oktet >= 0 && oktet <= 255)
                {
                    Ip[i] = oktet;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy oktet. Podaj wartość od 0 do 255.");
                    i--; // Powtórz iterację dla tego oktetu
                }
            }
            Console.WriteLine("Twój adres IP to:");
            for (int i = 0; i < Ip.Length; i++)
            {
                Console.Write(Ip[i]);
                if (i < Ip.Length - 1)
                    Console.Write(".");
            }
            Console.WriteLine();
            // Koniec tablicy do adresu IP
            // Tablica do maski podsieci
            int[] Maska = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Podaj oktet Maski");
                int oktetM = int.Parse(Console.ReadLine());
                if (oktetM >= 0 && oktetM <= 255)
                {
                    Maska[i] = oktetM;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy oktet. Podaj wartość od 0 do 255.");
                    i--; // Powtórz iterację dla tego oktetu
                }
            }
            Console.WriteLine("Twoja maska to:");
            for (int i = 0; i < Maska.Length; i++)
            {
                Console.Write(Maska[i]);
                if (i < Maska.Length - 1)
                    Console.Write(".");
            }
            Console.WriteLine();
            // Koniec tablicy do maski podsieci
            // Konwersja oktetow maski na binarny

        }
    }
}
            
