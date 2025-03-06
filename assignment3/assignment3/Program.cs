using System.Reflection.Metadata.Ecma335;

namespace assignment3
{
    //图形：抽象类
    abstract class Shape
    {
        public abstract double GetArea();
        protected abstract bool IsLegal();
    }

    //矩形
    class Rectangle : Shape
    {
        private double _a;
        private double _b;

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
                if (!IsLegal()) throw new Exception("Illegal Rectangle.");
            }
        }

        //构造函数
        public Rectangle(double x, double y)
        {
            a = x;
            b = y;
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
                if (!IsLegal()) throw new Exception("Illegal Shape")
            }
        }

        public Square(double ain)
        {
            a = ain;
        }
        public override double GetArea()
        {
            return _a * _a;
        }
        protected override bool IsLegal()
        {
            if (_a >= 0) return true;
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
                if (!IsLegal()) throw new Exception("Illegal Shape");
            }
        }
        public double b
        {
            get { return _b; }
            set
            {
                _b = value;
                if (!IsLegal()) throw new Exception("Illegal Shape");
            }
        }
        public double c
        {
            get { return _c; }
            set
            {
                _c = value;
                if (!IsLegal()) throw new Exception("Illegal Shape");
            }
        }

        public Triangle(double x, double y, double z)
        {
            a = x; b = y; c = z;
        }
        public override double GetArea()
        {
            throw new NotImplementedException();
        }
        protected override bool IsLegal()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writing Shit Code!");
        }
    }
}