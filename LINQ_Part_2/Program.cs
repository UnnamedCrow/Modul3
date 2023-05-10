using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace LINQ_Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /// 15.1.4
            /// 
            //while (true)
            //{

            //    Console.Clear();
            //    Console.Write("First word: ");
            //    var FirstWord = Console.ReadLine().ToCharArray();
            //    Console.Write("Second word: ");
            //    var SecondWord = Console.ReadLine().ToCharArray();

            //    var Result  = FirstWord.Intersect(SecondWord);
            //    foreach(var r in Result)
            //        Console.WriteLine(r);
            //    Console.ReadLine();
            //}

            /// 15.1.5
            /// 
            //var softwareManufacturers = new List<string>()
            //{
            //     "Microsoft", "Apple", "Oracle"
            //};

            //var hardwareManufacturers = new List<string>()
            //{
            //    "Apple", "Samsung", "Intel"
            //};

            //var itCompanies = softwareManufacturers.Union(hardwareManufacturers);
            //foreach (var it in itCompanies)
            //{
            //    Console.WriteLine(it);
            //}

            /// 15.1.6
            /// 
            //while(true)
            //{
            //    Console.Clear();
            //    Console.Write("Enter line: ");
            //    var Line = Console.ReadLine();
            //    char[] Separators = { ',', '.', ';', ':', '?', '!', ' ' };

            //    var NewLine = Line.Except(Separators);
            //    Console.Write(NewLine.ToArray());
            //    Console.ReadLine();
            //}

            /// 15.2.1
            /// 
            //Console.WriteLine("Enter number");

            //if (!int.TryParse(Console.ReadLine(), out int number))
            //    Console.WriteLine("Wrong data");
            //Console.WriteLine(Factorial(number));

            /// 15.2.2
            /// 
            //var contacts = new List<Contact>()
            //{
            //     new Contact() { Name = "Андрей", Phone = 79994500508 },
            //     new Contact() { Name = "Сергей", Phone = 799990455 },
            //     new Contact() { Name = "Иван", Phone = 79999675334 },
            //     new Contact() { Name = "Игорь", Phone = 8884994 },
            //     new Contact() { Name = "Анна", Phone = 665565656 },
            //     new Contact() { Name = "Василий", Phone = 3434 }
            //};

            //var WrongNumbersAmount = contacts.Count(x => !x.Phone.ToString().StartsWith('7') || x.Phone.ToString().Length != 11);
            //Console.WriteLine(WrongNumbersAmount);
            //WrongNumbersAmount = (from contact in contacts
            //                     let PhoneString = contact.Phone.ToString()
            //                     where !PhoneString.StartsWith('7') || PhoneString.Length != 11
            //                     select contact).Count();
            //Console.WriteLine(WrongNumbersAmount);

            ///15.2.8
            ///
            //var Numbers = new List<double>();
            //double Number;
            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter number");
            //    if(!double.TryParse(Console.ReadLine(), out Number))
            //    {
            //        Console.WriteLine("Ooops! Wrong data! Try again!");
            //        continue;
            //    }
            //    Numbers.Add(Number);
            //    Console.WriteLine($"Count of numbers in the list: {Numbers.Count}");
            //    Console.WriteLine($"Sun of numbers in the list: {Numbers.Sum()}");
            //    Console.WriteLine($"Max number: {Numbers.Max()}");
            //    Console.WriteLine($"Min number: {Numbers.Min()}");
            //    Console.WriteLine($"Average number: {Numbers.Average()}");
            //    Console.ReadLine();
            //}

            /// 15.3.3
            /// 
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var GroupUsers = phoneBook.GroupBy(x => x.Email.Split('@').Last());
            foreach (var groupUser in GroupUsers)
            {
                if(groupUser.Key.Contains("example"))
                {
                    Console.WriteLine("Fake addres: ");
                    foreach(var contact in groupUser) 
                    {
                        Console.WriteLine(contact.Name + " " + contact.Phone);
                    }
                }
                else
                {
                    Console.WriteLine("Real Addres: ");
                    foreach(var contact in groupUser)
                    {
                        Console.WriteLine(contact.Name + " " + contact.Phone);
                    }
                }
            }
            Console.ReadLine();
        }
        static long Factorial(int n)
        {
            var numbers = new List<int>();
            for (int i = 1; i <= n; i++)
                numbers.Add(i);

            return numbers.Aggregate((x, y) => x * y);
        }
    }

}