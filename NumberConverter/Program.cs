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
    }

    class Program
    {
        static void Main(string[] args)
        {
            string hex = "FA22";
            string bin = Converter.HexToBin(hex);
            Console.WriteLine($"{hex} hex in binary is: {bin}");
        }
    }
}
