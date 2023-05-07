namespace Homework_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));
            int Page;
            IEnumerable<Contact> list = null;
            var SortedPhoneBook = phoneBook
                              .OrderBy(E => E.Name)
                              .ThenBy(E => E.LastName);
            while (true)
            {
                Console.WriteLine("Choose the page 1 - 3");
                int.TryParse(Console.ReadLine(), out Page);
                Console.Clear();
                switch (Page)
                {
                    case 1:
                        list = SortedPhoneBook.Take(2);
                        break;
                    case 2:
                        list = SortedPhoneBook.Skip(2).Take(2);
                        break;
                    case 3:
                        list = SortedPhoneBook.Skip(4).Take(2);
                        break;
                    default: break;
                }
                if (list == null) continue;
                foreach (var l in list)
                    Console.WriteLine($"{l.Name} {l.LastName} Phone number: {l.PhoneNumber} e-mail: {l.Email}");
                list = null;
            }
        }
    }
}