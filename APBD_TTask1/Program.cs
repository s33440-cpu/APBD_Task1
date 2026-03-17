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