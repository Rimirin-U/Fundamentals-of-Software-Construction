namespace CSharpTest
{
    public interface IBase
    {
        public static int i = 0;
        public static void Ipp()
        {
            i++;
        }
    }

    public class C1: IBase
    {

    }

    public class C2 : IBase
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}