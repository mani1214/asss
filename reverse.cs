using System;
					
public class Program
{
	public static void getNumbersInRange(int n)
	{
	for(int i = n-1; i > 1; i--) {
		
		Console.Write(i + " ");
		}
	}
	public static void Main()
	{
		getNumbersInRange(10);
	}
}