using System.Linq;

namespace _07._List_Manipulation_Advanced;
class Program
{
    static void Main(string[] args)
    {
        List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        List<double> original = new List<double>();
        for (int i = 0; i < list.Count; i++)
        {
            original.Add(list[i]);
        }
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "end")
        {
            string type = command.Split(' ')[0];

            if (type == "Add")
            {
                list.Add(int.Parse(command.Split(' ')[1]));
            }                
            else if (type == "Remove")
            {
                list.Remove(int.Parse(command.Split(' ')[1]));
            }                
            else if (type == "RemoveAt")
            {
                list.RemoveAt(int.Parse(command.Split(' ')[1]));
            }                
            else if (type == "Insert")
            {
                int index = int.Parse(command.Split(' ')[1]);
                list.Insert(int.Parse(command.Split(' ')[2]), index);
            }
            else if (type == "Contains")
            {
                bool ifContains = list.Contains(int.Parse(command.Split(' ')[1]));

                if (ifContains)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No such number");
            }
            else if (type == "PrintEven")
            {
                List<double> evens = new List<double>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        evens.Add(list[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", evens));
            }
            else if (type == "PrintOdd")
            {
                List<double> odds = new List<double>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        odds.Add(list[i]);
                    }
                }
                Console.WriteLine(string.Join(" ", odds));
            }
            else if (type == "GetSum")
            {
                Console.WriteLine(list.Sum());
            }
            else if (type == "Filter")
            {
                string mathsSymbol = command.Split(' ')[1];
                List<double> results = new List<double>();
                double number = double.Parse(command.Split(' ')[2]);
                if (mathsSymbol == ">")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] > number)
                        {
                            results.Add(list[i]);
                        }
                    }
                }
                else if (mathsSymbol == "<")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < number)
                        {
                            results.Add(list[i]);
                        }
                    }
                }
                else if (mathsSymbol == ">=")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] >= number)
                        {
                            results.Add(list[i]);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] <= number)
                        {
                            results.Add(list[i]);
                        }
                    }
                }
                Console.WriteLine(string.Join(" ", results));
            }
        }

        if (original.Count == list.Count)
        {
            bool doIt = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != original[i])
                {
                    doIt = false;
                }
            }
            if (!doIt)
                Console.WriteLine(string.Join(" ", list));
        }
        else
        {
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
