using System;
using System.Linq;
using System.Collections.Generic;

namespace Program2
{
    public class Welcome 
    {         
        public static void Main()
		{
			
				//mohammed osama abd El_salam
			
			Console.WriteLine("Enter the first number");
			int num1 =int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the last number");
			int num2 =int.Parse(Console.ReadLine());
			
			Console.WriteLine("The list of perfect numbers between the number " + "\'"+(num1)+"\'" + " and the number " + "\'" +(num2)+ "\'" + " is : ");
			
			
			int sum=0;
			for(int i=num1; i<=num2; ++i)
			{
				for(int x=1; x<=num2
				{
					if(x<i)
					{
						if(i%x==0)
						sum +=x;
					}
				}
				if(sum==i)
				{
					Console.WriteLine(i);
				}
				
				sum=0; 
			}
			return;
		}
    }
}
