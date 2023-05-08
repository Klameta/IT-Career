using System;

namespace exam_1_2_05._12._2021
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double mStart = double.Parse(Console.ReadLine());
            double presentFst = double.Parse(Console.ReadLine());
            double presentSnd = 0.2 * presentFst;
            double presentTrd = 0.7 * presentSnd;
            double presentFrth = 0.5 * presentSnd;
            double mSum = presentFrth + presentFst + presentSnd + presentTrd;
            if (mStart >= mSum)
            {
                Console.WriteLine($"Yes! {(mStart-mSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No! {(mSum-mStart):F2} leva needed.");
            }
        }
    }
}
