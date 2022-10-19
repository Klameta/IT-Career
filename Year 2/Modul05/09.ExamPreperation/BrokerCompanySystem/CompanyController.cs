using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BrokerCompanySystem.Buildings;

namespace BrokerCompanySystem
{
    public class CompanyController
    {
        SortedDictionary<string, Company> companyDic = new SortedDictionary<string, Company>();
        public string CreateCompany(List<string> args)
        {
            string name = args[0];

            if (!companyDic.ContainsKey(name))
            {
                companyDic.Add(name, new Company(name));
                return $"Company {name} was successfully registerd in the system!";
            }
            return $"Company {name} is already registered!";
        }

        public string RegisterBuilding(List<string> args)
        {
            string type = args[0];
            string name = args[1];
            string city = args[2];
            int starts = int.Parse(args[3]);
            double rentAmount = double.Parse(args[4]);
            string companyName = args[5];


            if (!companyDic.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            if (companyDic[companyName].GetBuildingByName(name) != null) //checking if buildings has buikding by name
            {
                return $"Building {name} is already registered in {companyName}!";
            }
            Building building = null;
            if (type == "Residence") building = new Residence(name, city, starts, rentAmount);
            if (type == "Hotel") building = new Hotel(name, city, starts, rentAmount);
            if (type == "Business") building = new Business(name, city, starts, rentAmount);
            companyDic[companyName].AddBuilding(building);

            return $"Building {name} was successfully registerd in {companyName} catalog!";


        }

        public string RegisterBroker(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            string city = args[2];
            string companyName = args[3];

            if (!companyDic.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            if (companyDic[companyName].GetBrokerByName(name) != null) //checking if brokers has broker by name
            {
                return $"Broker {name} is already part of {companyName}!";
            }

            Broker broker = new Broker(name, age, city);
            companyDic[companyName].AddBroker(broker);
            return $"Broker {name} was successfully hired in {companyName}!";
        }

        public string RentBuilding(List<string> args)
        {
            string companyName = args[0];
            string buildingName = args[1];
            string brokerName = args[2];

            if (!companyDic.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            if (companyDic[companyName].GetBuildingByName(buildingName) == null)
            {
                return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
            }
            if (!companyDic[companyName].GetBuildingByName(buildingName).IsAvailable)
            {
                return $"Building: {buildingName} cannot be rented!";
            }
            if (companyDic[companyName].GetBrokerByName(brokerName) == null)
            {
                return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
            }

            var building = companyDic[companyName].GetBuildingByName(buildingName);
            var broker = companyDic[companyName].GetBrokerByName(brokerName);
            var bonus = broker.ReceiveBonus(building);
            building.IsAvailable = false;

            return $"Successfully rented {buildingName}!" +
                $"\nBroker {brokerName} earned {bonus}!";
        }

        public string CompanyInfo(List<string> args)
        {
            string companyName = args[0];
            var company = companyDic[companyName];
            if (company == null)
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }

            return company.ToString();
        }

        public string Shutdown()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Companies: {companyDic.Count}");
            foreach (var company in companyDic.Values)
            {
                stringBuilder.AppendLine(company.ToString());
            }

            return stringBuilder.ToString().TrimEnd();
        }

    }
}
