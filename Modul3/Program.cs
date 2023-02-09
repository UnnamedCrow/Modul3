using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        static void Main(string[] args)
        {

            DayOfWeek firstDayOfWeek = DayOfWeek.Monday;
            Console.Write(firstDayOfWeek);
            // Ввод имени
            Console.Write("Enter your name: ");
            var Name = Console.ReadLine();
            
            // Ввод возраста
            Console.Write("Enter your age: ");
            var  Age = checked((byte) int.Parse(Console.ReadLine()));

            // Ввод даты рождения
            Console.Write("Enter your birthdate: ");
            var Birthdate = Console.ReadLine();

            // Ввод любимого дня недели
            Console.Write("Enter your favorite day of the week: ");
            var FavoriteDay = (DayOfWeek) byte.Parse(Console.ReadLine());

            // Ввод любимого цвета
            Console.Write("Enter your favorite color: ");
            var FavoriteColor = Console.ReadLine();

            // Вывод полученых данных
            Console.WriteLine("Your name is {0}, and your age is {1}", Name, Age);
            Console.WriteLine($"Your favorite day of the week is {FavoriteDay}, and your favorite color is {FavoriteColor}");
            Console.WriteLine("Your birthdate is " + Birthdate);      

            // Ожидание ввода
            Console.ReadKey();

        }
    }
}
