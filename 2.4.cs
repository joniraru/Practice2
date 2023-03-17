using System;

namespace ConsoleApp4
{
    class Program
    {
        class RIM
        {
            public int result;
            public string str;
            private char I = 'I';
            private char V = 'V';
            private char X = 'X';
            private char L = 'L';
            private char C = 'C';
            private char D = 'D';
            private char M = 'M';
            private string IV = "IV";
            private string IX = "IX";
            private string XL = "XL";
            private string XC = "XC";
            private string CD = "CD";
            private string CM = "CM";
            private int b = -1;
            public string Input()
            {
                Console.Write("Введите римскую цифру: ");
                str = Console.ReadLine();
                return str;
            }
            public int Answer()
            {
                for (int i = 0; i < str.Length ; i++)
                {
                    if (str[i] == I)
                    { 
                        result++;
                    }
                    if (str[i] == V)
                    {
                        result = result + 5;
                    }
                    if (str[i] == X)
                    {
                        result = result + 10;
                    }
                    if (str[i] == L)
                    {
                        result = result + 50;
                    }
                    if (str[i] == C)
                    {
                        result = result + 100;
                    }
                    if (str[i] == D)
                    {
                        result = result + 500;
                    }
                    if (str[i] == M)
                    {
                        result = result + 1000;
                    }
                }
                if (str.IndexOf(IV) > b)
                {
                    result = result - 2;
                }
                if (str.IndexOf(IX) > b)
                {
                    result = result - 2;
                }
                if (str.IndexOf(XL) > b)
                {
                    result = result - 20;
                }
                if (str.IndexOf(XC) > b)
                {
                    result = result - 20;
                }
                if (str.IndexOf(CD) > b)
                {
                    result = result - 200;
                }
                if (str.IndexOf(CM) > b)
                {
                    result = result - 200;
                }
                return result;
            }
            public void Print()
            {
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            RIM num = new RIM();
            num.Input();
            num.Answer();
            num.Print();
        }
    }
}