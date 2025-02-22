using System.Runtime.ConstrainedExecution;

namespace HWConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            char op = Convert.ToChar(Console.Read());
            double ans;
            if (op == '-') ans = a - b;
            else if (op == '*') ans = a * b;
            else if (op == '/') ans = a / b;
            else ans = a + b;
            Console.WriteLine(ans);
        }
    }
}