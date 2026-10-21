using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExeptions
{
    internal class Program
    {
        static int nextId = 1;

        static void Main()
        {
            Student student = new Student(nextId++, ReadName());

            while (true)
            {
                Console.Write("Възраст: ");
                int age;

                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Невалидна стойност.");
                    continue;
                }

                try
                {
                    student.Age = age;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Клас: ");
                int grade;

                if (!int.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("Невалидна стойност.");
                    continue;
                }

                try
                {
                    student.Grade = grade;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Среден успех: ");
                double score;

                if (!double.TryParse(Console.ReadLine(), out score))
                {
                    Console.WriteLine("Невалидна стойност.");
                    continue;
                }

                try
                {
                    student.AverageScore = score;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Такса: ");
                decimal fee;

                if (!decimal.TryParse(Console.ReadLine(), out fee))
                {
                    Console.WriteLine("Невалидна стойност.");
                    continue;
                }

                try
                {
                    student.Fee = fee;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Получава ли стипендия (да/не): ");
                string scholarship = Console.ReadLine().ToLower();

                if (scholarship == "да")
                {
                    student.HasScholarship = true;
                    break;
                }
                else if (scholarship == "не")
                {
                    student.HasScholarship = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Въведете да или не.");
                }
            }

            while (true)
            {
                Console.Write("Паралелка: ");
                string letter = Console.ReadLine();

                if (letter.Length != 1)
                {
                    Console.WriteLine("Въведете само една буква.");
                    continue;
                }

                try
                {
                    student.ClassLetter = letter[0];
                    break;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            while (true)
            {
                Console.Write("Дата на раждане: ");
                DateTime date;

                if (!DateTime.TryParse(Console.ReadLine(), out date))
                {
                    Console.WriteLine("Невалидна дата.");
                    continue;
                }

                try
                {
                    student.BirthDate = date;
                    break;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine();
            Console.WriteLine("=== ДАННИ ЗА УЧЕНИК ===");
            Console.WriteLine("Id: " + student.Id);
            Console.WriteLine("Име: " + student.Name);
            Console.WriteLine("Възраст: " + student.Age);
            Console.WriteLine("Клас: " + student.Grade);
            Console.WriteLine("Среден успех: " + student.AverageScore.ToString("F2"));
            Console.WriteLine("Такса: " + student.Fee.ToString("F2") + " лв.");
            Console.WriteLine("Стипендия: " + (student.HasScholarship ? "Да" : "Не"));
            Console.WriteLine("Паралелка: " + student.ClassLetter);
            Console.WriteLine("Дата на раждане: " + student.BirthDate.ToString("dd.MM.yyyy"));
        }

        static string ReadName()
        {
            while (true)
            {
                Console.Write("Име: ");
                string name = Console.ReadLine();

                try
                {
                    Student student = new Student(1, name);
                    return student.Name;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}