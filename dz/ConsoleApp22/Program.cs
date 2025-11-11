using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{

    interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    class Array : ICalc
    {
        private int[] data;
        private int arraySize;

        public Array(int size)
        {
            data = new int[size];
            arraySize = size;
        }

        public void SetData(int index, int value)
        {
            if (index >= 0 && index < arraySize)
            {
                data[index] = value;
            }
        }

        public override string ToString()
        {
            string arrayString = "";
            for (int i = 0; i < arraySize; i++)
            {
                arrayString += data[i].ToString();
                if (i < arraySize - 1)
                {
                    arrayString += ", ";
                }
            }
            return $"Array data: [{arrayString}]";
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int item in data)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int item in data)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Array myArray = new Array(5);
            myArray.SetData(0, 10);
            myArray.SetData(1, 25);
            myArray.SetData(2, 5);
            myArray.SetData(3, 30);
            myArray.SetData(4, 15);

            Console.WriteLine(myArray);

            int valueToCompare = 20;
            ICalc calculator = myArray;

            int lessCount = calculator.Less(valueToCompare);
            int greaterCount = calculator.Greater(valueToCompare);

            Console.WriteLine($"Values in array less than {valueToCompare}: {lessCount}");
            Console.WriteLine($"Values in array greater than {valueToCompare}: {greaterCount}");
        }
    }
}
