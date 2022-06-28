using System;

namespace _17.Aft_03_22._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string currencyWantedToInvestIn = Console.ReadLine();
            double EUR = double.Parse(Console.ReadLine());
            double currencySum = 0.00;
            if (EUR > 1000)
            {
                EUR = EUR + EUR * 0.10;
            }

            switch (currencyWantedToInvestIn)
            {
                case "XRP":
                    currencySum = EUR / 0.22;
                    if (currencySum >= 80)
                    {


                        if (currencySum > 1000 && currencySum < 2500)
                        {

                            currencySum = currencySum + currencySum * 0.05;

                        }
                        else if (currencySum >= 2500)
                        {
                            currencySum = currencySum + currencySum * 0.10;
                        }
                        Console.WriteLine("Successfully purchased {0:f3} {1}", currencySum, currencyWantedToInvestIn);
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    break;
                case "BTC":
                    currencySum = EUR / 6400;
                    if (currencySum >= 0.001)
                    {


                        if (currencySum > 10)
                        {
                            currencySum = currencySum + currencySum * 0.02;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    Console.WriteLine("Successfully purchased {0:f3} {1}", currencySum, currencyWantedToInvestIn);
                    break;
                case "ETH":
                    currencySum = EUR / 250;
                    if (currencySum < 0.0099)
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    Console.WriteLine("Successfully purchased {0:f3} {1}", currencySum, currencyWantedToInvestIn);
                    break;
                default:
                    Console.WriteLine($"EUR to {currencyWantedToInvestIn} is not supported.");
                    break;
            }

        }
    }
}
