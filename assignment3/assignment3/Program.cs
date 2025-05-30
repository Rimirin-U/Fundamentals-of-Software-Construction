﻿using System.Reflection.Metadata.Ecma335;

namespace assignment3
{
    //图形：抽象类
    abstract class Shape
    {
        //面积计算
        public abstract double GetArea();
        //判断形状是否合法（在创建及修改图形时检查）
        protected abstract bool IsLegal();
    }

    //矩形
    class Rectangle : Shape
    {
        //图形参数
        private double _a;
        private double _b;

        //获取/修改图形参数
        public double a
        {
            get => _a;
            set
            {
                _a = value;
                if (!IsLegal()) throw new Exception("Illegal Rectangle");
            }
        }
        public double b
        {
            get => _b;
            set
            {
                _b = value;
                if (!IsLegal()) throw new Exception("Illegal Rectangle");
            }
        }

        //构造函数
        public Rectangle(double xin, double yin)
        {
            _a = xin;
            _b = yin;
            if (!IsLegal()) throw new Exception("Illegal Rectangle");
            Console.WriteLine($"Rectangle created:\t{_a}\t{_b}");
        }
        //面积计算
        public override double GetArea()
        {
            return _a * _b;
        }
        //是否合法
        protected override bool IsLegal()
        {
            if (_a > 0 && _b > 0) return true;
            else return false;
        }
    }
    //正方形
    class Square : Shape
    {
        private double _a;
        public double a
        {
            get => _a;
            set
            {
                _a = value;
                if (!IsLegal()) throw new Exception("Illegal Square");
            }
        }

        public Square(double ain)
        {
            _a = ain;
            if (!IsLegal()) throw new Exception("Illegal Square");
            Console.WriteLine($"Square created:\t\t{_a}");
        }
        public override double GetArea()
        {
            return _a * _a;
        }
        protected override bool IsLegal()
        {
            if (_a > 0) return true;
            else return false;
        }
    }
    //三角形
    class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;
        public double a
        {
            get { return _a; }
            set
            {
                _a = value;
                if (!IsLegal()) throw new Exception("Illegal Triangle");
            }
        }
        public double b
        {
            get { return _b; }
            set
            {
                _b = value;
                if (!IsLegal()) throw new Exception("Illegal Triangle");
            }
        }
        public double c
        {
            get { return _c; }
            set
            {
                _c = value;
                if (!IsLegal()) throw new Exception("Illegal Triangle");
            }
        }

        public Triangle(double x, double y, double z)
        {
            _a = x; _b = y; _c = z;
            if (!IsLegal()) throw new Exception("Illegal Triangle");
            Console.WriteLine($"Triangle created:\t{_a}\t{_b}\t{_c}");
        }
        public override double GetArea()
        {
            //海伦公式
            double p = (_a + _b + _c) / 2;
            double area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
            return area;
        }
        protected override bool IsLegal()
        {
            return _a > 0 && _b > 0 && _c > 0 && (a + b > c) && (a + c > b) && (b + c > a);
        }
    }

    //工厂类
    class ShapeFactory
    {
        public static Shape? CreateShape(uint type, params double[] length)
        {
            Shape? shape = null;
            try
            {
                switch (type)
                {
                    case 0:
                        {
                            shape = new Rectangle(length[0], length[1]);
                            break;
                        }
                    case 1:
                        {
                            shape = new Square(length[0]);
                            break;
                        }
                    case 2:
                        {
                            shape = new Triangle(length[0], length[1], length[2]);
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Creation failed:\t{e.Message}");
            }
            return shape;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new();
            Random ran = new();
            //随机创建图形
            for (uint i = 0; i < 20; i++)
            {
                double[] length = new double[3];
                //随机产生边长
                for (int j = 0; j < 3; j++)
                {
                    length[j] = Math.Round(ran.NextDouble() * 10, 2);
                }
                //随机产生的有可能不合法
                Console.Write($"{i + 1}\t");
                if (ShapeFactory.CreateShape(i % 3, length) is Shape shape)
                {
                    shapes.Add(shape);
                }
            }
            //计算面积
            int k = 1;
            Console.WriteLine();
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{k}\t{shape.GetType()}\t\t{Math.Round(shape.GetArea(), 4)}");
                k++;
            }
        }
    }
}