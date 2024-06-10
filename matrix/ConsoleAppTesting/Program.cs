using System;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("ConsoleInputOutputHandler")]
namespace ConsoleAppTesting
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            

            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int a;
            int b;

            if (!int.TryParse(input1, out a) || !int.TryParse(input2, out b) || (a <= 0) || (b <= 0))
            {
                Console.WriteLine("некорректный ввод");

            }


            else
            {
                int[,] mass = new int[a, b];
                for (int i = 0; i < a; i++)
                {
                    
                    for (int j = 0; j < b; j++)
                    {

                        mass[i,j] = (i + 1) * (j + 1);
                    }
                    
                }

                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < b; j++)
                    {

                        Console.Write(mass[i, j] + " ");
                    }

                }
            }
        }
    }
}