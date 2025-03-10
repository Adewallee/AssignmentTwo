using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Assignment 1 - Question 1.1
        Console.Write("Enter a number between 1 and 10: ");
        string userInput = Console.ReadLine();
        bool isValidNumber = double.TryParse(userInput, out double userNumber);

        if (userNumber >= 1 && userNumber <= 10)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }

        // Assignment 1 - Question 1.2
        Console.Write("Enter two numbers separated by a space or comma: ");
        string numbersInput = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(numbersInput))
        {
            Console.WriteLine("No input provided. Please enter two numbers.");
            return;
        }

        // Split input by space or comma
        string[] numberParts = numbersInput.Trim().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Convert strings to double saved as firstNumber and secondNumber
        if (double.TryParse(numberParts[0].Trim(), out double firstNumber) &&
            double.TryParse(numberParts[1].Trim(), out double secondNumber))
        {
            double maxValue = Math.Max(firstNumber, secondNumber);
            Console.WriteLine($"The maximum number is: {maxValue}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter two valid numbers.");
        }

        // Assignment 1 - Question 1.3
        Console.Write("Enter the width of the image: ");
        string widthInput = Console.ReadLine();

        Console.Write("Enter the height of the image: ");
        string heightInput = Console.ReadLine();

        if (double.TryParse(widthInput, out double imageWidth) && double.TryParse(heightInput, out double imageHeight))
        {
            if (imageWidth > imageHeight)
            {
                Console.WriteLine("The image is Landscape.");
            }
            else if (imageHeight > imageWidth)
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

        // Assignment 1 - Question 1.4
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

        // Assignment 2 - Question 2.1
        int divisibleByThreeCount = 0;

        for (int number = 1; number <= 100; number++)
        {
            if (number % 3 == 0)
            {
                divisibleByThreeCount++;
            }
        }

        Console.WriteLine($"Count of numbers divisible by 3 between 1 and 100 is: {divisibleByThreeCount}");

        // Assignment 2 - Question 2.2
        int sumOfNumbers = 0;

        while (true)
        {
            Console.Write("Enter a number or type 'ok' to exit: ");
            string userSumInput = Console.ReadLine();

            if (userSumInput.ToLower() == "ok")
                break;

            sumOfNumbers += int.Parse(userSumInput);
        }

        Console.WriteLine($"Total sum of entered numbers: {sumOfNumbers}");

        // Assignment 2 - Question 2.3
        Console.Write("Enter a number: ");
        int factorialNumber = int.Parse(Console.ReadLine());

        int factorialResult = 1;

        for (int i = factorialNumber; i >= 1; i--)
        {
            factorialResult *= i;
        }

        Console.WriteLine($"{factorialNumber}! = {factorialResult}");

        // Assignment 2 - Question 2.4
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // Picks a random number between 1 and 10
        int maxAttempts = 4;
        bool hasGuessedCorrectly = false;

        Console.WriteLine("Guess a number between 1 and 10. You have 4 chances.");

        for (int attempt = 0; attempt < maxAttempts; attempt++)
        {
            Console.Write($"Attempt {attempt + 1}: ");
            int guessedNumber = int.Parse(Console.ReadLine());

            if (guessedNumber == secretNumber)
            {
                Console.WriteLine("You won!");
                hasGuessedCorrectly = true;
                break;
            }
            else
            {
                Console.WriteLine("Wrong guess. Try again.");
            }
        }

        if (!hasGuessedCorrectly)
        {
            Console.WriteLine($"You lost! The correct number was {secretNumber}.");
        }

        // Assignment 2 - Question 2.5
        Console.Write("Enter a series of numbers separated by a comma: ");
        string numberSeriesInput = Console.ReadLine();
        int[] numberSeries = numberSeriesInput.Split(',').Select(num => int.Parse(num.Trim())).ToArray();

        // Find the maximum number
        int largestNumber = numberSeries.Max();

        // Display the result
        Console.WriteLine($"The maximum number is: {largestNumber}");

        // Assignment 3 - Question 3.1
        List<string> likedNames = new List<string>();

        while (true)
        {
            Console.Write("Enter a name (or press Enter to finish): ");
            string enteredName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(enteredName))
                break;

            likedNames.Add(enteredName);
        }

        int likedNamesCount = likedNames.Count;

        if (likedNamesCount == 1)
            Console.WriteLine($"{likedNames[0]} likes your post.");
        else if (likedNamesCount == 2)
            Console.WriteLine($"{likedNames[0]} and {likedNames[1]} like your post.");
        else if (likedNamesCount > 2)
            Console.WriteLine($"{likedNames[0]}, {likedNames[1]} and {likedNamesCount - 2} others like your post.");

        // Assignment 3 - Question 3.2
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        char[] nameCharacters = userName.ToCharArray();
        Array.Reverse(nameCharacters);

        string reversedUserName = new string(nameCharacters);

        Console.WriteLine($"Reversed name: {reversedUserName}");

        // Assignment 3 - Question 3.3
        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (uniqueNumbers.Count < 5)
        {
            Console.Write($"Enter a unique number ({uniqueNumbers.Count + 1}/5): ");
            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int parsedNumber))
            {
                if (uniqueNumbers.Contains(parsedNumber))
                {
                    Console.WriteLine("Error: Number already entered. Please enter a different number.");
                }
                else
                {
                    uniqueNumbers.Add(parsedNumber);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Convert to list, sort, and display
        List<int> sortedNumbers = uniqueNumbers.ToList();
        sortedNumbers.Sort();

        Console.WriteLine("Sorted numbers: " + string.Join(", ", sortedNumbers));




        // Assignment 3 - Question 3.4
        HashSet<int> uniqueNumbers = new HashSet<int>();

        while (true)
        {
            Console.Write("Enter a number (or type 'Quit' to exit): ");
            string userInput = Console.ReadLine();

            if (userInput.Equals("Quit", StringComparison.OrdinalIgnoreCase))
                break;

            if (int.TryParse(userInput, out int number))
                uniqueNumbers.Add(number);
            else
                Console.WriteLine("Invalid input. Please enter a valid number or 'Quit' to exit.");
        }

        Console.WriteLine("Unique numbers entered: " + string.Join(", ", uniqueNumbers));


        // Assignment 3 - Question 3.5
        while (true)
        {
            Console.Write("Enter at least 5 comma-separated numbers (e.g., 5, 1, 9, 2, 10): ");
            string userNumbers = Console.ReadLine();

            int[] parsedNumbers = userNumbers.Split(',')
                                             .Select(num => num.Trim())
                                             .Where(num => int.TryParse(num, out _))
                                             .Select(int.Parse)
                                             .ToArray();

            if (parsedNumbers.Length < 5)
            {
                Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
                continue;
            }

            Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", parsedNumbers.OrderBy(n => n).Take(3)));
            break;
        }


        // Assignment 4 - Question 4.1
        Console.Write("Enter numbers separated by a hyphen: ");
        string hyphenSeparatedInput = Console.ReadLine();

        int[] sequenceNumbers = hyphenSeparatedInput.Split('-')
                                                    .Select(num => num.Trim())
                                                    .Where(num => int.TryParse(num, out _))
                                                    .Select(int.Parse)
                                                    .ToArray();

        if (sequenceNumbers.Length < 2)
            Console.WriteLine("Not Consecutive");
        else
        {
            bool isAscending = sequenceNumbers.Zip(sequenceNumbers.Skip(1), (a, b) => b - a).All(diff => diff == 1);
            bool isDescending = sequenceNumbers.Zip(sequenceNumbers.Skip(1), (a, b) => a - b).All(diff => diff == 1);
            Console.WriteLine(isAscending || isDescending ? "Consecutive" : "Not Consecutive");
        }


        // Assignment 4 - Question 4.2
        Console.Write("Enter numbers separated by a hyphen: ");
        string duplicateCheckInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(duplicateCheckInput))
        {
            int[] parsedNumbers = duplicateCheckInput.Split('-')
                                                     .Select(num => num.Trim())
                                                     .Where(num => int.TryParse(num, out _))
                                                     .Select(int.Parse)
                                                     .ToArray();

            HashSet<int> uniqueCheck = new HashSet<int>();
            foreach (var num in parsedNumbers)
            {
                if (!uniqueCheck.Add(num))
                {
                    Console.WriteLine("Duplicate");
                    return;
                }
            }
            Console.WriteLine("No Duplicates");
        }


        // Assignment 4 - Question 4.3
        Console.Write("Enter a time in 24-hour format (HH:mm): ");
        string timeInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(timeInput))
        {
            string[] timeParts = timeInput.Split(':');

            if (timeParts.Length == 2 && int.TryParse(timeParts[0], out int hours) && int.TryParse(timeParts[1], out int minutes))
                Console.WriteLine((hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59) ? "Ok" : "Invalid Time");
            else
                Console.WriteLine("Invalid Time");
        }


        // Assignment 4 - Question 4.4
        Console.Write("Enter a few words separated by spaces: ");
        string wordsInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(wordsInput))
        {
            string pascalCase = string.Concat(wordsInput
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(word => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(word)));

            Console.WriteLine("PascalCase Variable Name: " + pascalCase);
        }


        // Assignment 4 - Question 4.5
        Console.Write("Enter an English word: ");
        string wordInput = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(wordInput))
        {
            int vowelCount = wordInput.ToLower().Count(c => "aeiou".Contains(c));
            Console.WriteLine("Number of vowels: " + vowelCount);
        }


        // Assignment 5 - Question 5.1
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                int wordCount = fileContent
                    .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries)
                    .Length;

                Console.WriteLine("Number of words: " + wordCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
        else
            Console.WriteLine("File not found.");


        // Assignment 5 - Question 5.2
        Console.Write("Enter the file path: ");
        string longestWordFilePath = Console.ReadLine();

        if (File.Exists(longestWordFilePath))
        {
            try
            {
                string fileContent = File.ReadAllText(longestWordFilePath);
                string[] words = fileContent
                    .Split(new char[] { ' ', '\n', '\r', '\t', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                if (words.Length > 0)
                {
                    int maxLength = words.Max(word => word.Length);
                    var longestWords = words.Where(word => word.Length == maxLength);
                    Console.WriteLine("Longest word(s): " + string.Join(", ", longestWords));
                }
                else
                    Console.WriteLine("No words found in the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
        else
            Console.WriteLine("File not found.");
    }
}





       