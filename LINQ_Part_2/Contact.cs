using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Part_2
{
    /// <summary>
    ///  { Name = "Андрей", Phone = 79994500508 },
    /// </summary>
    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; } 
        public Contact() { }
        public Contact(string name, long phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }
    }
    // Модель автомобиля
    public class Car
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
    }

    // Завод - изготовитель
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
    // new Department() {Id = 1, Name = "Программирование"}
    public class Department
    {
        public byte Id { get; set; }
        public string Name { get; set; }

    }
    //Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
    public class Employee
    {
        public byte DepartmentId { get; set; }
        public string Name { get; set; }
        public byte Id { get; set; }
    }
}
