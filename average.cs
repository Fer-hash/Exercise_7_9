//This program calculates the average of a set of marks until the user types "end"
using System;
public class Average
{
	public static void Main()
	{
		double sum = 0, number, counter = 0, average;
		string input;
		Console.Write("Insert a mark: ");
		input = Console.ReadLine();		 
		while(input != "end")
		{  
			number = Convert.ToDouble(input);
			counter++;   
			sum += number;  
			Console.Write("Insert a mark: ");
			input = Console.ReadLine();
		}
		if(counter != 0)
		{
			average = sum / counter;  
			Console.WriteLine("The average is {0}.", average);
		}
	}
}
