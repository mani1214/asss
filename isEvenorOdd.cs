using System;

public class Program
{
	public string isEvenOrOdd(int num)
	{
		if(num%2==0)
		{
			return "even";
		}
		if(num%2!=0)
		{
			return "odd";
		}
		if(num==0 || num<0)
		{
		   return "invalid";
		}
		return null;
	}
	
	public static void Main()
	{
          Program p1= new Program();
		  Console.WriteLine( p1.isEvenOrOdd(2));
	}
}