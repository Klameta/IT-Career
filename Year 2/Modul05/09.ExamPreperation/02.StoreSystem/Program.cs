
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _02.StoreSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StoreController controller = new StoreController();
            StringBuilder stringBuilder = new StringBuilder();
            bool isRunning = true;

            while (isRunning)
            {
                List<string> lineArgs = Console.ReadLine().Split(":").ToList();

                string command = lineArgs[0];

                lineArgs = lineArgs.Skip(1).ToList();
                try
                {
                    switch (command)
                    {
                        case "CreateStore":
                            stringBuilder.AppendLine(controller.CreateStore(lineArgs));
                            break;
                        case "ReceiveProduct":
                            stringBuilder.AppendLine(controller.ReceiveProduct(lineArgs));
                            break;
                        case "SellProduct":
                            stringBuilder.AppendLine(controller.SellProduct(lineArgs));
                            break;
                        case "StoreInfo":
                            stringBuilder.AppendLine(controller.StoreInfo(lineArgs));
                            break;
                        case "Shutdown":
                            stringBuilder.AppendLine(controller.Shutdown());
                            isRunning = false;
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    stringBuilder.AppendLine(ex.Message);
                }

            }

            StreamWriter streamWriter = new StreamWriter("../../../output.txt");
            using (streamWriter)
            {
                streamWriter.WriteLine(stringBuilder.ToString().Trim());

            }


        }
    }

}

