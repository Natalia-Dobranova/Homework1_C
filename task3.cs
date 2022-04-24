using System;
					
public class Program
{
	public static void Main()
	{  
		string name = "Uncopyrightable" ;
		string search = "right";
		
		string end = name.Substring(name.IndexOf('r'),search.Length);	
			
		Console.WriteLine(end);
		
	}
}