using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Module13Fractions
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction() : this(0, 1) { }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменник не може бути нулем.");
            }
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    internal class Program
    {
        public static Fraction[] ReadFractionsFromConsole()
        {
            Console.Write("Enter array size: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid size. Using default size 3.");
                size = 3;
            }

            Fraction[] fractions = new Fraction[size];
            Console.WriteLine($"Enter {size} fractions (Numerator/Denominator):");

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Fraction {i + 1} Numerator: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write($"Fraction {i + 1} Denominator: ");
                int den = int.Parse(Console.ReadLine());

                fractions[i] = new Fraction(num, den);
            }

            return fractions;
        }

        public static void SerializeAndSave(Fraction[] array, string filePath)
        {
            Console.WriteLine($"\n--- Serialization to {filePath} ---");

            using (FileStream fs = File.Create(filePath))
            {
                JsonSerializer.Serialize(fs, array);
            }
            Console.WriteLine("Serialization complete.");
        }

        public static Fraction[] LoadAndDeserialize(string filePath)
        {
            Console.WriteLine($"\n--- Deserialization from {filePath} ---");

            Fraction[] result = null;

            using (FileStream fs = File.OpenRead(filePath))
            {
                result = JsonSerializer.Deserialize<Fraction[]>(fs);
            }
            Console.WriteLine("Deserialization complete.");
            return result;
        }

        static void Main(string[] args)
        {
            string filePath = "FractionsArray.json";
            Fraction[] originalArray;

            originalArray = ReadFractionsFromConsole();

            Console.WriteLine("\nOriginal Array:");
            foreach (var f in originalArray)
            {
                Console.WriteLine(f);
            }

            SerializeAndSave(originalArray, filePath);

            Fraction[] loadedArray = LoadAndDeserialize(filePath);

            Console.WriteLine("\nLoaded Array:");
            if (loadedArray != null)
            {
                foreach (var f in loadedArray)
                {
                    Console.WriteLine(f);
                }
            }   
        }
    }
}
