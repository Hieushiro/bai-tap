using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        int choice;

        do
        {
            Console.Clear();
            Console.WriteLine("================= MENU BÀI TẬP =================");
            Console.WriteLine("1. Chạy Bài tập 1 (Calculator)");
            Console.WriteLine("2. Chạy Bài tập 2 (Phương trình bậc 2)");
            Console.WriteLine("3. Chạy Bài tập 3 (Số nguyên tố & Fibonacci)");
            Console.WriteLine("0. Thoát chương trình");
            Console.WriteLine("================================================");
            Console.Write("Nhập lựa chọn của bạn (0-3): ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    RunCalculator();
                    break;
                case 2:
                    RunQuadraticEquation();
                    break;
                case 3:
                    RunPrimeAndFibonacci();
                    break;
                case 0:
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập từ 0 đến 3.");
                    break;
            }

            if (choice != 0)
            {
                Console.WriteLine("\nẤn một phím bất kỳ để quay lại Menu...");
                Console.ReadKey();
            }

        } while (choice != 0);
    }

    #region BÀI TẬP 1: CALCULATOR
    static void RunCalculator()
    {
        Console.WriteLine("--- BÀI TẬP 1: CALCULATOR ---");
        Console.Write("Nhập số a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập phép toán (+,-,*,/,%): ");
        char op = char.Parse(Console.ReadLine());

        string kq = op switch
        {
            '+' => $"{a + b:F2}",
            '-' => $"{a - b:F2}",
            '*' => $"{a * b:F2}",
            '/' when b == 0 => "Lỗi: Không thể chia cho 0!",
            '/' => $"{a / b:F2}",
            '%' when b == 0 => "Lỗi: Không thể chia cho 0!",
            '%' => $"{a % b:F2}",
            _ => "Lỗi: Không tồn tại phép toán!"
        };
        Console.WriteLine($"Kết quả: {kq}");
    }
    #endregion

    #region BÀI TẬP 2: PHƯƠNG TRÌNH BẬC 2
    static void RunQuadraticEquation()
    {
        Console.WriteLine("--- BÀI TẬP 2: GIẢI PHƯƠNG TRÌNH BẬC 2 ---");
        Console.Write("Nhập số a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhập số b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Nhập số c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Phương trình có vô số nghiệm." : "Vô nghiệm.");
            }
            else
            {
                Console.WriteLine($"Phương trình có 1 nghiệm x = {-c / b:F2}");
            }
        }
        else
        {
            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm: x1 = {x1:F2}, x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                Console.WriteLine($"Phương trình có nghiệm kép x = {-b / (2 * a):F2}");
            }
            else
            {
                Console.WriteLine("Phương trình vô nghiệm.");
            }
        }
    }
    #endregion

    #region BÀI TẬP 3: SỐ NGUYÊN TỐ & FIBONACCI
    static void RunPrimeAndFibonacci()
    {
        Console.WriteLine("--- BÀI TẬP 3: SỐ NGUYÊN TỐ & FIBONACCI ---");
        Console.Write("Nhập vào số nguyên dương N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write(IsPrime(n) ? $"{n} là Số nguyên tố. " : $"{n} KHÔNG là Số nguyên tố. ");
        Console.WriteLine(IsPerfectNumber(n) ? $"{n} là Số hoàn hảo!" : $"{n} KHÔNG là Số hoàn hảo.");

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
            if (number % i == 0) sum += i;
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
            if (i == 0) Console.Write(f0);
            else if (i == 1) Console.Write($", {f1}");
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
    #endregion
}
