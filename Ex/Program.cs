/// author: Shpidonov Danila
/// <summary>
/// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст,
/// рост, вес). В результате вся информация выводится в одну строчку:
///  а) используя склеивание;
///  б) используя форматированный вывод;
///  в) используя вывод со знаком $.
/// </summary>


using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Здравствуйте, не могли бы вы заполнить анкету?");

			Console.WriteLine("Ваше имя?");
			string name = Console.ReadLine();

			Console.WriteLine("Ваша фамилия?");
			string surname = Console.ReadLine();

			Console.WriteLine("Ваш возраст?");
			string age = Console.ReadLine();

			Console.WriteLine("Ваш рост?");
			string height = Console.ReadLine();

			Console.WriteLine("Ваш вес?");
			string weight = Console.ReadLine();

			Console.WriteLine(name + " " + surname + ": " + age + " лет, " + height + " см., " + weight + " кг.");
			Console.WriteLine("{0} {1}: {2} лет, {3} см., {4} кг.", name, surname, age, height, weight);
			//Console.WriteLine($"{name} {surname}: {age} лет, {height} см., {weight} кг.");
		}
	}
}
