using System.Threading;
using System.Timers;

namespace HW2
{
    public delegate void ClockEventHandler(int time);
    public class Clock
    {
        public event ClockEventHandler Tick;
        public event ClockEventHandler Alarm;

        private List<int> timeSet;//响铃时刻
        public int Time { get => time; }
        private int time;
        private System.Timers.Timer Clk;

        public Clock(params int[] alarmTimes)
        {
            timeSet = new List<int>(alarmTimes);
            time = 0;
            //每秒触发一次的定时器
            Clk = new System.Timers.Timer(1000);
            Clk.Elapsed += EventsTrigger;
            Clk.AutoReset = true;
        }

        //负责产生事件
        private void EventsTrigger(object? sender, ElapsedEventArgs e)
        {
            time++;
            Tick(time);
            foreach (int i in timeSet)
            {
                if (i == time) Alarm(time);
            }
        }
        //增加响铃时间
        public void AddAlarmTime(int t)
        {
            timeSet.Add(t);
        }
        //启动闹钟
        public void Run()
        {
            Clk.Start();
            while (true) ;//暂时设为无限运行
        }
    }
    internal class Program
    {
        static void showAlarmInfo(int time) { Console.WriteLine($"*** Alarm: {time}s ***"); }
        static void showTickInfo(int time) { Console.WriteLine($"Tick: {time}s"); }
        static void Main(string[] args)
        {
            Clock myClock = new Clock(new int[4] { 2, 5, 7, 10 });
            myClock.Alarm += Program.showAlarmInfo;
            myClock.Tick += Program.showTickInfo;
            myClock.AddAlarmTime(15);
            myClock.AddAlarmTime(20);
            myClock.Run();
        }
    }
}