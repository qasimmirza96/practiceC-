// functions
using System;

class Program
{
	static void greet(string name)
	{
		Console.WriteLine($"Hello {name}");
	}

	static int Add()
	{
		Console.WriteLine($"Enter first number: ");
		int firstNumber = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Enter second number: ");
		int secondNumber = Convert.ToInt32(Console.ReadLine());
		int sum = firstNumber + secondNumber;
		Console.WriteLine($"sum: {sum}");
		return sum;
	}


	static void Main(string[] args)
	{
		greet("qasim Ali");
		
	}

Creating an Azure SQL Database
Creating an Azure SQL Database involves several steps, all of which can be done through the Azure Portal. Below is a detailed guide to help you set up your SQL database.

1. In the Azure Portal, click the “Create a resource” button in the homepage's upper left corner. In the new resource page, type “SQL Database’ in the search box and select it from the list of services.



}
