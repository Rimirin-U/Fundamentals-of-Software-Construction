using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace HW2
{
    //数组操作
    class ArrayCalc
    {
        public int Max(int[] arr)
        {
            int length = arr.Length;
            int max = arr[0];
            if (length == 1) return max;
            for (int i = 1; i < length; i++)
            {
                if (arr[i] > max) max = arr[i];
            }
            return max;
        }
        public int Min(int[] arr)
        {
            int length = arr.Length;
            int min = arr[0];
            if (length == 1) return min;
            for (int i = 1; i < length; i++)
            {
                if (arr[i] < min) min = arr[i];
            }
            return min;
        }
        public double Mean(int[] arr)
        {
            double sum = Sum(arr);
            return sum / arr.Length;
        }
        public int Sum(int[] arr)
        {
            int sum = 0;
            int length = arr.Length;
            for (int i = 0; i < length; i++) sum += arr[i];
            return sum;
        }
    }
    //IO
    class MyIO
    {
        //输入整数数组
        public int[] GetIntArray()
        {
            //提示
            Console.WriteLine("输入整数数组（回车分隔）");
            //偷用ArrayList
            ArrayList inList = new ArrayList();
            bool over = false;
            //循环读入
            while (!over)
            {
                try
                {
                    string? instr = Console.ReadLine();
                    //检查输入是否为空
                    if (instr == "" || instr is null)
                    {
                        if (inList.Count == 0) throw new Exception("Illegal array: empty");//空数组
                        else break;//输入完成
                    }
                    //转换；检查输入是否合法
                    int n = Convert.ToInt32(instr);
                    inList.Add(n);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            //转换为数组
            int[] arr = (int[])inList.ToArray(typeof(int));
            return arr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayCalc arrayCalc = new ArrayCalc();
            MyIO myIO = new MyIO();
            int[] arr = myIO.GetIntArray();

            int max, min, sum;
            double mean;
            max = arrayCalc.Max(arr);
            min = arrayCalc.Min(arr);
            mean = arrayCalc.Mean(arr);
            sum = arrayCalc.Sum(arr);

            Console.WriteLine($"max  = {max}");
            Console.WriteLine($"min  = {min}");
            Console.WriteLine($"sum  = {sum}");
            Console.WriteLine($"mean = {mean}");
        }
    }
}