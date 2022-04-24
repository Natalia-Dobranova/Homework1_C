using System;
					
public class Program
{
	public static void Main()
	{  
		Console.WriteLine("Enter the first value x: ");
		double x = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Enter the second value y: ");
		double y = Convert.ToDouble(Console.ReadLine());
			
		if (x > y)
		{
			Console.WriteLine("The first value x is max: " + x);
		} else if (x <y)  
		{
		 Console.WriteLine("The second value y is max: " + y);
		} else 
		{
		Console.WriteLine("The values x and y are equal: " + x);
		}
		
		
		
	}
}