using System;
class Program
{
static void Main()
{
// data types
// int age = 10;
// string personName = "Ikram ";
// double salary = 35.5;
// string profession = "developer";
// bool isJobian = true;
// Console.WriteLine(personName + " is a " + age + " years old " + profession + " and his salary is " + salary + " and currently a " + isJobian);

        // operations
        // int a = 10;
        // int b = 20;
        // bool a = true;
        // bool b = false;

        // Console.WriteLine(a == b); // fasle
        // Console.WriteLine(a != b); // true
        // Console.WriteLine(a > b);  // false
        // Console.WriteLine(a < b); // true
        // Console.WriteLine(a <= b);  // true
        // Console.WriteLine(a => b);  // false


        // Console.WriteLine("a - b = " + a - b);
        // Console.WriteLine("a * b = " + a * b);
        // Console.WriteLine("a / b = " + a / b);
        // Console.WriteLine("a % b = " + a % b);
        // Console.WriteLine(a && b);


    }

}

// if else and switch cases

using System;
class Program
{
static void Main()
{
// int age = 19;
// if (age > 18)
// {
// Console.WriteLine("Your are good to drive Sonata");
// }
// else if (age <= 10)
// {
// Console.WriteLine("Your not are good to drive Sonata cause your age is under 18");

        //     }
        //     else
        //     {
        //         Console.WriteLine("Your are in else block");
        //     }
        int day = 6;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Tuesday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Infinte day");
                break;
        }


    }

}

// loops
// for (int i = 0; i < 10; i++)
// {
// Console.WriteLine(i);

        // }

using System;
class Program
{
/\*

🧪 Practice Task
Write a program that:

Creates an array of 5 integers.

Takes input from the user for each index.

Prints all the elements.

Prints only the even numbers from the array.

    */
    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter a Number for index " + i + " :");
            string enteredNumber = Console.ReadLine();
            numbers[i] = Convert.ToInt32(enteredNumber);
        }
        // printing the arrays indexes
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("index " + i + " : " + numbers[i]);
        }
        Console.WriteLine("\nEven numbers:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Even numbers " + number);
            }
        }
    }

}

using System;
class Program
{
/_
Create an array of 5 integers.
Ask the user to enter 5 numbers (use a loop).
Print all the entered numbers
Find and print:
The maximum number in the array.
The minimum number in the array.
_/
static void Main()
{
int[] numbers = new int[5];
int max = numbers[0];
int min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine("Enter the number for index " + i);
string enteredNumber = Console.ReadLine();
numbers[i] = Convert.ToInt32(enteredNumber);
// Console.WriteLine(enteredNumber);

    	}
    	// printing all the indexes taken from the user
    	for (int i = 0; i < numbers.Length; i++)
    	{
    		Console.WriteLine("The number entered by user at index " + i + " is :" + numbers[i]);
    	}

    	for (int i = 0; i < numbers.Length; i++)
    	{
    		if (numbers[i] > max)
    		{
    			max = numbers[i];
    		}
    		if (numbers[i] < min)
    		{
    			max = numbers[i];
    		}
    	}

    	Console.WriteLine("max: " + max);
    	Console.WriteLine("min: " + min);

    }

}

using System;
class Program
{
/_
🔧 Instructions:
Create an array of 7 integers.
Take 7 numbers as input from the user.
Count:
How many are positive (> 0)
How many are negative (< 0)
How many are zero (== 0)
Print the counts.
_/
static void Main()
{
int[] integers = new int[7];
int positive = 0;
int negative = 0;
int zero = 0;
for (int i = 0; i < integers.Length; i++)
{
Console.WriteLine("Enter the integer for index " + i);
integers[i] = Convert.ToInt32(Console.ReadLine());
if (integers[i] > 0)
positive++;
else if (integers[i] < 0)
negative++;
else
zero++;
}

    	Console.WriteLine($"\npositive: {positive}, negative: {negative}, Xero: {zero} ");

    }

}

using System;
class Program
{
/_
🔧 Instructions:
Create an array of 7 integers.
Take 7 numbers as input from the user.
Count:
How many are positive (> 0)
How many are negative (< 0)
How many are zero (== 0)
Print the counts.
_/
static void Main()
{
int[] integers = new int[7];
int positive = 0;
int negative = 0;
int zero = 0;
for (int i = 0; i < integers.Length; i++)
{
Console.WriteLine("Enter the integer for index " + i);
integers[i] = Convert.ToInt32(Console.ReadLine());
if (integers[i] > 0)
positive++;
else if (integers[i] < 0)
negative++;
else
zero++;
}

    	Console.WriteLine($"\npositive: {positive}, negative: {negative}, Xero: {zero} ");

    }

}

int[] values = new int[6];

    	for (int i = 0; i < values.Length; i++)
    	{
    		Console.WriteLine("Enter the value for index " + i);
    		values[i] = Convert.ToInt32(Console.ReadLine());
    	}

    	int max = values[0];
    	int min = values[0];
    	for (int i = 0; i < values.Length; i++)
    	{

    		if (values[i] > max)
    		{
    			max = values[i];
    		}
    		if (values[i] < min)
    		{
    			min = values[i];
    		}
    	}
    	int difference = max - min;

    	Console.WriteLine($"\ndifference: {difference}, max: {max}, min: {min} ");

using System;
class Program
{
/_
🔧 Instructions:
Ask the user to enter 6 numbers,
Store them in an array,
Create a second array to store only the odd numbers in reverse order,
Then print the second array.
_/
static void Main()
{
int[] integers = new int[6];
int[] secondArray = new int[integers.Length];
for (int i = 0; i < integers.Length; i++)
{
Console.WriteLine($"Enter the number for index {i}: ");
integers[i] = Convert.ToInt32(Console.ReadLine());

    	}
    	// displaying the user's entered values/numbers
    	Console.WriteLine("\nPrinting the whole array ");
    	for (int i = 0; i < integers.Length; i++)
    	{
    		Console.WriteLine($"Entered  number for index {i}   is:  {integers[i]}  ");
    	}

    	// reverse pattern
    	// 	Create a second array to store only the odd numbers in reverse order,
    	Console.WriteLine("\nReversed array ");
    	for (int i = 0; i < integers.Length; i++)
    	{
    		if (integers[i] % 2 != 0)
    		{
    			secondArray[i] = integers[integers.Length - 1 - i];
    		}
    	}
    	// Then print the second array.
    	Console.WriteLine("\nPrinting the second array in reverse order ");
    	for (int i = 0; i < secondArray.Length; i++)
    	{
    		Console.WriteLine($" {secondArray[i]}  ");
    	}

    }

}
