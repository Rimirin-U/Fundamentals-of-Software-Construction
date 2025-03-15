namespace HW2
{
    public delegate void ClockEventHandler(int time);
    public class Clock
    {
        public event ClockEventHandler Tick;
        public event ClockEventHandler Alarm;

        private List<int> timeSet;//响铃时刻
        private int time;

        public Clock()
        {
            timeSet = new List<int>();
            time = 0;
        }
        public void AddAlarmTime(int t)
        {
            timeSet.Add(t);
        }
        public void Run()
        {
            //时间从0s开始；无限运行
            for (int i = 0; ; i++)
            {
                Tick(i);
                foreach (int j in timeSet)
                {
                    if (i == j) Alarm(i);
                }
                Thread.Sleep(1000);
            }
        }

    }
    internal class Program
    {
        static void showAlarmInfo(int time) { Console.WriteLine($"*** Alarm: {time}s ***"); }
        static void showTickInfo(int time) { Console.WriteLine($"Tick: {time}s"); }
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.Alarm += Program.showAlarmInfo;
            myClock.Tick += Program.showTickInfo;
            myClock.AddAlarmTime(2);
            myClock.AddAlarmTime(5);
            myClock.AddAlarmTime(7);
            myClock.AddAlarmTime(10);
            myClock.AddAlarmTime(15);
            myClock.AddAlarmTime(20);
            myClock.Run();
        }
    }
}