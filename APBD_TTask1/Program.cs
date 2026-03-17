Console.WriteLine("Enter a number:");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine(number);
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid number.");
}


List<int> numbers = new List<int> { number, 5, 10, 15 };
double average = StatisticsHelper.CalculateAverage(numbers);
Console.WriteLine($"Average: {average}");
    

public static class StatisticsHelper{
        public static double CalculateAverage(List<int> numbers)
        {
            return numbers.Average();
        }

        public static double CalculateAverage(int[] values)
        {
            //A useless message for a useless commit ;)
            if (values.Length == 0) return 0;
            return values.Average();
        }
}