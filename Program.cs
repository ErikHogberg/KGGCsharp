using System;
using ClassLibrary1;

class Program
{
	
	static void Main(string[] args)
	{
		Class1.Two();


		while (true)
		{

			Console.WriteLine("Frågar efter nummer");
			var svar = Console.ReadLine();


			if (svar == "exit")
			{
				return;
			}
			if (svar == null)
			{
				continue;
			}

			float lastNumber = Class1.NewMethod(svar);

			Console.WriteLine(lastNumber.ToString("0.00"));


		}
	}

	
}

