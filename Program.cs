/// author: Shpidonov Danila
/// <summary>
/// Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
/// а) с использованием третьей переменной;
/// </summary> 


using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}  b = {b}");
        }
    }
}
