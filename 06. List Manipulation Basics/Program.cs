namespace _06._List_Manipulation_Basics;
class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        string command = string.Empty;
        while ((command = Console.ReadLine()) != "end")
        {
            if (command.Split(' ')[0] == "Add")
                list.Add(int.Parse(command.Split(' ')[1]));
            else if (command.Split(' ')[0] == "Remove")
                list.Remove(int.Parse(command.Split(' ')[1]));
            else if (command.Split(' ')[0] == "RemoveAt")
                list.RemoveAt(int.Parse(command.Split(' ')[1]));
            else if (command.Split(' ')[0] == "Insert")
            {
                int index = int.Parse(command.Split(' ')[1]);
                list.Insert(int.Parse(command.Split(' ')[2]), index);
            }

        }

        Console.WriteLine(string.Join(' ', list));
    }
}

