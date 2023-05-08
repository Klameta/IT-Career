using System;
using System.Text;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Type type = typeof(Person);
            Console.WriteLine(type);*/

            /*Type type = Type.GetType("_00.Demo.Person");
            Console.WriteLine(type.Name);

            Person person = new Person();
            type = person.GetType();*/

            Person person = new Person();
            Type type = person.GetType();
            /*Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.BaseType);*/

            /*Type[] interfaces = type.GetInterfaces();
            foreach (var i in interfaces)
            {
                Console.WriteLine(i.Name);
            }*/
            Type sbType = Type.GetType("System.Text.StringBuilder");

            StringBuilder sbInstance = (StringBuilder)Activator.CreateInstance(sbType);
            Console.WriteLine(sbInstance);
            Console.WriteLine(sbInstance.Capacity);

            StringBuilder sbInstcapacity = (StringBuilder)Activator.CreateInstance(sbType, new object[] { 10 });
            Console.WriteLine(sbInstcapacity);
            Console.WriteLine(sbInstcapacity.Capacity);

            StringBuilder sbInstStr = (StringBuilder)Activator.CreateInstance(sbType, new object[] { "gxhhvk" });
            Console.WriteLine(sbInstStr);
            Console.WriteLine(sbInstStr.Capacity);
        }
    }
}
