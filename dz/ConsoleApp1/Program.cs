using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("drawing: ");

            int width = 3;
            int height = 1;

            int rows = height + 2;
            int cols = width + 2;

            char[,] grid = new char[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    grid[r, c] = ' ';
                }
            }

            grid[0, 0] = '+';
            grid[0, cols - 1] = '+';
            grid[rows - 1, 0] = '+';
            grid[rows - 1, cols - 1] = '+';

            for (int c = 1; c < cols - 1; c++)
            {
                grid[0, c] = '-';
                grid[rows - 1, c] = '-';
            }

            for (int r = 1; r < rows - 1; r++)
            {
                grid[r, 0] = '|';
                grid[r, cols - 1] = '|';
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(grid[r, c]);
                }
                Console.WriteLine();
            }
        }
    }
}
