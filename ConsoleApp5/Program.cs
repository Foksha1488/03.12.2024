using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {///Gоменять местами содержимое двух строковых переменных.
        static void Swap(ref string x, ref string y)
    {
            string p = x;
            x = y;
            y = p;
        }
        
         static void Main(string[] args)
        {
        string st1 = "Это первая строка";
        string st2 = "Это вторая строка";
        Console.WriteLine($"Вывод до обмена:{st1}\t{st2}");
        Swap(ref st1,ref st2);
        Console.WriteLine($"Вывод после обмена:{st1}\t{st2}");
        Console.ReadKey();
        }
    }
}
