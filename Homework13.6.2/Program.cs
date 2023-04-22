namespace Homework13._6._2
{
    internal class Program
    {
        public static Dictionary<string,int> wordsDictionary= new Dictionary<string,int>();
        static void Main(string[] args)
        {
            // Читаем файл
            string text = File.ReadAllText("Text1.txt");

            // Достаём массив слов
            char[] delimiters = new char[] { ' ', '\r', '\n' , ',', '.', '"', };
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            // Записываем все слова в словарь и подсчитываем из колличество в тексте
            AddToDictionary(words);

            // Выводим 10 самых популярных слов из текста
            ShowMostPopularWords();


            Console.ReadLine();

        }
        public static void AddToDictionary(string[] words)
        {
            foreach (var word in words)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                    continue;
                }
                wordsDictionary.Add(word, 1);
            }
        }

        // Вывод 10 слов
        public static void ShowMostPopularWords()
        {
            
            for (int i = 0; i < 10; i++)
            {
                GetMaxValue();
            }           
        }

        // Находим максимальное значение в словаре и удаляем его
        public static void GetMaxValue()
        {
            KeyValuePair<string, int> MaxValue = new KeyValuePair<string, int>("", 0);
            foreach(var word in wordsDictionary)
            {
                if (word.Value > MaxValue.Value)
                    MaxValue = word;
            }

            // Удаляем 
            wordsDictionary.Remove(MaxValue.Key);
            Console.WriteLine($"Слово \u0022{MaxValue.Key}\u0022 повторилось {MaxValue.Value} раз");
        }
    }
}