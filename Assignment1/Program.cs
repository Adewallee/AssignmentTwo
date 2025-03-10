using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        // Assignment 1- Question 1.1

        Console.Write("Enter a number between 1 and 10: ");
        string input1 = Console.ReadLine();
        bool a = double.TryParse(input1, out double number);

        if (number >= 1 && number <= 10)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }


        // Assignment 1- Question 1.2
        Console.Write("Enter any two numbers");
        string input2 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input2))
        {
            Console.WriteLine("No input provided. Please enter two numbers.");
            return;
        }

        // Split input by space or comma
        string[] numbers = input2.Trim().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Converts strings to double saved as number1 and number2
        if (double.TryParse(numbers[0].Trim(), out double number1) &&
            double.TryParse(numbers[1].Trim(), out double number2))
        {
            double max = Math.Max(number1, number2);
            Console.WriteLine($"The maximum number is: {max}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter any two numbers.");
        }


        // Assignment 1- Question 1.3
        Console.Write("Enter the width of the image: ");
        string widthInput = Console.ReadLine();

        Console.Write("Enter the height of the image: ");
        string heightInput = Console.ReadLine();

        if (double.TryParse(widthInput, out double width) && double.TryParse(heightInput, out double height))
        {
            if (width > height)
            {
                Console.WriteLine("The image is Landscape.");
            }
            else if (height > width)
            {
                Console.WriteLine("The image is Portrait.");
            }
            else
            {
                Console.WriteLine("The image is Square.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numerical values for width and height.");
        }


        // Assignment 1- Question 1.4
        Console.Write("Enter the speed limit (km/hr): ");
        string speedLimitInput = Console.ReadLine();

        Console.Write("Enter the speed of the car (km/hr): ");
        string carSpeedInput = Console.ReadLine();


        if (double.TryParse(speedLimitInput, out double speedLimit) && double.TryParse(carSpeedInput, out double carSpeed))
        {
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                double excessSpeed = carSpeed - speedLimit;
                double demeritPoints = excessSpeed / 5; // 1 point per 5 km/hr over the limit

                Console.WriteLine($"Demerit Points: {demeritPoints}");

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers for speed limit and car speed.");
        }



        // Assignment 2- Question2.1
        int count = 0;

        for (int num = 1; num <= 100; num++)
        {
            if (num % 3 == 0)
            {
                count++;
            }
        }

        Console.WriteLine($"Count of numbers divisible by 3 between 1 and 100 is: {count}");


        // Assignment 2- Question2.2
        int sum = 0;

        while (true)
        {
            Console.Write("Enter a number or type 'ok' to exit: ");
            string input3 = Console.ReadLine();

            if (input3.ToLower() == "ok")
                break;

            sum += int.Parse(input3);
        }

        Console.WriteLine($"Total sum of entered numbers: {sum}");



        // Assignment 2- Question2.3
        Console.Write("Enter a number: ");
        int input4 = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (int i = input4; i >= 1; i--)
        {
            factorial *= i;
        }

        Console.WriteLine($"{input4}! = {factorial}");



        // Assignment 2- Question2.4
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // Picks a random number between 1 and 10
        int attempts = 4;
        bool isGuessed = false;

        Console.WriteLine($"(Secret number: {secretNumber})"); // For testing purposes

        Console.WriteLine("Guess a number between 1 and 10. You have 4 chances.");

        for (int i = 0; i < attempts; i++)
        {
            Console.Write($"Attempt {i + 1}: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("You won!");
                isGuessed = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong guess. Try again.");
            }
        }

        if (!isGuessed)
        {
            Console.WriteLine($"You lost! The correct number was {secretNumber}.");
        }



        // Assignment 2- Question2.5
        Console.Write("Enter a series of numbers separated by a comma: ");
        string input5 = Console.ReadLine();
        int[] numberSeries = input5.Split(',').Select(num => int.Parse(num.Trim())).ToArray();

        // Find the maximum number
        int maxNumber = numberSeries.Max();

        // Display the result
        Console.WriteLine($"The maximum number is: {maxNumber}");



        // Assignment 3- Question3.1
        List<string> names = new List<string>();

        while (true)
        {
            Console.Write("Enter a name (or press Enter to finish): ");
            string input6 = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input6))
                break;

            names.Add(input6);
        }

        int count2 = names.Count;

        if (count2 == 1)
            Console.WriteLine($"{names[0]} likes your post.");
        else if (count2 == 2)
            Console.WriteLine($"{names[0]} and {names[1]} like your post.");
        else if (count2 > 2)
            Console.WriteLine($"{names[0]}, {names[1]} and {count - 2} others like your post.");



        // Assignment 3- Question3.2
        Console.Write("Enter your name: ");
        string name1 = Console.ReadLine();

        char[] nameArray = name1.ToCharArray();
        Array.Reverse(nameArray);

        string reversedName = new string(nameArray);

        Console.WriteLine($"Reversed name: {reversedName}");



        //Assignment 3 - Question3.3
        HashSet<int> numbers1 = new HashSet<int>(); // Ensures unique values

        while (numbers1.Count < 5)
        {
            Console.Write($"Enter a unique number ({numbers1.Count + 1}/5): ");
            string input7 = Console.ReadLine();

            if (int.TryParse(input7, out int num))
            {
                if (numbers1.Contains(num))
                {
                    Console.WriteLine("Error: Number already entered. Please enter a different number.");
                }
                else
                {
                    numbers1.Add(num); // Use numbers1, not numbers
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Convert to list, sort, and display
        List<int> sortedNumbers = numbers1.ToList();
        sortedNumbers.Sort();

        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));



        // Assignment 3- Question3.4
        HashSet<int> uniqueNumbers = new HashSet<int>(); // Stores unique numbers

        while (true)
        {
            Console.Write("Enter a number (or type 'Quit' to exit): ");
            string input8 = Console.ReadLine();

            if (input8.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                break;

            if (int.TryParse(input8, out int number3))
            {
                uniqueNumbers.Add(number3); // HashSet ensures uniqueness
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'Quit' to exit.");
            }
        }

        // Display unique numbers
        Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));




        // Assignment 3- Question3.5
        while (true)
        {
            Console.Write("Enter at least 5 comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");
            string input9 = Console.ReadLine();

            // Convert input into an array of numbers
            int[] numbers2 = input9.Split(',')
                                 .Select(num => num.Trim()) // Remove extra spaces
                                 .Where(num => int.TryParse(num, out _)) // Ensure valid numbers
                                 .Select(int.Parse) // Convert to integers
                                 .ToArray();

            if (numbers2.Length < 5)
            {
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                continue;
            }

            // Get the 3 smallest numbers
            var smallestNumbers = numbers.OrderBy(n => n).Take(3);

            Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
            break; // Exit loop after valid input
        }


        // Assignment 4- Question4.1
        Console.Write("Enter numbers separated by a hyphen (e.g., 5-6-7-8-9 or 20-19-18-17-16): ");
        string input10 = Console.ReadLine();

        // Convert input into an array of numbers
        int[] numbers3 = input10.Split('-')
                                .Select(num => num.Trim()) // Remove extra spaces
                                .Where(num => int.TryParse(num, out _)) // Validate numbers
                                .Select(int.Parse) // Convert to integers
                                .ToArray();

        if (numbers3.Length < 2) // Need at least 2 numbers to check for a sequence
        {
            Console.WriteLine("Not Consecutive");
            return;
        }

        // Check if numbers are consecutive (either ascending or descending)
        bool isAscending = numbers3.Zip(numbers3.Skip(1), (a, b) => b - a).All(diff => diff == 1);
        bool isDescending = numbers3.Zip(numbers3.Skip(1), (a, b) => a - b).All(diff => diff == 1);

        Console.WriteLine(isAscending || isDescending ? "Consecutive" : "Not Consecutive");



        // Assignment 4- Question4.2
        Console.Write("Enter numbers separated by a hyphen (e.g., 5-3-8-3-10): ");
        string input11 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input11)) // Exit immediately if input is empty
            return;

        // Convert input into an array of numbers
        int[] numbers4 = input11.Split('-')
                             .Select(num => num.Trim()) // Remove extra spaces
                             .Where(num => int.TryParse(num, out _)) // Validate numbers
                             .Select(int.Parse) // Convert to integers
                             .ToArray();

        // Check for duplicates using HashSet
        HashSet<int> uniqueNumbers1 = new HashSet<int>();

        foreach (var num in numbers4)
        {
            if (!uniqueNumbers1.Add(num)) // If Add() returns false, a duplicate exists
            {
                Console.WriteLine("Duplicate");
                return;
            }
        }

        Console.WriteLine("No Duplicates");



        // Assignment 4- Question4.3
        Console.Write("Enter a time in 24-hour format (HH:mm): ");
        string input12 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input12)) // Check if input is empty
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        string[] parts = input12.Split(':');

        // Ensure the input has exactly two parts (HH and mm)
        if (parts.Length != 2 || !int.TryParse(parts[0], out int hours) || !int.TryParse(parts[1], out int minutes))
        {
            Console.WriteLine("Invalid Time");
            return;
        }

        // Validate hours and minutes range
        if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            Console.WriteLine("Ok");
        else
            Console.WriteLine("Invalid Time");



        // Assignment 4- Question4.4
        Console.Write("Enter a few words separated by spaces: ");
        string input13 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input13)) // Exit if input is empty
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        // Convert input to PascalCase
        string pascalCase = string.Concat(input13
            .ToLower() // Convert to lowercase for uniformity
            .Split(' ', StringSplitOptions.RemoveEmptyEntries) // Split words by space
            .Select(word => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word))); // Capitalize each word

        Console.WriteLine("PascalCase Variable Name: " + pascalCase);




        // Assignment 4- Question4.5
        Console.Write("Enter an English word: ");
        string input14 = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input14)) // Check for empty input
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        // Convert input to lowercase and count vowels (a, e, i, o, u)
        int vowelCount = input14.ToLower().Count(c => "aeiou".Contains(c));

        Console.WriteLine("Number of vowels: " + vowelCount);




        // Assignment 5- Question5.1
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        if (!File.Exists(filePath)) // Check if file exists
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            string content = File.ReadAllText(filePath); // Read file content

            // Split text into words using space and punctuation as delimiters
            int wordCount = content
                .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                .Length;

            Console.WriteLine("Number of words: " + wordCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }




        // Assignment 5- Question5.2
        Console.Write("Enter the file path: ");
        string filePath1 = Console.ReadLine();

        if (!File.Exists(filePath1)) // Check if file exists
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            string content = File.ReadAllText(filePath1); // Read file content

            // Split text into words using space and punctuation as delimiters
            string[] words = content
                .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                Console.WriteLine("No words found in the file.");
                return;
            }

            // Find the longest word(s)
            int maxLength = words.Max(word => word.Length);
            var longestWords = words.Where(word => word.Length == maxLength);

            Console.WriteLine("Longest word(s): " + string.Join(", ", longestWords));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file: " + ex.Message);
        }


    }
}

