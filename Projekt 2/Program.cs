using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;

namespace Projekt2
{

    class Program
    {
        static BigInteger Ilosc;
        static double CzasStart;
        static double CzasStop;
        static void Main(string[] args)
        {
            int liczba = 0;
            BigInteger[] Tablica = { 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            Console.WriteLine("numer \t rozmiar \t zlozonosc \t czas ");
            for (long i = 0; i < 8; i++)
            {
                Ilosc = 1;
                liczba++;
                CzasStart = Stopwatch.GetTimestamp();
                IsPrimePrzyzwoity(Tablica[i]);
                CzasStop = Stopwatch.GetTimestamp();
                double roznica = (CzasStop - CzasStart) * (10.0 / Stopwatch.Frequency);
                IsPrimeZInstrumentacjaPrzyzwoity(Tablica[i]);
                Console.WriteLine(liczba + "\t" + Tablica[i] + "\t" + Ilosc + "\t" + roznica);
            }
            Console.ReadKey();
            Console.WriteLine("numer \t rozmiar \t zlozonosc \t czas ");
            liczba = 0;
            for (long i = 0; i < 8; i++)
            {

                Ilosc = 1;
                liczba++;
                CzasStart = Stopwatch.GetTimestamp();
                IsPrime(Tablica[i]);
                CzasStop = Stopwatch.GetTimestamp();
                double roznica = (CzasStop - CzasStart) * (10.0 / Stopwatch.Frequency);
                IsPrimeZInstrumentacja(Tablica[i]);
                Console.WriteLine(liczba + "\t" + Tablica[i] + "\t" + Ilosc + "\t" + roznica);
            }
            Console.ReadKey();

        }

        static bool IsPrime(BigInteger Num)
        {
            if (Num < 2)
                return false;
            else if (Num < 4)
                return true;
            else if (Num % 2 == 0)
                return false;
            else
                for (BigInteger u = 3; u < Num / 2; u += 2)
                    if (Num % u == 0) return false;
            return true;
        }
        static bool IsPrimeZInstrumentacja(BigInteger Num)
        {
            if (Num < 2)
                return false;
            else if (Num < 4)
                return true;
            else if (Num % 2 == 0)
                return false;
            else
                for (BigInteger u = 3; u < Num / 2; u += 2)
                {
                    Ilosc++;
                    if (Num % u == 0)
                    {
                        return false;

                    }
                }
            return true;
        }
        static bool IsPrimePrzyzwoity(BigInteger Num)
        {
            if (Num < 2)
                return false;
            else if (Num < 4)
                return true;
            else if (Num % 2 == 0)
                return false;
            else
                for (BigInteger u = 3; u * u <= Num; u += 2)
                    if (Num % u == 0) return false;
            return true;
        }
        static bool IsPrimeZInstrumentacjaPrzyzwoity(BigInteger Num)
        {
            if (Num < 2)
                return false;
            else if (Num < 4)
                return true;
            else if (Num % 2 == 0)
                return false;
            else
                for (BigInteger u = 3; u * u <= Num; u += 2)
                {
                    Ilosc++;
                    if (Num % u == 0)
                    {
                        return false;

                    }
                }
            return true;
        }

    }
}
