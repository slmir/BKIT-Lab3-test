using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Circle : Figures, IPrint, IComparable//наследуется от абстрактного класса Figures и реализует интерфес IPtint
    {
        double radius;//радиус фигуры
        public Circle(double rad)//конструктор
        {
            this.radius = rad;
			this.Type = "Окружность";
        }
        public override double Area()//переопределяем метод вычисления площади
        {
            double S = Math.Round(Math.Pow(this.radius, 2) * Math.PI, 4);//переопределение функции нахождения площади круга с точностью до 4-ого знака после запятой
            return S;
        }
        public override string ToString()//переопределение виртуального метода вывода данных об объекте
        {
            return "Круг площадью " + this.Area().ToString();
        }
        public void Print()//вывод данных об объекте
        {
            Console.WriteLine(this.ToString());
        }
    }
}

