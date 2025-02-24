namespace Challenge3
{
    class Challenge3
    {
        static List<int> intersection(List<int> lst1, List<int> lst2)
        {
            if (lst1.Count == 0 || lst2.Count == 0)
            {
                return new List<int>();
            }
            
            if (lst2.Contains(lst1[0]))
            {
                List<int> result = intersection(lst1.GetRange(1, lst1.Count - 1), lst2);
                if (!result.Contains(lst1[0]))
                {
                    result.Insert(0, lst1[0]);
                }
                return result;
            }
            else
            {
                return intersection(lst1.GetRange(1, lst1.Count - 1), lst2);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("[{0}]", string.Join(", ", intersection(new List<int> { 1, 2, 3 }, new List<int> { 2, 4, 6 })));
            Console.WriteLine("[{0}]", string.Join(", ", intersection(new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 })));
            Console.WriteLine("[{0}]", string.Join(", ", intersection(new List<int> { 2, 3, 2, 4 }, new List<int> { 2, 2, 4 })));
        }
    }
}