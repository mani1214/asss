using System;
					
public class Program
{
	public int sumOfRoundedValues(int num1,int num2,int num3)
	{
		if(num1<=0 || num2<=0 || num3<=0)
		{
			return -1;
		}
		int sum=0;
		int res=num1%10;
		int res1=num2%10;
		int res2=num3%10;
		if(res>5 )
		{
			sum=sum+(num1/10)*10;
		}
		else
		{
			sum=sum+(num1/10)*10+10;
		}
		if(res1>5 )
		{
			sum=sum+(num2/10)*10;
		}
		else
		{
			sum=sum+(num2/10)*10+10;
		}
		if(res2>5 )
		{
			sum=sum+(num3/10)*10;
		}
		else
		{
			sum=sum+(num3/10)*10+10;
		}
	
	return sum;	
	}
	public static void Main()
	{
		Program p=new Program();
		Console.WriteLine(p.sumOfRoundedValues(23,45,78));
	}
}