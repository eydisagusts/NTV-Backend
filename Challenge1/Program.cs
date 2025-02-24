namespace Challenge1;

class Recursion
{
    static bool is_increasing(List<int> list)
    {
        if (list.Count <= 1)
        {
            return true;
        }

        if (list[0] > list[1])
        {
            return false;
        }

        return is_increasing(list.GetRange(1, list.Count - 1));
    } 
    
    static void Main()
    {
        Console.Write("(1, 2, 3, 4): ");
        Console.WriteLine(is_increasing(new List<int> {1, 2, 3, 4}));
        Console.Write("(1, 3, 2, 4): ");
        Console.WriteLine(is_increasing(new List<int> {1, 3, 2, 4}));
    }
}