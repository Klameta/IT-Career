using System;
using System.Linq;
namespace _11._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var func = Console.ReadLine().Split(' ').ToArray();
            while (func[0] != "END")
            {

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
                    if (index < 0 || index > arr.Length -1 )
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        arr[index] = str;
                    }
                }

                func = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
