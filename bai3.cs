using System;

class Program
{
    static void Main()
    {

        Console.Write("Nhập vào số nguyên dương N: ");
        int n = int.Parse(Console.ReadLine());


        if (IsPrime(n))
        {
            Console.Write($"{n} là Số nguyên tố. ");
        }
        else
        {
            Console.Write($"{n} KHÔNG là Số nguyên tố. ");
        }

        if (IsPerfectNumber(n))
        {
            Console.WriteLine($"{n} là Số hoàn hảo!");
        }
        else
        {
            Console.WriteLine($"{n} KHÔNG là Số hoàn hảo.");
        }

 
        PrintFibonacci(n);
    }

 
    static bool IsPrime(int number)
    {
        if (number < 2) return false;


        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

 
    static bool IsPerfectNumber(int number)
    {
        if (number <= 0) return false;

        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i; 
            }
        }
        return sum == number;
    }


    static void PrintFibonacci(int count) 
    {
        Console.Write($"Dãy Fibonacci {count} số: ");

        if (count <= 0) return;

        int f0 = 0, f1 = 1;

        for (int i = 0; i < count; i++)
        {
            if (i == 0)
            {
                Console.Write(f0);
            }
            else if (i == 1)
            {
                Console.Write($", {f1}");
            }
            else
            {
                int next = f0 + f1; 
                Console.Write($", {next}");
                f0 = f1; 
                f1 = next; 
            }
        }
        Console.WriteLine();
    }
}
