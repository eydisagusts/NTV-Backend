namespace Challenge2
{
    class Challenge2
    {
        static List<int> filter_greater_than(List<int> lst, int n)
        {
            if (lst.Count == 0)
            {
                return new List<int>();
            }
            
            if (lst[0] > n)
            {
                List<int> result = filter_greater_than(lst.GetRange(1, lst.Count - 1), n);
                result.Insert(0, lst[0]);
                return result;
            }
            else
            {
                return filter_greater_than(lst.GetRange(1, lst.Count - 1), n);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("[{0}]", string.Join(", ", filter_greater_than(new List<int> {1, 2, 3, 4}, 2)));
            Console.WriteLine("[{0}]", string.Join(", ", filter_greater_than(new List<int> {2, 2, 3, 3}, 1)));
            Console.WriteLine("[{0}]", string.Join(", ", filter_greater_than(new List<int> {2, 2, 3, 3}, 4)));
        }
    }
}