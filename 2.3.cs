using System;

/*Задание 1*/

/*namespace ConsoleApp3
{
    class Program
    {
        class Worker
        {
            public string name;
            public string surname;
            public float rate;
            public int days;

            public float GetSalary(float rate, int days)
            {
                return days * rate;
            }
        }
        static void Main(string[] args)
        {
            Worker temp = new Worker();
            temp.name = "Oleg";
            temp.surname = "Golovach";
            temp.rate = (float)1009.4;
            temp.days = 30;
            Console.Write($"{temp.name} {temp.surname} {temp.GetSalary(temp.rate,temp.days)}");
        }
    }
}*/

/*Задание 2*/

/*namespace ConsoleApp3
{
    class Program
    {
        class Worker
        {
            private string name;
            private string surname;
            private float rate;
            private int days;
            private float payment;
            public string Name { get => name; set { name = value; } }
            public string Surname { get => surname; set { surname = value; } }
            public float Rate { get => rate; set{ rate = value; } }
            public int Days { get => days; set{ days = value; } }
            public float GetSalary(float Rate, int Days)
            {
                return Rate * Days;
            }
        }
        static void Main(string[] args)
        {
            Worker temp = new Worker();
            temp.Name = "Олег";
            temp.Surname = "Головач";
            temp.Rate = (float)1009.4;
            temp.Days = 30;
            Console.Write($"{temp.Name} {temp.Surname} Зарплата: {temp.GetSalary(temp.Rate, temp.Days)}");
        }
    }
}*/

/*Задание 3*/

namespace ConsoleApp3
{
    class Program
    {
        class Calculation
        {
            public string calculationLine;
            public void SetCalculationLine(string word)
            {
                calculationLine = word;
            }
            public void SetLastSymbolCalculationLine(char b)
            {
                calculationLine = calculationLine + b;
            }
            public void GetCalculationLine()
            {
                Console.WriteLine(calculationLine);
            }
            public char GetLastSymbol()
            {
                return calculationLine[calculationLine.Length - 1];
            }
            public string DeleteLastSymbol()
            {
                return calculationLine.Remove(calculationLine.Length - 1);
            }
        }
        static void Main(string[] args)
        {
            Calculation bruh = new Calculation();
            bruh.SetCalculationLine("Григорий");
            bruh.GetCalculationLine();
            bruh.SetLastSymbolCalculationLine('b');
            bruh.GetCalculationLine();
            Console.WriteLine(bruh.GetLastSymbol());
            Console.WriteLine(bruh.DeleteLastSymbol());
        }
    }
}