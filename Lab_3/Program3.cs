using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Lab_2;

namespace Lab_3
{
	class Program3
	{
		static void Main(string[] args)
		{
			Rectangle oRect = new Rectangle(1, 2);
			Circle oCircle = new Circle(20);
			Square oSquare = new Square(8);

			
			//Создание коллекции класса ArrayList
			/*ArrayList aa = new ArrayList();
			aa.Add(oRect);
			aa.Add(oCircle);
			aa.Add(oSquare);
			//Вывод элементов необощенного списка
			foreach (object o in aa)
				Console.WriteLine(o);
			aa.Sort();
			foreach (object o in aa)
				Console.WriteLine(o);
			foreach (object o in aa)
			{
				string typ = o.ToString();
				Console.WriteLine(typ);
				Console.ReadLine();
				//if (typ == "")
			}
			*/

			List<Figures> ff = new List<Figures>();
			ff.Add(oRect);
			ff.Add(oCircle);
			ff.Add(oSquare);
			Console.WriteLine("\nПеред сортировкой:");
			foreach (var x in ff)
				Console.WriteLine(x);
			Console.WriteLine("Сравнение площадей прямоугольника и окружности: {0}",oRect.CompareTo(oCircle));
			Console.WriteLine("Сравнение площадей прямоугольника и квадрата: {0}", oRect.CompareTo(oSquare));
			Console.WriteLine("Сравнение площадей квадрата и окружности: {0}", oSquare.CompareTo(oCircle));
			Console.WriteLine("Следовательно площади в порядке увеличения стоят так:\nПрямоугольник < Квадрат < Окружность");

			//сортировка
			ff.Sort();

			ff.Clear();
			ff.Add(oRect);
			ff.Add(oSquare);
			ff.Add(oCircle);
			Console.WriteLine("\nПосле сортировки:");
			foreach (var x in ff)
				Console.WriteLine(x);
			
			Console.ReadLine();
		}
	}
}
