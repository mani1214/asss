using System;
					
public class Program
{
	public bool countBoolean(bool b1,bool b2,bool b3)
	{
	if(b1=b2=b3){
	return true;
	}
	if(b1=b2||b3){
	return true;
	}
	if(b1=b2&&b3){
	return false;	
	}
	if(b1&&b2&&b3){
	return false;
	}
	return false;	
	}	
	public static void Main()
	{
		Program p1=new Program();
		Console.WriteLine(p1.countBoolean(true,false,false));
	}
}