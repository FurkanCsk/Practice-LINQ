// Create a Random object to generate random numbers
Random random = new Random();

// Create a list to store 10 random numbers
List<int> numbers = new List<int>();

// Add 10 random numbers between -50 and 50 to the list
for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-50, 51));
}

// Display the list of numbers
Console.WriteLine("Numbers in the list: ");
numbers.ForEach(num => Console.WriteLine(num));

// Find and display even numbers using LINQ
Console.WriteLine("Even numbers: ");
numbers.Where(num => num % 2 == 0).ToList().ForEach(num => Console.WriteLine(num));

// Find and display odd numbers using LINQ
Console.WriteLine("Odd numbers: ");
numbers.Where(num => num % 2 != 0).ToList().ForEach(num => Console.WriteLine(num));

// Find and display negative numbers using LINQ
Console.WriteLine("Negative numbers: ");
numbers.Where(num => num < 0).ToList().ForEach(num => Console.WriteLine(num));

// Find and display positive numbers using LINQ
Console.WriteLine("Positive numbers: ");
numbers.Where(num => num > 0).ToList().ForEach(num => Console.WriteLine(num));

// Find and display numbers between 15 and 22 using LINQ
Console.WriteLine("Numbers between 15 and 22: ");
numbers.Where(num => (num > 15 && num < 22)).ToList().ForEach(num => Console.WriteLine(num));

// Create a new list containing the squares of each number in the original list
var squaredNumbersList = numbers.Select(num => num * num).ToList();

// Display the squared numbers
Console.WriteLine("Squares of the numbers: ");
squaredNumbersList.ForEach(num => Console.WriteLine(num));