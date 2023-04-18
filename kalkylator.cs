using System;

class Program
{
	static void Main(string[] args)
	{
		bool askForNumber = true;
		float lastNumber = 0;
		string lastOperand = "+";
		while (true)
		{
			if(askForNumber)
			{
				Console.WriteLine("Frågar efter nummer");
				var svar = Console.ReadLine();
				if (lastOperand == "+")
				{
					lastNumber = lastNumber + float.Parse(svar);

				}
				if (lastOperand == "-")
				{
					lastNumber = lastNumber - float.Parse(svar);

				}
				if (lastOperand == "*")
				{
					lastNumber = lastNumber * float.Parse(svar);

				}
				if (lastOperand == "/")
				{
					lastNumber = lastNumber / float.Parse(svar);
				}
				Console.WriteLine(lastNumber.ToString("0.00"));
			}
			else
			{
				Console.WriteLine("frågar efter operand");
				var svar = Console.ReadLine();

				if (svar == "+" || svar == "-"|| svar == "*"|| svar == "/")
				{

				}
				else
				{
					Console.WriteLine("Inte en operand");
				}
				lastOperand = svar;
			}
			askForNumber = !askForNumber;
		}
	}
	static void Two()
	{
		Console.WriteLine("Hello, World!");
	}
}

