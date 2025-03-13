namespace assignment4
{
    public class Node<T>
    {
        public Node<T>? Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T>? head;
        private Node<T>? tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T>? Head { get => head; }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null) { head = tail = n; }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T>? node = head;
            while (node is not null)
            {
                action(node.Data);
                node = node.Next;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //initailize List
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 20; i++) { list.Add(i); }

            //initialize action
            int? max = null, min = null;
            int sum = 0;
            Action<int> action = delegate (int data) { Console.Write($"{data} "); };
            action += delegate (int data)
            {
                if (max is null) max = data;
                else if (data > max) max = data;
            };
            action += delegate (int data)
            {
                if (min is null) min = data;
                else if (data < min) min = data;
            };
            action += delegate (int data) { sum += data; };

            //apply
            list.ForEach(action);
            Console.WriteLine($"\nmax\t{max}\nmin\t{min}\nsum\t{sum}\n");
        }
    }
}