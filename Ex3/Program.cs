/// author: Shpidonov Danila
/// <summary>
/// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
///    y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат,
///    используя спецификатор формата .2f (с двумя знаками после запятой);
/// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде
///     метода.
/// </summary>


using System;
using System.Linq;

struct Point
{
	public double x;
	public double y;

	public Point(double x_value, double y_value)
	{
		x = x_value;
		y = y_value;
	}
}

namespace Ex3
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ведите координаты первой точки через запятую (например 10, 20):");

			Point p1 = getPoint();

			Console.WriteLine("Ведите координаты второй точки (например 30, 40):");

			Point p2 = getPoint();

			double r = distance(p1, p2);

			Console.WriteLine("Расстояние между точками ({0}, {1}) и ({2}, {3}): {4:F2}", p1.x, p1.y, p2.x, p2.y, r);
		}

		private static Point getPoint()
		{
			double[] values = Console.ReadLine().Split(',').Select(s => Convert.ToDouble(s)).ToArray();
			return new Point(values[0], values[1]);
		}

		private static double distance(Point p1, Point p2)
		{
			return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
		}
	}
}