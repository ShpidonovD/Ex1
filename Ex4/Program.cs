/// author: Shpidonov Danila
/// <summary>
/// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
/// б) *Сделать задание, только вывод организовать в центре экрана.
/// в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
/// </summary> 


using System;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Shpidonov Danila";
            string city = "Rostov-on-Don";

            Console.SetCursorPosition(100, 100);
            Console.WriteLine(name);
            Console.SetCursorPosition(100, 140);
            Console.WriteLine(city);
        }
    }
}
