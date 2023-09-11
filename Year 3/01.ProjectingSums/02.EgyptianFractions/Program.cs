namespace _02.EgyptianFractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            List<int> denode = new List<int>();

            Console.Write($"{p}/{q} = 1/");
            while (p > 1)
            {
                int r = (p + q) / p;
                denode.Add(r);

                p = p * r - q;
                q *= r;

                int nod = NOD(p, q);

                p /= nod;
                q /=  nod;
            }
            denode.Add(q);

            Console.WriteLine(string.Join(" + 1/", denode));
        }

        private static int NOD(int p, int q)
        {
            while (q != 0)
            {
                int r = p % q;
                p = q;
                q = r;
            }
            return p;
        }
    }
}