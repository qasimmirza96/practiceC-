using System;
class Program
{
/\*
🔧 Instructions: 1. Ask the user to enter 8 numbers. 2. Store them in an array. 3. Create a second array that stores only the **even numbers** in **reverse order**. 4. Then print the second array.

    */
    static void Main()
    {
    	int[] numbers = new int[8];
    	for (int i = 0; i < numbers.Length; i++)
    	{
    		Console.WriteLine($"Enter number for index {i + 1}: ");
    		numbers[i] = Convert.ToInt32(Console.ReadLine());
    		Console.WriteLine($"Entered number for index {i + 1} is: {numbers[i]} ");
    	}
    	int evenNumbers = 0;
    	for (int i = 0; i < numbers.Length; i++)
    	{
    		if (numbers[i] % 2 == 0)
    		{
    			evenNumbers++;
    		}
    	}
    	int[] secondArray = new int[evenNumbers];
    	int j = 0;
    	for (int i = numbers.Length - 1; i >= 0; i--)
    	{
    		if (numbers[i] % 2 == 0)
    		{

    			secondArray[j] = numbers[i];
    			j++;
    		}

    	}
    	Console.WriteLine("\nEven numbers in reverse order:");
    	for (int i = 0; i < secondArray.Length; i++)
    	{

    		Console.WriteLine($"Entered number for index {i + 1} is: {secondArray[i]} ");
    	}



    }

}
/_
Ask the user to enter 6 numbers.
Store them in an array.
Ask the user to enter another number to search.
Print whether the number is found or not, and at which index.
_/
using System;
class Program
{
static void Main()
{
int[] numbers = new int[6];
for (int i = 0; i < numbers.Length; i++)
{
Console.WriteLine($"Enter the number for index {i}: ");
			numbers[i] = Convert.ToInt32(Console.ReadLine());
		}
		// display the array
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine($"Entered number for index {i} is: {numbers[i]}");

    	}
    }

}
