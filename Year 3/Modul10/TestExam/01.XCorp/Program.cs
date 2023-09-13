namespace _01.XCorp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vaucherCnt = 0;

            int inputDays = int.Parse(Console.ReadLine());
            int daysMoney = inputDays * 20;

            while (daysMoney != 0)
            {
                if (daysMoney >= 100) daysMoney -= 100;
                else daysMoney -= 20;
                vaucherCnt++;
            }

            Console.WriteLine(vaucherCnt);
        }
    }
}