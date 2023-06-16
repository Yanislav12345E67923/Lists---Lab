namespace _02._Gauss__Trick;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int count = list.Count;
        for (int i = 0; i < count / 2; i++)
        {
            list[i] += list[count - 1 - i];
            list.RemoveAt(count - 1 - i);
        }

        Console.WriteLine(string.Join(' ', list));
    }
}

