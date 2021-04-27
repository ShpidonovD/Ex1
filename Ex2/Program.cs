/// author: Shpidonov Danila
/// <summary>
/// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле
/// I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
/// </summary>


using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Ваш рост (м.)?");
			double height = Double.Parse(Console.ReadLine());

			Console.WriteLine("Ваш вес (кг.)?");
			double weight = Double.Parse(Console.ReadLine());

			double index = weight / (height * height);

			Console.WriteLine("Ваш индекс массы тела: " + index.ToString("N2"));
		}
    }
}
