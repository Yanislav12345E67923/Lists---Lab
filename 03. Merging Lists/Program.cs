namespace _03._Merging_Lists;
class Program
{
    static void Main(string[] args)
    {
        List<int> one = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> two = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        List<int> output = new List<int>();
        if (one.Count > two.Count)
        {
            for (int i = 0; i < one.Count; i++)
            {
                try
                {
                    output.Add(one[i]);
                }catch{ }
                try
                {
                    output.Add(two[i]);
                }
                catch { }                
            }
        }
        else
        {
            for (int i = 0; i < two.Count; i++)
            {
                try
                {
                    output.Add(one[i]);
                }
                catch { }
                try
                {
                    output.Add(two[i]);
                }
                catch { }
            }
        }

        Console.WriteLine(string.Join(' ', output));
    }
}

