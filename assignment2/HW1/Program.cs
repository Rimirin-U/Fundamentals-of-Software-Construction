using System.Collections;

namespace HW1
{
    //algorithm
    class Calc
    {
        public int[] GetPrimeFactors(int num)
        {
            ArrayList factors = new ArrayList();
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    factors.Add(i);
                    while (num % i == 0) num /= i;//连除法
                }
            }
            //构建返回用数组
            int[] ret = (int[])factors.ToArray(typeof(int));
            return ret;
        }
    }

    //IO
    class MyIO
    {
        public int GetNum()
        {
            int num;
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("illegal input");
                    continue;
                }
                break;
            }
            return num;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            MyIO myIO = new MyIO();
            int num = myIO.GetNum();
            //计算
            int[] primeFactors = calc.GetPrimeFactors(num);
            //输出
            foreach (int i in primeFactors)
            {
                Console.Write($"{i} ");
            }
        }
    }
}