using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {            
            int A=1, B=1, N=1;
            bool parse = false, condition = true;
            while (condition)
            {
                Console.WriteLine("Введите натуральное число А>1 A<10");
                parse = Int32.TryParse(Console.ReadLine(),out A);
                if(A>1 && A<10 && parse==true)
                {
                    condition = false;
                }
            }            
            condition = true;
            while (condition)
            {
                Console.WriteLine("Введите натуральное число B>1 B<10");
                parse = Int32.TryParse(Console.ReadLine(), out B);
                if (B>1 && B < 10 && parse==true)
                {
                    condition = false;
                }
            }            
            condition = true;
            while (condition)
            {
                Console.WriteLine("Введите натуральное число 10<N<100");
                parse = Int32.TryParse(Console.ReadLine(), out N);
                if (N < 100 && N>10 && parse==true)
                {
                    condition = false;
                }
            }
            int MinValueCount, MaxValueCount,MinValue,MaxValue,Value;
            
            if(A<=B)
            {
                MaxValueCount=N / B;
                MaxValue = B;
                MinValue = A;
            }
            else
            {
                MaxValueCount = N / A;
                MaxValue = A;
                MinValue = B;
            }

            List<int> Values = new List<int>();
            if(N%A==0)
            {
                int CountA = N / A;
                Value =(int)Math.Pow(A,CountA);
                Values.Add(Value);
            }
            if(N%B==0)
            {
                int CountB = N / B;
                Value = (int)Math.Pow(B, CountB);
                Values.Add(Value);
            }
            int Work;
            for (int i=1;i<=MaxValueCount;i++)
            {
                MinValueCount = 0;
                Work = N;
                Work -= i * B;
                while(Work>=A)
                {
                    Work -= A;
                    MinValueCount++;
                }
                if (Work != 0) continue;
                Value = (int)(Math.Pow(B,i) *Math.Pow(A, MinValueCount));
                Values.Add(Value);
            }
            if(Values.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Values.Sort();
                Console.WriteLine(Values[Values.Count - 1]);
            }            
        }
    }
}