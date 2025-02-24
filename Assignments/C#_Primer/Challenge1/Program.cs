namespace Assignment1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Please enter a number: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            Console.WriteLine($"The smallest number you entered was: {min}");
            Console.WriteLine($"The largest number you entered was: {max}");
        }
        else
        {
            Console.WriteLine("No numbers entered.");
        }
    }
}