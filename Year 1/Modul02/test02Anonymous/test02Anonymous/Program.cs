using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Numerics;
namespace test02Anonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            int nSites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            long securityToken = 1;
            decimal totalloss = 0;
            List<string> sites = new List<string>();

            for (int i = 0; i < nSites; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                sites.Add($"{input[0]} ");

                totalloss += long.Parse(input[1]) * decimal.Parse(input[2]);


                securityToken *= securityKey;
            }

            for (int i = 0; i < nSites; i++)
            {
                Console.WriteLine(sites[i]);
            }

            Console.WriteLine($"Total Loss: {totalloss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(new BigInteger(securityKey), nSites)}");


        }

    }
}
