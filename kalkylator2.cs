using System;

class Program
{
	enum Operand
	{
		None,
		Plus,
		Minus,
		Multiply,
		Divide,
	}


	static void Main(string[] args)
	{


		bool askForNumber = true;
		float lastNumber = 0;
		Operand lastOperand = Operand.Plus;
		while (true)
		{
			if (askForNumber)
			{
				Console.WriteLine("Frågar efter nummer");
				var svar = Console.ReadLine();
				float nummer;
				if (float.TryParse(svar, out nummer))
				{
					switch (lastOperand)
					{

						case Operand.Plus:

							lastNumber = lastNumber + nummer;
							break;
						case Operand.Minus:
							lastNumber = lastNumber - nummer;
							break;
						case Operand.Multiply:
							lastNumber = lastNumber * nummer;
							break;
						case Operand.Divide:
							lastNumber = lastNumber / nummer;
							break;
						case Operand.None:
						default:
							break;
					}
				}
				else
				{
					Console.WriteLine("inte ett nummer, försök igen");
					continue;
				}


				Console.WriteLine(lastNumber.ToString("0.00"));
			}
			else
			{
				Console.WriteLine("frågar efter operand");
				var svar = Console.ReadLine();

				switch (svar)
				{
					case "+":
						lastOperand = Operand.Plus;
						break;
					case "-":
						lastOperand = Operand.Minus;
						break;
					case "*":
						lastOperand = Operand.Multiply;
						break;
					case "/":
						lastOperand = Operand.Divide;
						break;
					default:
						Console.WriteLine("Inte en operand");
						lastOperand = Operand.None;
						break;
				}
			}
			askForNumber = !askForNumber;
		}
	}
	static void Two()
	{
		Console.WriteLine("Hello, World!");
	}
}

