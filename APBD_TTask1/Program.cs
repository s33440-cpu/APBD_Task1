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
            if (values.Length == 0) return 0;
            return values.Average();
            //useless message
        }

        //useless message 3
        public static int CalculateMin(int[] values)
        {
            if (values.Length == 0) return int.MaxValue;
            int min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min) min = values[i];
            }
            return min;
            //useless message 2
        }
}