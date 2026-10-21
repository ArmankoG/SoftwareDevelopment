using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkExeptions
{
    class Student
    {
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private char classLetter;
        private DateTime birthDate;
        private string name;

        public int Id { get; private set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Името не може да бъде празно.");

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 6 || value > 20)
                    throw new ArgumentOutOfRangeException("Възрастта трябва да бъде между 6 и 20 години.");

                age = value;
            }
        }

        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Класът трябва да бъде между 1 и 12.");

                grade = value;
            }
        }

        public double AverageScore
        {
            get { return averageScore; }
            set
            {
                if (value < 2 || value > 6)
                    throw new ArgumentOutOfRangeException("Средният успех трябва да бъде между 2 и 6.");

                averageScore = value;
            }
        }

        public decimal Fee
        {
            get { return fee; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Таксата не може да бъде отрицателна.");

                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        public char ClassLetter
        {
            get { return classLetter; }
            set
            {
                if (!char.IsLetter(value))
                    throw new ArgumentException("Паралелката трябва да бъде буква.");

                classLetter = value;
            }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("Датата на раждане не може да бъде бъдеща.");

                birthDate = value;
            }
        }

        public Student(int id, string name)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException("Id трябва да бъде положително число.");

            Id = id;
            Name = name;
        }
    }

}
