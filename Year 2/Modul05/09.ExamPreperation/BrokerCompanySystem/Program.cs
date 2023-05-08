
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using BrokerCompanySystem.Buildings;

namespace BrokerCompanySystem
{
    internal class Program
    {
        static void Main()
        {
            List<string> args = Console.ReadLine().Split("*").ToList();
            CompanyController companyController = new CompanyController();

            StreamWriter streamWriter = new StreamWriter("../../../output.txt");
            using (streamWriter)
            {
                while (args[0] != "Shutdown")
                {
                    try
                    {
                        string command = args[0];
                        args.RemoveAt(0);
                        switch (command)
                        {
                            case "CreateCompany":
                                streamWriter.WriteLine(companyController.CreateCompany(args));
                                break;
                            case "RegisterBuilding":
                                streamWriter.WriteLine(companyController.RegisterBuilding(args));
                                break;
                            case "RegisterBroker":
                                streamWriter.WriteLine(companyController.RegisterBroker(args));
                                break;
                            case "RentBuilding":
                                streamWriter.WriteLine(companyController.RentBuilding(args));
                                break;
                            case "CompanyInfo":
                                streamWriter.WriteLine(companyController.CompanyInfo(args));
                                break;
                        }

                        args = Console.ReadLine().Split("*").ToList();
                    }
                    catch (Exception ex)
                    {
                        streamWriter.WriteLine(ex.Message);

                    }

                }

                streamWriter.WriteLine(companyController.Shutdown());
            }
        }
    }
}
