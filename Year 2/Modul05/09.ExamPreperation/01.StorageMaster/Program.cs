using _01.StorageMaster.Products;
using System;
using System.Linq;
using System.IO;

namespace _01.StorageMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArgs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StorageMaster storageMaster = new StorageMaster();

            StreamWriter streamWriter = new StreamWriter("../../../output.txt");
            using (streamWriter)
            {

                while (cmdArgs[0] != "END")
                {
                    try
                    {

                        switch (cmdArgs[0])
                        {
                            case "AddProduct":
                                streamWriter.WriteLine(storageMaster
                                    .AddProduct(cmdArgs[1], double.Parse(cmdArgs[2])));

                                break;
                            case "RegisterStorage":
                                streamWriter.WriteLine(storageMaster
                                    .RegisterStorage(cmdArgs[1], cmdArgs[2]));
                                break;
                            case "SelectVehicle":
                                streamWriter.WriteLine(storageMaster
                                    .SelectVehicle(cmdArgs[1], int.Parse(cmdArgs[2])));
                                break;
                            case "LoadVehicle":
                                streamWriter.WriteLine(storageMaster
                                    .LoadVehicle(cmdArgs.Skip(1)));
                                break;
                            case "SendVehicleTo":
                                streamWriter.WriteLine(storageMaster
                                    .SendVehicleTo(cmdArgs[1], int.Parse(cmdArgs[2]), cmdArgs[3]));
                                break;
                            case "UnloadVehicle":
                                streamWriter.WriteLine(storageMaster
                                    .UnloadVehicle(cmdArgs[1], int.Parse(cmdArgs[2])));
                                break;
                            case "GetStorageStatus":
                                streamWriter.WriteLine(storageMaster
                                    .GetStorageStatus(cmdArgs[1]));
                                break;
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        throw;
                    }
                    cmdArgs = Console.ReadLine()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                }
            }
        }
    }
}
