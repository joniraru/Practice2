using System;
using System.Collections.Generic;

namespace ConsoleApp1

/*УППрактическаяработа2.1 */

/*Задание 1.*/

{
    public class Program
    {
        static void Main(string[] args)
        {
            String J = "ab", S = "aabbccd";
            int res = 0;
            int w = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (J[w] == S[i])
                {
                    res++;
                }
                if (i == S.Length - 1)
                {
                    i = 0;
                    w++;
                }
                if (w == J.Length)
                {
                    break;
                }
            }
            Console.WriteLine(res);
        }
    }
}

/*Задание 2.*/


/*{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> candidates = new List<int>() { 6, 2, 2, 2, 4, 1};
            int target = 5;
            int total = 0;
            List<int> answer = new List<int>();
            for (int i = 0; i < candidates.Count; i++)
            {
                total = 0;
                answer.Clear();
                for (int j = 0; j < candidates.Count; j++)
                {
                    if (i != j)
                    {
                        total += candidates[j];
                        answer.Add(candidates[j]);
                    }

                    if (total > target)
                    {
                        break;
                    }
                    else if (total == target)
                    {
                        for (int k = 0; k < answer.Count; k++)
                        {
                            Console.Write($"{answer[k]} ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}*/

/*Задание 3.*/

/*{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4 };
            bool n = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int num = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        num++;
                    }
                }
                if (num > 1)
                {
                    n = true;
                    Console.WriteLine(n);
                    break;
                }
            }
            if (!n)
            {
                Console.WriteLine(n);
            }
        }
    }
}*/









