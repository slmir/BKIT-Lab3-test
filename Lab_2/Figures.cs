using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public abstract class Figures: IComparable//абстрактный класс "геометрическая фигура"
	{
		public string Type { get; set; }
        public abstract double Area();//виртуальный метод вычисления площади, предполагающий переопределние в классах-наследниках
		public int CompareTo(object obj)//реализация метода сравнения интерфейса IComparable
		{
			Figures f = obj as Figures;
			//Сравнение
			if (this.Area() < f.Area())
				return -1;//если площадь текущего объекта меньше площади передаваемого объекта
			else
			{
				if (this.Area() == f.Area())
					return 0;//если площади текущего и передаваемого объектов равно
				else
					return 1;//если площадь текущего больше, чем площадь передаваемого
			}
		}
	}
}