using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
	public static class Program
	{
		public static void Main()
		{
			//mohammed osama abd El_salam
			
			Console.WriteLine("Enter the first number");
			int num1 =int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the last number");
			int num2 =int.Parse(Console.ReadLine());
			
			
			Console.WriteLine("The list of prime numbers between the number " + "\'"+(num1)+"\'" + " and the number " + "\'" +(num2)+ "\'" + " is : ");
			
			int val =0;
			for(int i=num1; i<=num2; ++i)
			{
				for(int z=1; z<=i; ++z)
				{
					if(i%z==0)
					val++;
				}
				if(val==2)
				{
					Console.WriteLine(i);
					val=0;
				}
				else
				{
					val=0;
					continue;
				}
			}
					
			
			
		}
	}
}