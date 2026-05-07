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
            bool mniejszyOktet = false;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Podaj oktet Maski");
                int oktetM = int.Parse(Console.ReadLine());
                int[] poprawneOktety = { 255, 254, 252, 248, 240, 224, 192, 128, 0 };
                if (!poprawneOktety.Contains(oktetM))
                {
                    Console.WriteLine("Nieprawidłowy oktet. Podaj poprawną maskę.");
                    i--;
                    // Sprawdza czy podanyy oktet jest poprawny
                }
                else if(mniejszyOktet && oktetM !=0)
                {
                    Console.WriteLine("Po podaniu oktetu mniejszego niz 255 , kolejne oktety musza byc rowne 0");
                    i--;
                    // Sprawdza czy podany oktet jest mniejszy niz 255 , jesli tak to kolejne oktety musza byc rowne 0
                }
                else
                { 
                    Maska[i] = oktetM; 
                    if (oktetM != 255)
                    {
                        mniejszyOktet = true;
                    }
                    // Jesli podany oktet jest mniejszy niz 255 to ustawia boola na true a nastepnie wymusza aby kolejne oktety byly rowne 0
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
            Console.WriteLine("Maska w postaci binarnej:");
            int mozliweBity = 32;
            int sumaZajetychBitow = 0;
            foreach (int oktetM in Maska)
            {
                string oktetBin = Convert.ToString(oktetM, 2) /* "2" oznacza system na jaki chce zmienic liczbe  */ .PadLeft(8, '0') /* PadLeft ustawia String od lewej do prawej , 8 oznacza max liczbe znakow a '0' oznacza czym uzupelnic brakujace znaki */;
                Console.WriteLine(oktetBin);
                int liczbaZajetychBitow = oktetBin.Count(c => c == '1'); // Count liczy ile jest znakow '1' w stringu
                sumaZajetychBitow += liczbaZajetychBitow;
            }
            int wolneBity = mozliweBity - sumaZajetychBitow;
            int liczbaDostepnychHostow = (int)Math.Pow(2, wolneBity) - 2;
            Console.WriteLine($"Liczba zajętych bitów: {sumaZajetychBitow}");
            Console.WriteLine($"Liczba dostępnych hostów w tej podsieci: {liczbaDostepnychHostow}");
        }
    }
}

