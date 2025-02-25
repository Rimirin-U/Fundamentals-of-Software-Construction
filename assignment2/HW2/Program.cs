using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace HW2
{
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
    internal class Program
    {
        static void Main(string[] args)
        {
            //偷用ArrayList
            ArrayList inList = new ArrayList();
            ArrayCalc arrayCalc = new ArrayCalc();
            bool over = false;
            while (!over)
            {
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    inList.Add(n);
                }
                catch (Exception)
                {
                    break;
                }
            }
            //转换为数组
            int[] arr = (int[])inList.ToArray(typeof(int));
            int max, min, sum;
            double mean;
            max = arrayCalc.Max(arr);
            min = arrayCalc.Min(arr);
            mean = arrayCalc.Mean(arr);
            sum = arrayCalc.Sum(arr);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(mean);
        }
    }
}