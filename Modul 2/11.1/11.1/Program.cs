using System;
using System.Linq;
namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int nLine = int.Parse(Console.ReadLine());

            for (int i = 0; i < nLine; i++)
            {
                var func = Console.ReadLine().Split(' ').ToArray();
                if (func[0] == "Reverse")
                {
                    arr = arr.Reverse().ToArray();
                }
                else if (func[0] == "Distinct")
                {

                    arr = arr.Distinct().ToArray();

                }
                else if (func[0] == "Replace")
                {
                    int index = int.Parse(func[1]);
                    var str = func[2];

                    arr[index] = str;
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
