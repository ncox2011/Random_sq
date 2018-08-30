using System;
using System.Collections.Generic;

namespace Random_classes
{
    class Program
    {
        static void Main(string[] args)
        {
        Random random = new Random();
        List<int> allNumbers = new List<int>();
        for (int i = 1; i <= 20; i++)
        {
        
            int rnum = random.Next(1,51);
            allNumbers.Add(rnum);
        }
        List<int> sqrNum = new List<int>();
        foreach (int num in allNumbers)
        {
            sqrNum.Add(num*num);
        }
        List<int> oddNum = new List<int>();
        foreach (int num in sqrNum)
        {
            if ((num % 2) !=0)
            {
                oddNum.Add(num);
            }
            
        }
        Console.WriteLine(String.Join(", ", sqrNum));
        Console.WriteLine(String.Join(", ", oddNum));
        }
    }
}
