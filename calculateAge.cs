using System;
					
public class Program
{
	public static double calculateAge(int birthYear , int birthMonth)
	{
	int year=2021;
	int month=2;
		
    double count=0;
	
		for(int i=birthYear;i<year;i++)
			{
				count++;
			}	
		 int months= birthMonth-month;
		 count=count*12-month;
		 double age=count/12;
		 return age;
	}
	public static void Main()
	{
		Console.WriteLine(calculateAge(2005,4));
	}
}