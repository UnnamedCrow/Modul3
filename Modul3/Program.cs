using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Collections.Specialized;

namespace Modul3
{
    internal class Program
    {
        public static List<string> wordsList= new List<string>();
        public static LinkedList<string> wordsLinkedList = new LinkedList<string>();
        static void Main(string[] args)
        {
            // Читаем файл
            string text = File.ReadAllText("Text1.txt");

            // Достаём массив слов
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Записываем в List
            var stopWatch = Stopwatch.StartNew();
            AddToList(words);
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

            // Записываем в LinkedList в конец
            stopWatch.Restart();
            AddToLinkedListLast(words);
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

            // Записываем в LinkedList в начало
            wordsLinkedList.Clear();
            stopWatch.Restart();
            AddToLinkedListFirst(words);
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
        public static void AddToList(string[] words)
        {
            foreach (string word in words)
            {
                wordsList.Add(word);
            }
        }
        public static void AddToLinkedListLast(string[] words) 
        {
            foreach (string word in words)
            {
                wordsLinkedList.AddLast(word);
            }
        }
        public static void AddToLinkedListFirst(string[] words)
        {
            foreach (string word in words)
            {
                wordsLinkedList.AddFirst(word);
            }
        }
    }
}
