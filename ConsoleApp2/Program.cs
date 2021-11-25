using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    class Program
    {
        //Разработать структуру для решения линейного уравнения 0=kx+b.
        //Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.Для решения уравнения предусмотреть метод Root.
        //Создать экземпляр разработанной структуры.Осуществить использование экземпляра в программе.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты уравнения k*x+b=0");
            double k = ReadCoeffs("Введите коэффициент k:");
            double b = ReadCoeffs("Введите коэффициент b:");
            var equation = new LineEquation { K = k, B = b };
            equation.Root();
            Console.ReadKey();
        }
        static double ReadCoeffs(string text)   //метод проверяющий корректность ввода данных
        {
            double coeff;
            while (true)
            {
                Console.WriteLine(text);
                if (Double.TryParse(Console.ReadLine(), out coeff))
                {
                    return coeff;
                }
                else
                {
                    Console.WriteLine("Ввод некорректен");
                }
            }
        }        
    }
    struct LineEquation      //структура, описывающая линейное уравнение
    {
        public double K { get; set; }
        public double B { get; set; }
        public void Root()      //метод, вычисляющий решение линейного уравнения
        {
            if (K == 0 && B == 0)
            {
                Console.WriteLine("Уравнение имеет бесконечное количество решений");
            }
            else if (K == 0 && B != 0)
            {
                Console.WriteLine("Уравнение не имеет решений");
            }
            else
            {
                double x = Math.Round(-B / K, 3);
                Console.WriteLine($"Единственным решением уравнения является: {x:f2}");
            }
        }
    }
}
