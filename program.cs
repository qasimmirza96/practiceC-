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
		Add();
	}





}