using System;

namespace _00.Demo
{
    internal class Program
    {
        public delegate void WorkPerformedHandler(int hours, WorkType workType);
        static void Main(string[] args)
        {
            WorkPerformedHandler w = ManagerWorkPerformed;

            w(2,WorkType.Admin);
/*
            WorkPerformedHandler w1 = ManagerWorkPerformed;
            w += w1;
            w(2, WorkType.User);*/
        }

        public static void ManagerWorkPerformed(int workHours, WorkType workType)
        {
            Console.WriteLine($"{workType} worked {workHours} hours.");
        }
    }
}
