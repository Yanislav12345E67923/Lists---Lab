namespace _01._Sum_Adjacent_Equal_Numbers;
class Program
{
    static void Main(string[] args)
    {
        List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

        bool doIt = true;        
        while (doIt)
        {
            doIt = false;
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list.RemoveAt(i+1);
                    list[i] *= 2;
                    doIt = true;
                    break;
                }
            }
        }
        Console.WriteLine(string.Join(" ", list));
    }
}

