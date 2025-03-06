using System;

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
        string[] numbers = input2.Trim().Split( new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

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


    }
}
