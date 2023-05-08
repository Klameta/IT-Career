using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.Village
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            List<string> list = Console.ReadLine().Split(":").ToList();
            StreamWriter streamWriter = new StreamWriter("../../output.txt");

            using (streamWriter)
            {

                while (list[0] != "End")
                {
                    try
                    {


                        var command = list[0];
                        list = list.Skip(1).ToList();

                        switch (command)
                        {
                            case "Village":
                                controller.ProcessVillageCommand(list);
                                break;
                            case "Settle":

                                break;
                            case "Rebel":

                                break;
                            case "Day":

                                break;
                            case "Attack":

                                break;
                            case "Info":

                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        streamWriter.WriteLine(ex.Message);
                        throw;
                    }

                    list = Console.ReadLine().Split(":").ToList();

                }
            }
        }
    }
}
