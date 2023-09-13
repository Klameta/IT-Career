namespace _05._Jobs
{
    internal class Program
    {
        static List<Activity> activities;
        static void Main(string[] args)
        {
            activities = new List<Activity>();
            List<string> input = new List<string>();
            while ((input = Console.ReadLine().Split().ToList()).FirstOrDefault() != "end")
            {
                string name = input[0];
                int start = int.Parse(input[1]);
                int end= int.Parse(input[1]);

                Activity activity= new Activity(name, start, end);
                activities.Add(activity);
            }

            activities.OrderBy(x => x.End).ToList();

            Activity currActivity = activities.FirstOrDefault();
            Console.WriteLine(currActivity);

            for (int i = 0; i < length; i++)
            {

            }

        }
    }
}