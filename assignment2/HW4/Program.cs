﻿using System.Collections;
using System.Reflection;

namespace HW4
{
    class MyIO
    {
        public int[,] ReadMatrix()
        {
            //输入矩阵 空格分隔 空行为止
            Console.WriteLine("输入矩阵：空格分隔，每列换行");
            ArrayList matrix = new ArrayList();
            //循环读入
            while (true)
            {
                try
                {
                    string? inputRow = Console.ReadLine();//接收输入的一行
                    int[] numOfRow;//一行的数字
                    //接收一行的数字为int[]
                    if (inputRow == "" || inputRow is null) break;//空行为止
                    else numOfRow = Array.ConvertAll<string, int>(
                                inputRow.Split(' ', StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
                    //以空格分割为string[]后转为int[]
                    matrix.Add(numOfRow);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message} This row was ignored.");
                }
            }

            //检查matrix合法性
            int rows = matrix.Count;
            int columns = 0;
            try
            {
                if (rows == 0) throw new Exception("Illegal matrix: no rows.");
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i] is not int[] row || row is null || row == Array.Empty<int>())
                        throw new Exception("Illegal matrix: there is/are empty row(s).");//确保没有空行（真的会有这种情况吗？）
                                                                                          //——向D指导学习了"模式匹配"
                    else if (i == 0) columns = row.Length;
                    else if (row.Length != columns) throw new Exception("Illegal matrix: rows' length not equal.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message} Please retype.");
                return ReadMatrix();//?!
            }

            //输出二维数组
            int[,] ret = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i] is int[] row) ret[i, j] = row[j];
                }
            }
            return ret;
        }
    }

    class Toeplitz
    {
        public bool IsToeplitz(int[,] matrix)
        {
            //获取行列数
            int rows, columns;
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);
            /* 
             矩阵示例：（三行四列）
             * * 0 1 2 3 * *
             * * 0 1 2 3 * *
             * * 0 1 2 3 * *
             matrix[x][y] for 第x行第y列
            */

            //检验
            bool ok = true;//矩阵合法
            for (int y = 1 - rows; y < columns; y++)//遍历每条对角线 y为该对角线起点的列坐标 初始状态相当于上面矩阵左上角的*
            {
                int? dia = null;//对角线每个元素相等的值
                for (int x = 0; x < rows; x++)//遍历一条对角线中的每个元素
                {
                    int realColumn = y + x;//计算真实列坐标
                    if (realColumn < 0 || realColumn >= columns) continue;//不合法列坐标——这条对角线不完整（含有*）
                    if (dia is null) dia = matrix[x, realColumn];//是该对角线中第一个被遍历到的元素：记录值
                    else if (matrix[x, realColumn] != dia)//若不是第一个被遍历到的元素：与该对角线的值比较，若不相等
                    {
                        ok = false;
                        break;
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
            int[,] matrix;
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