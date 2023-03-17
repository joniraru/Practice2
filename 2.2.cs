
using System;

/*Задание 1*/

/*namespace ConsoleApp2
{
    class Program
    {
        class Student
        {
            public string surname = "Неизвестно";
            public DateTime dob;
            public int group;
            public int[] ap = {1, 2, 3, 4, 5};
        }
        static void Main(string[] args)
        {
            Student you = new Student();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("0 - информация о студенте, 1 - изменение фамилии \n" +
                                  "2 - изменение даты рождения, 3 - изменение номера группы студента \n" +
                                  "4 - для выхода из программы \n ");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                { 
                    case 0: 
                        Console.WriteLine($"Фамилия: {you.surname} | Дата рождения: {you.dob.ToString("d")} \n" +
                                          $"Группа: {you.group} | Успеваемость: {you.ap[i]}");
                        break;
                    case 1:
                        Console.Write("Введите фамилию:  "); 
                        you.surname = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Введите дату рождения формата дд.мм.гггг: ");
                        you.dob = Convert.ToDateTime(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Введите группу: ");
                        you.group = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        break;
                }
            }
        }
    }
}*/


/*Задание 2*/


/*namespace ConsoleApp2
{
    class Program
    {
        class Train
        {
            public static string[] des = new []{"Saratov", "Moscow", "Tomsk", "New-York"};
            public static int[] tn = new[] { 2, 4, 10, 12 };
            public static DateTime s = DateTime.Now;
            public void Print()
            { 
                Console.WriteLine($"Пункт назначения: {des} | Время отправления: {s} ");
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("0 - поезд 2, 1 - поезд 4 \n" +
                                  "2 - поезд 10, 3 - поезд 12 \n" +
                                  "4 - для выхода из программы \n ");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"Пункт назначения: {Train.des[i]}\n"+
                                          $"Номер поезда: {Train.tn[i]}\n" +
                                          $"Время отправления: {Train.s}");
                        break;
                    case 1:
                        Console.WriteLine($"Пункт назначения: {Train.des[i]}\n"+
                                          $"Номер поезда: {Train.tn[i]}\n" +
                                          $"Время отправления: {Train.s}");
                        break;
                    case 2:
                        Console.WriteLine($"Пункт назначения: {Train.des[i]}\n"+
                                          $"Номер поезда: {Train.tn[i]}\n" +
                                          $"Время отправления: {Train.s}");
                        break;

                    case 3:
                        Console.WriteLine($"Пункт назначения: {Train.des[i]}\n"+
                                          $"Номер поезда: {Train.tn[i]}\n" +
                                          $"Время отправления: {Train.s}");
                        break;

                    case 4:
                        Console.WriteLine($"Пункт назначения: {Train.des[i]}\n"+
                                          $"Номер поезда: {Train.tn[i]}\n" +
                                          $"Время отправления: {Train.s}");
                        break;
                    case 5:
                        Console.WriteLine($"Пункт назначения: {Train.des[i]}\n"+
                                          $"Номер поезда: {Train.tn[i]}\n" +
                                          $"Время отправления: {Train.s}");
                        break;
                }
            }
        }
    }
}*/

    


/*Задание 3*/

/*namespace ConsoleApp2
{
    public class program
    {
        class Numbers
        {
            private int number1;
            private int number2;
            public void Printn()
            {
                Console.WriteLine($"{number1} {number2}");
            }
            public void Changen()
            {
                Console.WriteLine("Введите первое число: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                number2 = Convert.ToInt32(Console.ReadLine());
            }
            public int Sum()
            {
                Console.WriteLine(number1 + number2);
                return number1 + number2;
            }

            public int Biggern()
            {
                if (number1 > number2)
                { 
                    Console.WriteLine($"{number1} > {number2}");
                    return number1; 
                }
                if (number1 < number2)
                {
                    Console.WriteLine($"{number1} < {number2}");
                    return number2;
                }
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Numbers bruh = new Numbers();
            bruh.Printn();
            bruh.Changen();
            bruh.Printn();
            bruh.Sum();
            bruh.Biggern();
            bruh.Printn();
        }
    }
}*/

/*Задание 4*/

namespace ConsoleApp2
{
    public class Program
    {
        class Counter
        {
            private int counter;
            public void Increase()
            {
                counter++;
            }
            public void Decrease()
            {
                counter--;
            }
            public void Default()
            {
                counter = 0;
            }
            public void Random()
            {
                var random = new Random();
                counter = random.Next(1, 100);
            }
            public void Printc()
            {
                Console.WriteLine(counter);
            }
        }
        static void Main(string[] args)
        {
            Counter kon = new Counter();
            for (int i = 0; i < 20; i++)
            {
                 kon.Increase();
            }
            kon.Printc();
            kon.Decrease();
            kon.Printc();
            kon.Default();
            kon.Printc();
            kon.Random();
            kon.Printc();
        }
    }
}

/*Задание 5*/

/*namespace ConsoleApp2
{
    public class Program
    {
        class Anime
        {
            private string name;
            private int? number;
            
            public Anime()
            {
                name = "Noragami";
                number = 2014;
            }
            public Anime(string name, int number)
            {
                this.number = number;
                this.name = name;
            }
            public void Del()
            {
                name = null;
                number = null;
                Console.WriteLine($"Обьект удален");   
            }

            public void print()
            {
                Console.WriteLine($"Аниме {name}, год выхода {number}");
            } 
            
        }
        static void Main(string[] args)
        {
            Anime Kowai = new Anime("Блич", 2004);
            Anime Def = new Anime();
            Kowai.print();
            Kowai.Del();
            Def.print();
            Def.Del();
        }
    }
}*/