using System;
using System.Collections.Generic;

namespace NumberConverter
{
    class Converter
    {
        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
            { '0', "0000" },
            { '1', "0001" },
            { '2', "0010" },
            { '3', "0011" },
            { '4', "0100" },
            { '5', "0101" },
            { '6', "0110" },
            { '7', "0111" },
            { '8', "1000" },
            { '9', "1001" },
            { 'a', "1010" },
            { 'b', "1011" },
            { 'c', "1100" },
            { 'd', "1101" },
            { 'e', "1110" },
            { 'f', "1111" }
        };

        public static string HexToBin(string hex)
        {
            string binary = "";

            foreach (var letter in hex.ToLower())
            {
                binary += hexCharacterToBinary[letter];
            }

            return binary;
        }

        public static int HexToDec(string hex)
        {
            char[] szamjegyek = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            int[] ertek = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int eredmeny = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                int j = 0;
                while(szamjegyek[j] != hex[i]) { j++; }
                int hatvany = hex.Length - i - 1;
                eredmeny += ertek[j] * (int)Math.Pow(16, hatvany);
            }
            return eredmeny;
        }


        public static int OctToDec(string oct)
        {
            char[] szamjegyek = { '0', '1', '2', '3', '4', '5', '6', '7'};
            int[] ertek = { 0, 1, 2, 3, 4, 5, 6, 7};

            int eredmeny = 0;

            for (int i = 0; i < oct.Length; i++)
            {
                int j = 0;
                while (szamjegyek[j] != oct[i]) { j++; }
                int hatvany = oct.Length - i - 1;
                eredmeny += ertek[j] * (int)Math.Pow(8, hatvany);
            }
            return eredmeny;
        }

        public static string DecToHex(int dec)
        {
            char[] szamjegyek = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            string majdnemeredmeny = "";

            int szam = dec;
            while(szam != 0)
            {
                int seged = szam / 16;
                int maradek = szam - (seged * 16);
                majdnemeredmeny += szamjegyek[maradek];
                szam = seged;
            }

            string eredmeny = "";
            for (int i = majdnemeredmeny.Length - 1; i >= 0; i--)
            {
                eredmeny += majdnemeredmeny[i];
            }

            return eredmeny;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string hex = "FA22";
            string bin = Converter.HexToBin(hex);
            int dec = Converter.HexToDec(hex);
            string hexujra = Converter.DecToHex(dec);
            Console.WriteLine($"{hex} hex in binary is: {bin}");
            Console.WriteLine($"{hex} hex in decimail is: {dec}");
            Console.WriteLine($"in hex is: {hexujra}");
        }
    }
}
