using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika1
{
    class Student
    {
        
        public string Name { get; set; }
        public int Kurs { get; set; }
        public bool Sex { get; set; }
        public Student()  //конструктор по умолчанию
        {
            Name = null;
            Kurs = 0;
            Sex = true;
        }
        
        
        public virtual void Display() //метод для вывода 
        {
            Console.WriteLine("Имя студента: " + Name);
            Console.WriteLine("Курс: " + Kurs);
            Console.WriteLine("Пол: " + Sex);
        }
        public virtual void Input()  //метод для ввода
        {
            Console.WriteLine("Имя студента:  ");
            Name = Console.ReadLine();
            Console.WriteLine("Курс: ");
            Kurs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Пол: ");
            Sex = Convert.ToBoolean(Console.ReadLine());

        }

    }
}
