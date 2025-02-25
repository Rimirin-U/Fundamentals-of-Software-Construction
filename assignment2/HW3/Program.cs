using System.Collections;

namespace HW3
{
    class PrimeCalc
    {
        public int[] Calc(int n)
        {
            bool[] allNum = new bool[n + 1];//n+1个标识位，i为素数时allNum[i]==false
            allNum[0] = true; allNum[1] = true;//0和1不是素数
            for (int filter = 2; filter <= n / 2; filter++)
            {
                int notPrime = filter * 2;
                while (notPrime <= n)
                {
                    allNum[notPrime] = true;//去掉filter的倍数
                    notPrime += filter;
                }
            }
            ArrayList primes = new ArrayList();
            for (int i = 0; i <= n; i++)
            {
                if (!allNum[i]) primes.Add(i);
            }
            return (int[])primes.ToArray(typeof(int));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeCalc primeCalc = new PrimeCalc();
            int[] primes = primeCalc.Calc(100);
            int length = primes.Length;
            for(int i = 0; i < length; i++)
            {
                Console.Write($"{primes[i]} ");
            }
        }
    }
}