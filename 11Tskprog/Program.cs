using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _11TskStruct;

namespace _11Tskprog
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.	Разработать структуру для решения линейного уравнения 0=kx+b. 
             * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
             * Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
             * Осуществить использование экземпляра в программе.
             */
            Console.WriteLine("Введите значения коэффициентов уравнеия 0=k*x+b");
            //Задаем структуру
            Solve sol = new Solve();
            //Ввод исходных данных
            Console.WriteLine("Введите значения коэффициента k");
            sol.k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения коэффициента b");
            sol.b = Convert.ToDouble(Console.ReadLine());   
            //Вывод результата
            sol.Root();
            Console.ReadKey();
        } 
    
    }
}
