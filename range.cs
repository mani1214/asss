using System;
					
public class Program
{
	public string getNaturalNumbers(int num1,int num2,int num3)
	{
		if(num1==0 || num2==0)
		{
		return "-2";
		}
		if(num1<0||num2<0)
		{
			return "-1";
		}
		if(num1>num2)
		{
			return "-3";
		}
		   if(num1<num2)
        {
            for(int i=num1+1;i<num2;i=i+num3)
                {
                    string s=string.Empty;
                    string result= Convert.ToString(i);
                    Console.Write(result+" ");
                }
        }
		return null;
	}
	public static void Main()
	{
		
		Program p=new Program();
		Console.WriteLine(p.getNaturalNumbers(1,9,3));
		
	}
}