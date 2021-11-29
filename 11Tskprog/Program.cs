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
            Console.WriteLine("Введите значения коэффициентов уравнеия 0=k*x+b");
            Solve sol = new Solve();
            Console.WriteLine("Введите значения коэффициента k");
            sol.k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значения коэффициента b");
            sol.b = Convert.ToDouble(Console.ReadLine());           
            sol.Root();
            Console.ReadKey();
        } 
    
    }
}
