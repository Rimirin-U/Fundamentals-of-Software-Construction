namespace HW1
{
    class Calc
    {
        public int[] getPrimeFactors(int num, out int factorNum)
        {
            factorNum = 0;//记录质因数个数
            int[] factors = new int[num];//质因数数组（初始化时比较长）
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0 && isPrime(i))//是质因数
                {
                    factors[factorNum] = i;
                    factorNum++;
                }
            }
            int[] returnArray = new int[factorNum];
            //构建返回用数组
            for (int i = 0; i < factorNum; i++) returnArray[i] = factors[i];
            return returnArray;
        }

        private bool isPrime(int num)
        {
            //判断正整数num是否为质数
            if (num <= 1) return false;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int num = Convert.ToInt32(Console.ReadLine());
            int factorNum;
            //计算
            int[] primeFactors = calc.getPrimeFactors(num,out factorNum);
            //输出
            for(int i = 0; i < factorNum; i++)
            {
                Console.Write($"{primeFactors[i]} ");
            }
        }
    }
}