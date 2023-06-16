namespace _05._Remove_Negatives_and_Reverse;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < 0)
            {
                list.RemoveAt(i);
                i -= 1;
            }                
        }
        list.Reverse();

        if (list.Count == 0)
            Console.WriteLine("empty");
        else
            Console.WriteLine(string.Join(' ', list));
    }
}

