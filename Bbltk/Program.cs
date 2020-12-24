using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza_D_Bbltk;

namespace Bbltk
{
    class Program
    {
        static void Result(string[] args)
        {
            int sum = 0;// Переменные типа int 
            Console.WriteLine("Введите число строк R и столбцов матрицы");
            Console.Write("Число строк R="); // Введите R
            R = int.Parse(Console.ReadLine());
            Console.Write("Число столбцов C="); // Введите C
            C = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int r = 0; r < R; r++)
            {
                for (int c = 0; c < C; c++)
                {
                    fM[r, c] = (double)M[r, c] % 3;

                    Console.Write("{0} ", fM[r, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey(); //Пауза
        }
    }
}
