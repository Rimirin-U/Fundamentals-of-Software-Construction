using System.Collections;
using System.Reflection;

namespace HW4
{
    class MyIO
    {
        public int[][] ReadMatrix()
        {
            //输入矩阵 空格分隔 空行为止
            ArrayList matrix = new ArrayList();
            //循环读入
            bool over = false;
            while (!over)
            {
                try
                {
                    string? inputRow = Console.ReadLine();//接收输入的一行
                    int[] numOfRow;//一行的数字
                    if (inputRow is string && inputRow != "") numOfRow =
                            Array.ConvertAll<string, int>(inputRow.Split(' ', StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
                    else throw new Exception();
                    //以空格分割为string[]后转为int[]
                    matrix.Add(numOfRow);
                }
                catch (Exception)
                {
                    break;
                }
            }
            //待修改：转换为二维数组
            int rows = matrix.Count;
            int columns = ((int[])matrix[0]).Length;
            int[][] ret = new int[rows][];
            for(int i = 0; i < rows; i++)
            {
                int[] row = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    row[j] = ((int[])matrix[i])[j];
                }
                ret[i] = row;
            }
            return ret;
        }
    }

    class Toeplitz
    {
        public bool IsToeplitz(int[][] matrix)
        {
            //获取行列数
            int rows, columns;
            rows = matrix.GetLength(0);
            columns = matrix[0].GetLength(0);
            /*
             0 1 2 3
             0 1 2 3
             0 1 2 3
            */
            //matrix[x][y]
            bool ok = true;//是Toeplitz Matrix
            for (int y = rows - 1; y < columns; y++)
            {
                int num = matrix[0][y];//这一个对角线的值
                for (int x = 1; x < rows; x++)
                {
                    if (matrix[x][y - x] != num)//判断对角线是否相等
                    {
                        ok = false; break;
                    }
                }
                if (!ok) break;
            }
            return ok;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix;
            MyIO myIO = new MyIO();
            Toeplitz check = new Toeplitz();
            //读入矩阵
            matrix = myIO.ReadMatrix();
            //检查是否是Toeplitz Matrix
            bool isTMatrix = check.IsToeplitz(matrix);
            //输出
            if (isTMatrix) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
    }
}