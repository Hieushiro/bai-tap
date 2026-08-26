
using System;

class Program
{
    static void Main()
    { 
        Console.Write("nhap so a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("nhap so b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("nhap phep toan +,-,*,/,% :");
        char op = char.Parse(Console.ReadLine());
        string kq = op switch
        {
            '+' => $"{a + b:F2}",
            '-' => $"{a - b:F2}",
            '*' => $"{a * b:F2}",
            '/' when b == 0 => "loi:Khong the chia cho 0!",
            '/' => $"{a / b:F2}",
            '%' when b == 0 => "loi:Khong the chia cho 0!",
            '%' => $"{a % b:F2}",
            _ => "loi:Khong ton tai phep toan!"
        };
        Console.WriteLine($"Kết quả: {kq}");
    }
}