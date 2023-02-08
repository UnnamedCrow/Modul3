using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    internal class Program
    {
        enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,  
            Sunday
            
        }
        enum Semphore : int
        {
            Red = 100,
            Yellow = 200,
            Green = 300
        }
        static void Main(string[] args)
        {
            // Ввод имени
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            
            // Ввод возраста
            Console.Write("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());

            // Вывод полученых данных
            Console.WriteLine($"Your name is {Name}, and your age is {Age}");
            
            // Ввод номера дня недели
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek FavoriteDay = (DayOfWeek) byte.Parse(Console.ReadLine());
            
            // Вывод дня недели       
            Console.WriteLine($"Your favorite day of the week is: {FavoriteDay}");
            
            // Ожидание ввода
            Console.ReadKey();

        }
    }
}
