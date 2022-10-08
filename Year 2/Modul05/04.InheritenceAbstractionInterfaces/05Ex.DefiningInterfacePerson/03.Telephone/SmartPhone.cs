using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Telephone
{
    class SmartPhone : ICalling, IEthernet
    {
        private List<string> numbers = new List<string>();
        private List<string> sites = new List<string>();

        public SmartPhone(List<string> numbers, List<string> sites)
        {
            Numbers = numbers;
            Sites = sites;
        }

        public List<string> Numbers { get => numbers; set => numbers = value; }
        public List<string> Sites { get => sites; set => sites= value; }

        public void Browsing()
        {
            bool valid = true;
            foreach (var site in Sites)
            {
                if (site.Any(char.IsDigit))
                {
                    Console.WriteLine("Unvalid URL!");
                }
                else
                {
                    Console.WriteLine($"Browsing: {site}");
                }
            }
        }

        public void Call()
        {
            foreach (var number in Numbers)
            {
                if (!number.Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    Console.WriteLine($"Calling...{number}");
                }
            }
        }
    }
}
